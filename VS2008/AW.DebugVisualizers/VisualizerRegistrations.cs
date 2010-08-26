//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;
using AW.DebugVisualizers;
using JesseJohnston;
using Microsoft.VisualBasic;

// type - visualizer binding

//Serializable

//-Collections classes

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ArrayList), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BitArray), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CollectionBase), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Hashtable), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Queue), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedList), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Stack), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal.NodeKeyValueCollection, mscorlib", Description = EnumerableVisualizer.Description)]

//-Collections.Specialized classes

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(HybridDictionary), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListDictionary), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(NameObjectCollectionBase), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(OrderedDictionary), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StringCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StringDictionary), Description = EnumerableVisualizer.Description)]

//-Collections.Generic classes

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Dictionary<,>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(LinkedList<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(List<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Queue<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedDictionary<,>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedList<,>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Stack<>), Description = EnumerableVisualizer.Description)]

//-Other classes

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Collection<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Collection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataGridViewComboBoxCell.ObjectCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListBox.ObjectCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ComboBox.ObjectCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.Table`1, System.Data.Linq", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ObjectListView), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ObjectListView<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataView), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataTable), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataTableCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SqlErrorCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SqlConnectionStringBuilder), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XmlNodeList), Description = EnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Xml.Linq.XContainer), Description = EnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11, System.Xml.Linq", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11`1, System.Xml.Linq", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Common.ReadOnlyCollection`1, System.Data", Description = EnumerableVisualizer.Description)]

//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Data.EnumerableRowCollection), Description = EnumerableVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.EnumerableRowCollection, System.Data.DataSetExtensions", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConfigurationElementCollection), Description = EnumerableVisualizer.Description)]

//-LLBL
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2<>), Description = EnumerableVisualizer.Name)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase<>), Description = EnumerableVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]

//Not serializable

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BindingSource), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ProviderCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(PropertyDescriptorCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(InternalDataCollectionBase), Description = EnumerableVisualizer.Description)]

//LLBL
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase<>), Description = EnumerableVisualizer.Name)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery<>), Description = EnumerableVisualizer.Name)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase<>), Description = EnumerableVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSource`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFields, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFields2, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]

