﻿using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Reflection;
using DataContextDriverDemo.Universal;
using LINQPad.Extensibility.DataContext;

namespace AW.LLBLGen.DataContextDriver.Static
{
	/// <summary>
	/// This static driver let users query any data source that looks like a Data Context - in other words,
	/// that exposes properties of type IEnumerable of T.
	/// </summary>
	public class LLBLGenStaticDriver: StaticDataContextDriver
	{
		public override string Name
		{
			get { return "AW LLBL Driver"; }
		}

		public override string Author
		{
			get { return "Jeremy Thomas"; }
		}

		public override string GetConnectionDescription(IConnectionInfo cxInfo)
		{
			// For static drivers, we can use the description of the custom type & its assembly:
			return cxInfo.CustomTypeInfo.GetCustomTypeDescription();
		}

		public override bool ShowConnectionDialog(IConnectionInfo cxInfo, bool isNewConnection)
		{
			// Prompt the user for a custom assembly and type name:
			return new ConnectionDialog(cxInfo).ShowDialog() == true;
		}

		public override void InitializeContext(IConnectionInfo cxInfo, object context, QueryExecutionManager executionManager)
		{
			// If the data context happens to be a LINQ to SQL DataContext, we can look up the SQL translation window.
			var l2s = context as DataContext;
			if (l2s != null) l2s.Log = executionManager.SqlTranslationWriter;
		}

		public override List<ExplorerItem> GetSchema(IConnectionInfo cxInfo, Type customType)
		{
			// Return the objects with which to populate the Schema Explorer by reflecting over customType.

			// We'll start by retrieving all the properties of the custom type that implement IEnumerable<T>:
			var topLevelProps =
				(
					from prop in customType.GetProperties()
					where prop.PropertyType != typeof (string)
					// Display all properties of type IEnumerable<T> (except for string!)
					let ienumerableOfT = prop.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1")
					where ienumerableOfT != null
					orderby prop.Name
					select new ExplorerItem(prop.Name, ExplorerItemKind.QueryableObject, ExplorerIcon.Table)
					       	{
					       		IsEnumerable = true,
					       		ToolTipText = FormatTypeName(prop.PropertyType, false),
					       		// Store the entity type to the Tag property. We'll use it later.
					       		Tag = ienumerableOfT.GetGenericArguments()[0]
					       	}
				).ToList();

			// Create a lookup keying each element type to the properties of that type. This will allow
			// us to build hyperlink targets allowing the user to click between associations:
			var elementTypeLookup = topLevelProps.ToLookup(tp => (Type)tp.Tag);

			// Populate the columns (properties) of each entity:
			foreach (var table in topLevelProps)
				table.Children = ((Type)table.Tag)
					.GetProperties()
					.Select(childProp => GetChildItem(elementTypeLookup, childProp))
					.OrderBy(childItem => childItem.Kind)
					.ToList();

			return topLevelProps;
		}

		private static ExplorerItem GetChildItem(ILookup<Type, ExplorerItem> elementTypeLookup, PropertyInfo childProp)
		{
			// If the property's type is in our list of entities, then it's a Many:1 (or 1:1) reference.
			// We'll assume it's a Many:1 (we can't reliably identify 1:1s purely from reflection).
			if (elementTypeLookup.Contains(childProp.PropertyType))
				return new ExplorerItem(childProp.Name, ExplorerItemKind.ReferenceLink, ExplorerIcon.ManyToOne)
				       	{
				       		HyperlinkTarget = elementTypeLookup[childProp.PropertyType].First(),
				       		// FormatTypeName is a helper method that returns a nicely formatted type name.
				       		ToolTipText = FormatTypeName(childProp.PropertyType, true)
				       	};

			// Is the property's type a collection of entities?
			var ienumerableOfT = childProp.PropertyType.GetInterface("System.Collections.Generic.IEnumerable`1");
			if (ienumerableOfT != null)
			{
				var elementType = ienumerableOfT.GetGenericArguments()[0];
				if (elementTypeLookup.Contains(elementType))
					return new ExplorerItem(childProp.Name, ExplorerItemKind.CollectionLink, ExplorerIcon.OneToMany)
					       	{
					       		HyperlinkTarget = elementTypeLookup[elementType].First(),
					       		ToolTipText = FormatTypeName(elementType, true)
					       	};
			}

			// Ordinary property:
			return new ExplorerItem(childProp.Name + " (" + FormatTypeName(childProp.PropertyType, false) + ")",
			                        ExplorerItemKind.Property, ExplorerIcon.Column);
		}
	}
}