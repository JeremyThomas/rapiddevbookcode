using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'

namespace AW.DebugVisualizers
{
  public class EnumerableJSVisualizer : DialogDebuggerVisualizer
  {
    private IDialogVisualizerService _modalService;
    private JToken _firstJToken;

    /// <summary>
    ///   Enumerable Visualizer
    /// </summary>
    public const string Description = "Enumerable Visualizer";

    /// <summary>
    ///   Shows the user interface for the visualizer
    /// </summary>
    /// <param name="windowService"> An object of type <see
    ///    cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService" /> , which provides methods your visualizer can use to display Windows forms, controls, and dialogs. </param>
    /// <param name="objectProvider"> An object of type <see
    ///    cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider" /> . This object provides communication from the debugger side of the visualizer to the object source ( <see
    ///    cref="T:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource" /> ) on the debuggee side. </param>
    protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
    {
      _modalService = windowService;
      if (_modalService == null)
        throw new NotSupportedException("This debugger does not support modal visualizers");

      var enumerable = EnumerableJSVisualizerObjectSource.DeserializeJS(objectProvider.GetData());

      if (enumerable != null)
      {
       // var dataTableConverter = new DataTableConverter();
        //dataTableConverter.ReadJson()
        _firstJToken = enumerable.First();
        if (_firstJToken != null)
          _modalService.ShowDialog(FrmDataEditor.CreateDataViewForm(CopyToDataTable(enumerable).DefaultView));
      }
    }

    public DataTable CopyToDataTable(JArray source)
    {
      return new ObjectShredder(GetPropertiesToSerialize).Shred(source, null, null);
    }

    public IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(Type type)
    {
      return (from childToken in _firstJToken.OfType<JProperty>()
              select
                new JPropertyDescriptor(childToken.Name, typeof (object))).Cast<PropertyDescriptor>();
    }
  }

  public class EnumerableJSVisualizerObjectSource : VisualizerObjectSource
  {
    private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings {ReferenceLoopHandling = ReferenceLoopHandling.Ignore};

    #region Overrides of VisualizerObjectSource

    ///<summary>
    ///  Gets data from the specified object and serializes it into the outgoing data stream
    ///  This class implements the debugee side of the visualizer. It is responsible for running the commands against the server.
    ///</summary>
    ///<remarks>
    ///  Strategy is: if the items are serializable then 
    ///  if the enumerable is also serializable 
    ///  serialize the enumerable
    ///  else 
    ///  create a ObjectListView to contains the items and serialize that instead. 
    ///  Full back is to copy the enumerable to a data table and serialize that instead.
    ///</remarks>
    ///<param name="target"> Object being visualized. </param>
    ///<param name="outgoingData"> Outgoing data stream. </param>
    public override void GetData(object target, Stream outgoingData)
    {
      var wr = target as WeakReference;
      if (wr != null)
        target = wr.Target;
      var enumerable = target as IEnumerable;
      if (enumerable != null)
      {
        //var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
        var queryable = enumerable as IQueryable;
        if (queryable != null)
          enumerable = queryable.Take(100);
        //  var enumerableType = enumerable.GetType();
        //    if (MetaDataHelper.IsSerializable(enumerableType))
        SerializeJS(outgoingData, enumerable);
        //else
        //{
        //  var bindingListView = enumerable.ToBindingListView() ?? BindingListHelper.CreateObjectListView(enumerable, itemType);
        //  SerializeJS(outgoingData, bindingListView);
        //}

        //TypeSerializer.SerializeToStream(enumerable, outgoingData);
      }
      else if (target is DataTable)
        SerializeJS(outgoingData, target);
    }

    #endregion

    public static void SerializeJS(Stream outgoingData, object enumerable)
    {
      //TypeSerializer.SerializeToStream(enumerable, outgoingData);
      var s1 = JsonConvert.SerializeObject(enumerable, JsonSerializerSettings);
      var writer = new StreamWriter(outgoingData);
      writer.Write(s1);
      writer.Flush();
    }

    public static JArray DeserializeJS(Stream serializationStream)
    {
      var s2 = new StreamReader(serializationStream).ReadToEnd();
      var jsonObject = JArray.Parse(s2);
      //if (jsonObject is JContainer)
      //  return jsonObject as JContainer;
      // return JsonConvert.DeserializeObject(s2, JsonSerializerSettings);
      return jsonObject;
    }
  }
}