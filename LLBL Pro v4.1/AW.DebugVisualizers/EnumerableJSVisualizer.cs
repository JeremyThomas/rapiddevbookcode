//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using AW.Helper;
using AW.Winforms.Helpers.DataEditor;
using Microsoft.VisualStudio.DebuggerVisualizers;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace AW.DebugVisualizers
{
  public class EnumerableJSVisualizer : DialogDebuggerVisualizer
  {
    private IDialogVisualizerService _modalService;
    private JToken _firstJToken;

    /// <summary>
    ///   Enumerable Visualizer with JSON Serializer
    /// </summary>
    public const string Description = "Enumerable Visualizer with JSON Serializer";

    /// <summary>
    ///   Shows the user interface for the visualizer
    /// </summary>
    /// <param name="windowService">
    ///   An object of type
    ///   <see
    ///     cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService" />
    ///   , which provides methods your visualizer can use to display Windows forms, controls, and dialogs.
    /// </param>
    /// <param name="objectProvider">
    ///   An object of type
    ///   <see
    ///     cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider" />
    ///   . This object provides communication from the debugger side of the visualizer to the object source (
    ///   <see
    ///     cref="T:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource" />
    ///   ) on the debuggee side.
    /// </param>
    protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
    {
      _modalService = windowService;
      if (_modalService == null)
        throw new NotSupportedException("This debugger does not support modal visualizers");

      var s2 = new StreamReader(objectProvider.GetData()).ReadToEnd();
      var enumerable = JsonStringToEnumerable(s2);
      if (enumerable != null)
        _modalService.ShowDialog(FrmDataEditor.CreateDataViewForm(enumerable));
    }

    private IEnumerable JsonStringToEnumerable(string s2)
    {
      var deserializeObject = JsonConvert.DeserializeObject(s2, EnumerableJSVisualizerObjectSource.JsonSerializerSettingsTypeNameHandlingAll);
      DataTable dataTable = null;
      IEnumerable enumerable = null;
      if (deserializeObject is JArray)
        dataTable = CopyToDataTable(deserializeObject as JArray);
      else
      {
        enumerable = deserializeObject as IEnumerable;
        if (enumerable == null)
          try
          {
            dataTable = JsonConvert.DeserializeObject<DataTable>(s2, new DataTableConverter());
          }
          catch (Exception)
          {
            var jToken = JToken.Parse(s2);
            if (jToken is JArray)
              dataTable = CopyToDataTable(jToken as JArray);
          }
      }
      if (dataTable != null)
        enumerable = dataTable.DefaultView;
      return enumerable;
    }

    private DataTable CopyToDataTable(JArray source)
    {
      _firstJToken = source.FirstOrDefault();
      if (_firstJToken == null) return new DataTable();
      if (!_firstJToken.HasValues)
      {
        _firstJToken = _firstJToken.Root;
        return ValueTypeWrapper.CreateWrapperForBinding(_firstJToken.Root).CopyToDataTable();
      }
      return new ObjectShredder(GetPropertiesToSerialize).Shred(source, null, null);
    }

    private IEnumerable<PropertyDescriptor> GetPropertiesToSerialize(Type type)
    {
      return (from childToken in _firstJToken.OfType<JProperty>()
        select
          new JPropertyDescriptor(childToken.Name));
    }

    public object DeserializeJS(Stream serializationStream)
    {
      var s = new StreamReader(serializationStream).ReadToEnd();
      var enumerable = JsonStringToEnumerable(s);
      return enumerable ?? JToken.Parse(s);
    }
  }

  public class EnumerableJSVisualizerObjectSource : VisualizerObjectSource
  {
    private static readonly ITraceWriter TraceWriter = new MemoryTraceWriter();
    public static readonly JsonSerializerSettings JsonSerializerSettingsTypeNameHandlingAll = new JsonSerializerSettings {TraceWriter = TraceWriter, ReferenceLoopHandling = ReferenceLoopHandling.Ignore, TypeNameHandling = TypeNameHandling.All}; //
    private static readonly JsonSerializerSettings JsonSerializerSettingsReferenceLoopHandlingIgnore = new JsonSerializerSettings {TraceWriter = TraceWriter, ReferenceLoopHandling = ReferenceLoopHandling.Ignore};

    #region Overrides of VisualizerObjectSource

    /// <summary>
    ///   Gets data from the specified object and serializes it into the outgoing data stream
    ///   This class implements the debugee side of the visualizer. It is responsible for running the commands against the
    ///   server.
    /// </summary>
    /// <remarks>
    ///   Strategy is: if the items are serializable then
    ///   if the enumerable is also serializable
    ///   serialize the enumerable
    ///   else
    ///   create a ObjectListView to contains the items and serialize that instead.
    ///   Full back is to copy the enumerable to a data table and serialize that instead.
    /// </remarks>
    /// <param name="target"> Object being visualized. </param>
    /// <param name="outgoingData"> Outgoing data stream. </param>
    public override void GetData(object target, Stream outgoingData)
    {
      var wr = target as WeakReference;
      if (wr != null)
        target = wr.Target;
      var enumerable = target as IEnumerable;
      if (enumerable != null)
      {
        var queryable = enumerable as IQueryable;
        if (queryable != null)
          enumerable = queryable.Take(100);
        SerializeJS(outgoingData, enumerable);
      }
      else if (target is DataTable)
        SerializeJSPlain(outgoingData, target);
    }

    #endregion

    private static void SerializeJS(Stream outgoingData, IEnumerable enumerable)
    {
      var dataView = enumerable as DataView;
      if (dataView != null)
      {
        SerializeJSTypeNameHandlingAll(outgoingData, dataView.Table);
        return;
      }
      var enumerableType = enumerable.GetType();
      // var x = enumerable as IQueryable;
      var itemType = MetaDataHelper.GetEnumerableItemType(enumerable);
      var fullName = enumerableType.FullName;
      if (fullName.Contains("System.Data.Linq"))
        SerializeJS(outgoingData, enumerable.CopyToDataTable(), JsonSerializerSettingsReferenceLoopHandlingIgnore);
      else if (itemType.Implements(typeof (ISerializable)) || enumerableType.Implements(typeof (ISerializable)) || enumerable is XmlNodeList)
        SerializeJS(outgoingData, GeneralHelper.CopyToDataTable(enumerable, MetaDataHelper.GetPropertiesToDisplay), JsonSerializerSettingsReferenceLoopHandlingIgnore);
      else if (fullName.Contains("System.Linq.Enumerable"))
        SerializeJS(outgoingData, MetaDataHelper.ConvertToList(enumerable), JsonSerializerSettingsReferenceLoopHandlingIgnore);
      else if (enumerable is DataRelationCollection || enumerable is SettingsPropertyValueCollection
               || enumerableType.Name.Contains("ValuesCollection") || enumerableType.Name.Contains("ValueCollection")
               || enumerableType.Name.Contains("NamesCollection") || enumerableType.Name.Contains("NameCollection")
               || fullName.Contains("JesseJohnston.ObjectListView") || enumerableType.Name.Contains("KeyCollection") || enumerableType.Name.Contains("KeysCollection")
               || itemType.IsAssignableTo(typeof (SettingsProperty))
               || itemType.IsAssignableTo(typeof (PropertyDescriptor)) || itemType.IsAssignableTo(typeof (DataRow)) || enumerableType.Implements("SD.LLBLGen.Pro.ORMSupportClasses.IEntityFields"))
        SerializeJS(outgoingData, enumerable, JsonSerializerSettingsReferenceLoopHandlingIgnore);
      else if (enumerable is XmlSchemaObjectCollection || enumerable is StringDictionary
        )
        SerializeJS(outgoingData, enumerable, JsonSerializerSettingsReferenceLoopHandlingIgnore);
      else
      {
        if (fullName.Contains("System.Linq.Lookup") || fullName.Contains("System.Xml.Linq.XContainer"))
          enumerable = MetaDataHelper.ConvertToArray(enumerable);
        SerializeJS(outgoingData, enumerable, itemType.Assembly.GlobalAssemblyCache, enumerableType.Assembly.GlobalAssemblyCache);
      }
    }

    private static void SerializeJS(Stream outgoingData, IEnumerable enumerable, bool itemTypeInGac, bool enumerableTypeInGac)
    {
      Debug.Write(enumerable.GetType());
      if (itemTypeInGac)
        if (enumerableTypeInGac)
          SerializeJSTypeNameHandlingAll(outgoingData, enumerable);
        else
          SerializeJS(outgoingData, enumerable, new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.Objects, TraceWriter = TraceWriter,});
      else if (enumerableTypeInGac)
        SerializeJS(outgoingData, enumerable, new JsonSerializerSettings {TypeNameHandling = TypeNameHandling.Arrays, TraceWriter = TraceWriter});
      else
        SerializeJSPlain(outgoingData, enumerable);
    }

    private static void SerializeJSPlain(Stream outgoingData, object enumerable)
    {
      StringToStream(outgoingData, JsonConvert.SerializeObject(enumerable));
    }

    private static void SerializeJSTypeNameHandlingAll(Stream outgoingData, object enumerable)
    {
      SerializeJS(outgoingData, enumerable, JsonSerializerSettingsTypeNameHandlingAll);
    }

    private static void SerializeJS(Stream outgoingData, object enumerable, JsonSerializerSettings jsonSerializerSettingsTypeNameHandlingAll)
    {
      StringToStream(outgoingData, JsonConvert.SerializeObject(enumerable, jsonSerializerSettingsTypeNameHandlingAll));
    }

    private static void StringToStream(Stream outgoingData, string s1)
    {
      Debug.Write(TraceWriter);
      var writer = new StreamWriter(outgoingData);
      writer.Write(s1);
      writer.Flush();
    }
  }
}