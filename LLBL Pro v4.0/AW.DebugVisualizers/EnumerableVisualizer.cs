using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Runtime.Serialization;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.DebuggerVisualizers;

//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'

namespace AW.DebugVisualizers
{
  public class EnumerableVisualizer : DialogDebuggerVisualizer
  {
    private IDialogVisualizerService _modalService;

    /// <summary>
    /// Enumerable Visualizer
    /// </summary>
    public const string Description = "Enumerable Visualizer";

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
      var wr = o as WeakReference;
      if (wr != null)
        o = wr.Target;
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
        _modalService.ShowDialog(FrmDataEditor.CreateDataViewForm(enumerable));
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
    ///	Strategy is: if the items are serializable then 
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
      var wr = target as WeakReference;
      if (wr != null)
        target = wr.Target;
      var enumerable = target as IEnumerable;
      if (enumerable != null)
      {
        var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
        var queryable = enumerable as IQueryable;
        if (queryable != null)
          enumerable = queryable.Take(100);
        var enumerableType = enumerable.GetType();
        if (MetaDataHelper.IsSerializable(itemType))
        {
          if (MetaDataHelper.IsSerializable(enumerableType))
            Serialize(outgoingData, enumerable);
          else
          {
            try
            {
              var bindingListView = enumerable.ToBindingListView() ?? BindingListHelper.CreateObjectListView(enumerable, itemType);
              if (!MetaDataHelper.IsSerializable(bindingListView.GetType())) // If the IBindingListView is not serializable use a ObjectListView
                bindingListView = BindingListHelper.CreateObjectListView(bindingListView, itemType);
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
        Serialize(outgoingData, (DataTable) target);
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