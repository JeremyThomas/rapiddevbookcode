// ObjectListView
// Copyright © 2006, 2007 Jesse Johnston.  All rights reserved.

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace JesseJohnston
{
	internal class FilterEvaluator
	{
		protected FilterNode tree;
		protected PropertyDescriptorCollection props;
		private object currentListItem;
		private Dictionary<FilterNode, Predicate> nodePredicates = new Dictionary<FilterNode, Predicate>();

		public PropertyDescriptorCollection FilterProperties
		{
			get { return props; }
		}

		public FilterEvaluator(FilterNode expressionTree, PropertyDescriptorCollection listItemProperties)
		{
			if (expressionTree == null)
				throw new ArgumentNullException("expressionTree");
			if (listItemProperties == null)
				throw new ArgumentNullException("listItemProperties");
			if (listItemProperties.Count == 0)
				throw new ArgumentException("listItemProperties");

			this.tree = expressionTree;

			this.CreatePredicates(expressionTree, listItemProperties);
		}

		public bool Matches(object listItem)
		{
			if (listItem == null)
				throw new ArgumentNullException("listItem");
			this.currentListItem = listItem;

			bool result = this.tree.Evaluate(this.Evaluator);

			// The expression tree must be re-evaluated anew for each list item.
			this.tree.Reset();

			return result;
		}

		protected virtual void CreatePredicates(FilterNode tree, PropertyDescriptorCollection properties)
		{
			nodePredicates = new Dictionary<FilterNode, Predicate>();

			List<PropertyDescriptor> propList = new List<PropertyDescriptor>();

			foreach (FilterNode node in tree)
			{
				// Only create predicates for terminal nodes.
				if (node.Term == null)
					continue;

				string propertyName = node.Term.PropertyName;
				string propertyValue = node.Term.Value;
				PropertyDescriptor property = null;

				// Verify that the property name in the expression is a property of the list item type.
				// If the property name is of the form "A.B", it is assumed to refer to a property of a property (a property path).
				if (propertyName.Contains("."))
				{
					property = new PropertyPathDescriptor(properties[0].ComponentType, propertyName);
				}
				else
				{
					foreach (PropertyDescriptor prop in properties)
					{
						if (prop.Name == propertyName)
						{
							property = prop;
							break;
						}
					}
				}

				if (property == null)
					throw new ArgumentException("The property '" + propertyName + "' is not a property of the list item type.", "Filter");

				if (!propList.Contains(property))
					propList.Add(property);

				// "null" is a special literal meaning a null value, not the characters 'n' 'u' 'l' 'l'.
				if (string.Compare(propertyValue, "null", true) == 0)
					propertyValue = null;

				// If the property is of string type, create a predicate that does regular expression matching.  Otherwise create a predicate
				// that uses the default Comparer<T> where T is the property type.
				Predicate predicate = null;
				if (property.PropertyType == typeof(string))
				{
					predicate = new StringComparerPredicate(property, propertyValue, node.Term.Operator).Matches;
				}
				else
				{
					Type predicateType = typeof(PropertyComparerPredicate<>).MakeGenericType(new Type[] { property.PropertyType });
					object pred = Activator.CreateInstance(predicateType, property, propertyValue, node.Term.Operator);
					predicate = (Predicate)Delegate.CreateDelegate(typeof(Predicate), pred, predicateType.GetMethod("Matches"));
				}

				// Save the predicate for use by the Evaluator method.
				this.nodePredicates.Add(node, predicate);
			}

			// Save the list of properties referenced in the filter expression.
			this.props = new PropertyDescriptorCollection(propList.ToArray(), true);
		}

		private bool Evaluator(FilterNode node)
		{
			return this.nodePredicates[node](this.currentListItem);
		}
	}
}
