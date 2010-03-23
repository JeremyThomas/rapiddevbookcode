using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using Microsoft.VisualStudio.DebuggerVisualizers;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 
//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'

// type - visualizer binding

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EntityCollectionBase2<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EntityCollectionBase<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (List<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ArrayList), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataView), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTable), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection<>), Description = "Enumerable Visualizer")]

//Not serializable

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BindingSource), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (LLBLGenProQuery<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Iterator`1, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataSourceBase<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EntityViewBase<>), Description = "Enumerable Visualizer")]

namespace AW.DebugVisualizers
{
	public class EnumerableVisualizer : DialogDebuggerVisualizer
	{
		private IDialogVisualizerService _modalService;

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

		/// <summary>
		/// </summary>
		/// <param name = "target">Object being visualized.</param>
		/// <param name = "outgoingData">Outgoing data stream.</param>
		public override void GetData(object target, Stream outgoingData)
		{
			var enumerable = target as IEnumerable;
			if (enumerable != null)
			{
				var enumerableType = enumerable.GetType();
				var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
				GeneralHelper.TraceOut("enumerableType.IsSerializable " + enumerableType.IsSerializable + " itemType.IsSerializable" + itemType.IsSerializable);
				if (enumerableType.IsSerializable && itemType.IsSerializable)
					TryGetData(enumerable, outgoingData);
				else if (itemType.IsSerializable)
				{
					var bindingListView = enumerable.ToBindingListView();
					if (!bindingListView.GetType().IsSerializable)
						bindingListView = new ObjectListView(new ArrayList(bindingListView));
					TryGetData(bindingListView, outgoingData);
				}
				else
					base.GetData(enumerable.CopyToDataTable(), outgoingData);
			}
			else if (target is DataTable)
				base.GetData(target, outgoingData);
		}

		public void TryGetData(IEnumerable enumerable, Stream outgoingData)
		{
			try
			{
				base.GetData(enumerable, outgoingData);
			}
			catch (SerializationException)
			{
				base.GetData(enumerable.CopyToDataTable(), outgoingData);
			}
		}

		#endregion
	}
}