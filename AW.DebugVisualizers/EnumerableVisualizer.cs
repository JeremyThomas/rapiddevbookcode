using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration.Provider;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using AW.DebugVisualizers;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.DataEditor;
using JesseJohnston;
using Microsoft.VisualBasic;
using Microsoft.VisualStudio.DebuggerVisualizers;

//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 
//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'

// type - visualizer binding

//Serializable

//-Collections classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ArrayList), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BitArray), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Hashtable), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Queue), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedList), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Stack), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CollectionBase), Description = "Enumerable Visualizer")]

//-Collections.Specialized classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (HybridDictionary), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListDictionary), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (NameObjectCollectionBase), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (OrderedDictionary), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (StringCollection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (StringDictionary), Description = "Enumerable Visualizer")]

//-Collections.Generic classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Dictionary<,>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (List<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (LinkedList<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Queue), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedDictionary<,>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedList), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Stack), Description = "Enumerable Visualizer")]

//-Other classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataView), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTable), Description = "Enumerable Visualizer")]

//-LLBL
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2<>), Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase<>), Description = "Enumerable Visualizer")]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = "Enumerable Visualizer")]

//Not serializable

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BindingSource), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ProviderCollection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (PropertyDescriptorCollection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (InternalDataCollectionBase), Description = "Enumerable Visualizer")]

//LLBL
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase<>), Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery<>), Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase<>), Description = "Enumerable Visualizer")]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSource`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = "Enumerable Visualizer")]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = "Enumerable Visualizer")]

// Won't work

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable.Iterator`1, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+Iterator`1, System.Core", Description = "Enumerable Visualizer")]

namespace AW.DebugVisualizers
{
	public class EnumerableVisualizer : DialogDebuggerVisualizer
	{
		private IDialogVisualizerService _modalService;

		/// <summary>
		/// 	Shows the user interface for the visualizer
		/// </summary>
		/// <param name = "windowService">An object of type <see cref = "T:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService" />, which provides methods your visualizer can use to display Windows forms, controls, and dialogs.</param>
		/// <param name = "objectProvider">An object of type <see cref = "T:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider" />. This object provides communication from the debugger side of the visualizer to the object source (<see cref = "T:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource" />) on the debuggee side.</param>
		protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
		{
			_modalService = windowService;
			if (_modalService == null)
				throw new NotSupportedException("This debugger does not support modal visualizers");

			var o = objectProvider.GetObject();
			var enumerable = o as IEnumerable;
			if (enumerable == null)
			{
				var dataTable = o as DataTable;
				if (dataTable == null)
				{
					var dataTableSurrogate = o as DataTableSurrogate;
					if (dataTableSurrogate != null)
						dataTable = dataTableSurrogate.ConvertToDataTable();
				}
				if (dataTable != null)
					enumerable = dataTable.DefaultView;
			}

			if (enumerable != null)
			{
				_modalService.ShowDialog(DataEditorExtensions.CreateDataViewForm(enumerable));
			}
		}
	}

	public class EnumerableVisualizerObjectSource : VisualizerObjectSource
	{
		#region Overrides of VisualizerObjectSource

		///<summary>
		///	Gets data from the specified object and serializes it into the outgoing data stream
		///	This class implements the debugee side of the visualizer. It is responsible for running the commands against the server.
		///</summary>
		///<remarks>
		///	Straegy is: if the items are serializable then 
		///	if the enumerable is also serializable 
		///	serialize the enumerable
		///	else 
		///	create a ObjectListView to contains the items and serialize that instead. 
		///	Full back is to copy the enumerable to a data table and serialize that instead.
		///</remarks>
		///<param name = "target">Object being visualized.</param>
		///<param name = "outgoingData">Outgoing data stream.</param>
		public override void GetData(object target, Stream outgoingData)
		{
			var enumerable = target as IEnumerable;
			if (enumerable != null)
			{
				var enumerableType = enumerable.GetType();
				var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
				if (itemType.IsSerializable)
				{
					if (enumerableType.IsSerializable)
						Serialize(outgoingData, enumerable);
					else
					{
						try
						{
							var bindingListView = enumerable.ToBindingListView();
							if (!bindingListView.GetType().IsSerializable) // If the IBindingListView is not serializable use a ObjectListView
								bindingListView = new ObjectListView(bindingListView);
							Serialize(outgoingData, bindingListView);
						}
						catch (Exception)
						{
							Serialize(outgoingData, enumerable.CopyToDataTable());
						}
					}
				}
				else
					Serialize(outgoingData, enumerable.CopyToDataTable());
			}
			else if (target is DataTable)
				Serialize(outgoingData, (DataTable)target);
		}

		#endregion

		/// <summary>
		/// 	Gets data from the specified DataTable and serializes it into the outgoing data stream
		/// </summary>
		/// <param name = "outgoingData">The outgoing data.</param>
		/// <param name = "target">The target.</param>
		/// <remarks>
		/// 	The default binary serialization of a DataTable is XML but we want the data to be serialized binary "column" wise
		/// 	so a DataTableSurrogate is used to do this.
		/// </remarks>
		public static void Serialize(Stream outgoingData, DataTable target)
		{
			outgoingData.Position = 0;
			var dataTableSurrogate = new DataTableSurrogate(target);
			Serialize(outgoingData, dataTableSurrogate);
		}

		/// <summary>
		/// 	Serializes an enumerable into a stream - if there is an SerializationException then the enumerable 
		/// 	is copied to a data table and that is serialized instead.
		/// </summary>
		/// <param name = "outgoingData">The outgoing data.</param>
		/// <param name = "enumerable">The enumerable.</param>
		public static void Serialize(Stream outgoingData, IEnumerable enumerable)
		{
			try
			{
				VisualizerObjectSource.Serialize(outgoingData, enumerable);
			}
			catch (SerializationException)
			{
				Serialize(outgoingData, enumerable.CopyToDataTable());
			}
		}
	}
}