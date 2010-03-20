﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml.Serialization;
using AW.DebugVisualizers;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Controls;
using JesseJohnston;
using Microsoft.VisualStudio.DebuggerVisualizers;
using SD.LLBLGen.Pro.LinqSupportClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 
//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'

// type - visualizer binding

[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (EntityCollectionBase2<>), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (EntityCollectionBase<>), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (List<>), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (ArrayList), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (ObjectListView), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (ObjectListView<>), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (DataView), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (DataTable), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (Collection<>), Description = "Enumerable Visualizer")]

//Not serializable
[assembly : DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(VisualizerObjectSource), Target = typeof(BindingSource), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(VisualizerObjectSource), Target = typeof(LLBLGenProQuery<>), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(VisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery, System.Core", Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (DataSourceBase<>), Description = "Enumerable Visualizer")]
[assembly : DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (VisualizerObjectSource), Target = typeof (EntityViewBase<>), Description = "Enumerable Visualizer")]

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

      IEnumerable enumerable = null;
      try
      {
        enumerable = objectProvider.GetObject() as IEnumerable;
      }
      catch (SerializationException)
      {
        var xmlStream = objectProvider.GetData();
        var x = new XmlSerializer(typeof(ObjectListView));
        var r = x.Deserialize(xmlStream);
      }

      if (enumerable != null)
      {
        var gridDataEditor = new GridDataEditor();
        gridDataEditor.BindEnumerable(enumerable);
        _modalService.ShowDialog(gridDataEditor);
      }
    }
  }

  public class EnumerableVisualizerObjectSource : VisualizerObjectSource
  {
    #region Overrides of VisualizerObjectSource

    public override void GetData(object target, Stream outgoingData)
    {
      var enumerable = target as IEnumerable;
      if (enumerable != null)
      {
        var enumerableType = enumerable.GetType();
        var itemType = BindingListHelper.GetEnumerableItemType(enumerable);
        if (enumerableType.IsSerializable && itemType.IsSerializable)
          base.GetData(target, outgoingData);
        else if (itemType.IsSerializable)
        {
          var bindingListView = enumerable.ToBindingListView();
          if (!bindingListView.GetType().IsSerializable)
          {
            bindingListView = new ObjectListView(new ArrayList(bindingListView));
          }
          base.GetData(bindingListView, outgoingData);
        }
        else
        {
          var list = enumerable as IList;
          if (list != null)
            Serialize(list, outgoingData, itemType);
        }
      }
    }

    public static void Serialize(IList list, Stream outgoingData, Type itemType)
    {
      var x = new XmlSerializer(typeof (ObjectListView), new[] {itemType});
      x.Serialize(outgoingData, new ObjectListView(list));
    }

    #endregion
  }
}