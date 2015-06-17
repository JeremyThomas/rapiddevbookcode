using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Dynamic;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using AW.Helper;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.DataEditor;
using AW.Winforms.Helpers.Misc;
using Microsoft.VisualStudio.DebuggerVisualizers;

//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'

namespace AW.DebugVisualizers
{
  public class EnumerableVisualizer : DialogDebuggerVisualizer
  {
    private IDialogVisualizerService _modalService;

    /// <summary>
    ///   Enumerable Visualizer
    /// </summary>
    public const string Description = "Enumerable Visualizer";

    public const string DescriptionV46 = Description + " V4.6";
    public const string DescriptionV45 = Description + " V4.0";

    /// <summary>
    ///   Gets the BCL major minor version. e.g. 4.5 or 4.6
    /// </summary>
    /// <returns></returns>
    public static string GetBclMajorMinorVersion()
    {
      return FileVersionInfo.GetVersionInfo(typeof (Enumerable).Assembly.Location).FileVersion.Substring(0, 3);
    }

    public static IEnumerable<string> CreateVisualizerRegistrationsNestedNotGenericSealed(Assembly assembly)
    {
      var majorMinorVersion = GetBclMajorMinorVersion().Replace(".","");
      var visualizerRegistrations = assembly
        .GetTypes().Where(t =>
          t.GetInterface("IEnumerable") != null && !t.IsInterface
          && !t.IsPublic
          && !t.IsSerializable
          && t.IsNested && !t.IsGenericType
          && t.IsSealed
          && (t.BaseType == null || t.BaseType.FullName == "System.Object"))
        .Select(t => string.Format("[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = \"{0}\", Description = EnumerableVisualizer.DescriptionV{1})]",
          GetClassAssemblyName(t), majorMinorVersion))
        .OrderBy(n => n);
      return visualizerRegistrations;
    }

    private static string GetClassAssemblyName(Type t)
    {
      return t.AssemblyQualifiedName == null ? String.Empty : t.AssemblyQualifiedName.Substring(0, t.AssemblyQualifiedName.IndexOf(',', t.FullName.Length + 1));
    }

    public static IEnumerable<string> CreateOtherPrivateVisualizerRegistrations(Assembly assembly)
    {
      var visualizerRegistrations = from t in assembly.GetTypes()
        where
          t.GetInterface("IEnumerable") != null && !t.IsInterface
          && !t.IsPublic
          && (t.IsSerializable|| !t.IsNested ||t.IsGenericType || !t.IsSealed)
          && (t.BaseType == null || t.BaseType.FullName == "System.Object")
        select string.Format("[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = \"{0}\", Description = EnumerableVisualizer.Description)]",
          GetClassAssemblyName(t));
      return visualizerRegistrations.OrderBy(n => n);
    }

    public static IEnumerable<string> CreatePublicVisualizerRegistrations(Assembly assembly)
    {
      var visualizerRegistrations = from t in assembly.GetTypes()
        where
          t.GetInterface("IEnumerable") != null && !t.IsInterface
          && t.IsPublic
          && (t.BaseType == null || t.BaseType.FullName == "System.Object")
        select string.Format("[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof ({0}), Description = EnumerableVisualizer.Description)]",
          t.Name.Replace("`1","<>").Replace("`2", "<,>"));
      return visualizerRegistrations.OrderBy(n => n);
    }

    public static string CreateVisualizerRegistrations(params Assembly[] assemblies)
    {
      var stringBuilder = new StringBuilder();
      foreach (var assembly in assemblies)
      {
        stringBuilder.Append("// " + assembly.FullName);
        stringBuilder.AppendLine();
        var visualizerRegistrations = CreatePublicVisualizerRegistrations(assembly).Union(CreateOtherPrivateVisualizerRegistrations(assembly)).Union(CreateVisualizerRegistrationsNestedNotGenericSealed(assembly));
        foreach (var visualizerRegistration in visualizerRegistrations)
        {
          stringBuilder.Append(visualizerRegistration);
          stringBuilder.AppendLine();
        }
      }
      return stringBuilder.ToString();
    }

    /// <summary>
    ///   Shows the user interface for the visualizer
    /// </summary>
    /// <param name="windowService">
    ///   An object of type
    ///   <see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IDialogVisualizerService" />, which provides methods your
    ///   visualizer can use to display Windows forms, controls, and dialogs.
    /// </param>
    /// <param name="objectProvider">
    ///   An object of type
    ///   <see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.IVisualizerObjectProvider" />. This object provides
    ///   communication from the debugger side of the visualizer to the object source (
    ///   <see cref="T:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource" />) on the debuggee side.
    /// </param>
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
        _modalService.ShowDialog(FrmDataEditor.CreateDataViewForm(enumerable));
    }
  }

  public class EnumerableVisualizerObjectSource : VisualizerObjectSource
  {
    static EnumerableVisualizerObjectSource()
    {
      AddConvertersAndDescriptors.AddIfNotAllready();
    }

    #region Overrides of VisualizerObjectSource

    /// <summary>
    ///   Gets data from the specified object and serializes it into the outgoing data stream
    ///   This class implements the debugee side of the visualizer. It is responsible for running the commands against the   server.
    /// </summary>
    /// <remarks>
    ///   Uses the Bi­na­ry­For­mat­ter se­ri­al­iz­er.
    ///   Strategy is:
    ///   if the items are serializable then
    ///   __if the enumerable is also serializable then
    ///   ____serialize the enumerable
    ///   else
    ///   __create an ObjectListView to contain the items and serialize that.
    ///   Full back is to:
    ///   Copy the enumerable to a DataTable and serialize that.
    ///   If that fails:
    ///   Create a DataTableSurrogate from the DataTable and serialize that
    /// </remarks>
    /// <param name="target">Object being visualized.</param>
    /// <param name="outgoingData">Outgoing data stream.</param>
    /// <see cref="http://msdn.microsoft.com/en-us/library/bb669096.aspx" />
    /// <see cref="http://support.microsoft.com/default.aspx?scid=kb;en-us;829740" />
    /// <see cref="http://msdn.microsoft.com/en-us/library/microsoft.synchronization.data.datatablesurrogate(SQL.105).aspx" />
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
              SerializeWithSurrogate(outgoingData, enumerable.CopyToDataTable());
            }
          }
        }
        else
          Serialize(outgoingData, enumerable.CopyToDataTable());
      }
      else
      {
        var table = target as DataTable;
        if (table != null)
          Serialize(outgoingData, table);
      }
    }

    #endregion

    /// <summary>
    ///   Gets data from the specified DataTable and into DataTableSurrogate and Serializes that.
    /// </summary>
    /// <param name="outgoingData">The outgoing data.</param>
    /// <param name="target">The target.</param>
    /// <remarks>
    ///   This is a fallback if serializing a DataTable throws a SerializationException
    /// </remarks>
    private static void SerializeWithSurrogate(Stream outgoingData, DataTable target)
    {
      outgoingData.Position = 0;
      var dataTableSurrogate = new DataTableSurrogate(target);
      Serialize(outgoingData, dataTableSurrogate);
    }

    /// <summary>
    ///   Binary Serialize DataTable.
    ///   On SerializationException try DataTableSurrogate
    /// </summary>
    /// <param name="outgoingData"></param>
    /// <param name="target"></param>
    private static void Serialize(Stream outgoingData, DataTable target)
    {
      outgoingData.Position = 0;
      if (target.DataSet == null)
        target.RemotingFormat = SerializationFormat.Binary;
      else
        target.DataSet.RemotingFormat = SerializationFormat.Binary;
      try
      {
        VisualizerObjectSource.Serialize(outgoingData, target);
      }
      catch (SerializationException)
      {
        SerializeWithSurrogate(outgoingData, target);
      }
    }

    /// <summary>
    ///   Serializes an enumerable into a stream - if there is an SerializationException then the enumerable
    ///   is copied to a data table and that is serialized instead.
    /// </summary>
    /// <param name="outgoingData">The outgoing data.</param>
    /// <param name="enumerable">The enumerable.</param>
    private static void Serialize(Stream outgoingData, IEnumerable enumerable)
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