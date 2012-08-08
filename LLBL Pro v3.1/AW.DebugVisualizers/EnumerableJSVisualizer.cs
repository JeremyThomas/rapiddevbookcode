using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Runtime.Serialization;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
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

      var s2 = new StreamReader(objectProvider.GetData()).ReadToEnd();
      DataTable dataTable = null;
      try
      {
        dataTable = JsonConvert.DeserializeObject<DataTable>(s2, new DataTableConverter());
      }
      catch (Exception)
      {
        var jToken = JToken.Parse(s2);
        if (jToken is JArray)
          dataTable = CopyToDataTable(jToken as JArray);
        else
        {
          ;
        }
      }


      if (dataTable != null)
      {
        _modalService.ShowDialog(FrmDataEditor.CreateDataViewForm(dataTable.DefaultView));
      }
    }

    public DataTable CopyToDataTable(JArray source)
    {
      _firstJToken = source.FirstOrDefault();
      return _firstJToken == null ? new DataTable() : new ObjectShredder(GetPropertiesToSerialize).Shred(source, null, null);
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
    private static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings {ReferenceLoopHandling = ReferenceLoopHandling.Ignore}; //, TypeNameHandling = TypeNameHandling.All

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
        var dataView = enumerable as DataView;
        if (dataView != null)
        {
          SerializeJS(outgoingData, dataView.Table);
          return;
        }
        var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
        var queryable = enumerable as IQueryable;
        if (queryable != null)
          enumerable = queryable.Take(100);
        var enumerableType = enumerable.GetType();
        if (itemType.Implements(typeof (ISerializable)) || enumerableType.Implements(typeof (ISerializable)))
          SerializeJS(outgoingData, enumerable.CopyToDataTable());
        else
          SerializeJS(outgoingData, enumerable);
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
      try
      {
        var jToken = JToken.Parse(s2);
        if (jToken is JArray)
        {
          try
          {
          var deserializeObject = JsonConvert.DeserializeObject<DataTable>(s2, new DataTableConverter());
          }
          catch (Exception)
          {
          }
          return jToken as JArray;
        }
        var jsonObject = JArray.Parse(s2);
        var x1 = JsonConvert.DeserializeObject(s2);
        var deserializeObject1 = JsonConvert.DeserializeObject<DataTable>(s2, new DataTableConverter());
        return jsonObject;
      }
      catch (Exception e)
      {
        var jsonObject = JObject.Parse(s2);
        var x = JsonConvert.DeserializeObject(s2);
      }

      //if (jsonObject is JContainer)
      //  return jsonObject as JContainer;
      // return JsonConvert.DeserializeObject(s2, JsonSerializerSettings);
      return null;
    }
  }
}