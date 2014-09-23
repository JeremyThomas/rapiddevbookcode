//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 
//http://social.msdn.microsoft.com/Forums/en-US/vsdebug/thread/93d53290-998e-48ad-98bc-9fcd9e642f57 VS cannot locate a custom debug visualizer for a nested class

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
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml;
using Microsoft.VisualBasic;

// type - Visualizer binding

//http://joshsmithonwpf.wordpress.com/2008/01/20/the-rock-star-hack-of-2008/
//http://code.google.com/p/linqpadvisualizer/
using ObjectSourceVisualizer;

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(System.WeakReference), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//Serializable

//-Collections classes

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ArrayList), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BitArray), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CollectionBase), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ReadOnlyCollectionBase), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Hashtable), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Queue), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedList), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Stack), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal, mscorlib", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal.NodeKeyValueCollection, mscorlib", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//-Collections.Specialized classes

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(HybridDictionary), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListDictionary), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(NameObjectCollectionBase), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(OrderedDictionary), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(StringCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(StringDictionary), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//-Collections.Generic classes

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Dictionary<,>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(LinkedList<>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(List<>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Queue<>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedDictionary<,>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedList<,>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Stack<>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Dictionary<,>.KeyCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Dictionary<,>.ValueCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedSet<>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(HashSet<>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//-Winforms
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BaseCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataGridViewComboBoxCell.ObjectCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListBox.ObjectCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ComboBox.ObjectCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Control.ControlCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TreeNodeCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ToolStripItemCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.ListViewItemCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.CheckedListViewItemCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.SelectedIndexCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.SelectedListViewItemCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.ColumnHeaderCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.CheckedIndexCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListViewItem.ListViewSubItemCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//-WPF
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CompositeCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CollectionView), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//-Other classes

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Collection<>), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Collection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Data.Linq.Table`1, System.Data.Linq", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataView), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataTable), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataTableCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SqlErrorCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SqlConnectionStringBuilder), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SqlParameterCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "Oracle.DataAccess.Client.OracleParameterCollection, Oracle.DataAccess.Client", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(XmlNodeList), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(System.Xml.Linq.XContainer), Description = EnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11, System.Xml.Linq", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11`1, System.Xml.Linq", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Data.Common.ReadOnlyCollection`1, System.Data", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(System.Data.EnumerableRowCollection), Description = EnumerableVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Data.EnumerableRowCollection, System.Data.DataSetExtensions", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConfigurationElementCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//-LLBL

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//Not serializable

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BindingSource), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ProviderCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SettingsPropertyCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SettingsPropertyValueCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(PropertyDescriptorCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(AttributeCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(InternalDataCollectionBase), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TraceListenerCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+ValuesCollection, System.Xml", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+NamesCollection, System.Xml", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataSource+DataProviderCollection, Microsoft.Data.ConnectionUI.Dialog", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationElementCollection, Microsoft.Web.Administration", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

//LLBL
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

// Nested classes - seem to work in VS2010 but not in earlier versions

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__b1`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__71`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__a5`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__81`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__99`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__6a`4, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__92`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__61`4, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__aa`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RangeIterator>d__b8`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__bc`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__a0`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__7`2, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__14`2, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__1d`2, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__27`3, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__31`3, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__4d`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__52`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__59`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__40`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__46`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__88`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__0`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__3a`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+Iterator`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereArrayIterator`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereEnumerableIterator`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereListIterator`1, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereSelectArrayIterator`2, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereSelectListIterator`2, System.Core", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(NameObjectCollectionBase.KeysCollection), Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer.ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__2, System.Web.Mvc", Description = ObjectSourceVisualizer.ObjectSourceVisualizer.Description)]