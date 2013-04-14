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
using AW.DebugVisualizers;
using JesseJohnston;
using Microsoft.VisualBasic;

// type - Visualizer binding

//http://joshsmithonwpf.wordpress.com/2008/01/20/the-rock-star-hack-of-2008/
//http://code.google.com/p/linqpadvisualizer/
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(System.WeakReference), Description = EnumerableJSVisualizer.Description)]

//Serializable

//-Collections classes

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ArrayList), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(BitArray), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(CollectionBase), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ReadOnlyCollectionBase), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Hashtable), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Queue), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SortedList), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Stack), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal, mscorlib", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal.NodeKeyValueCollection, mscorlib", Description = EnumerableJSVisualizer.Description)]

//-Collections.Specialized classes

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(HybridDictionary), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListDictionary), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(NameObjectCollectionBase), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(OrderedDictionary), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(StringCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(StringDictionary), Description = EnumerableJSVisualizer.Description)]

//-Collections.Generic classes

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Dictionary<,>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(LinkedList<>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(List<>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Queue<>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SortedDictionary<,>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SortedList<,>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Stack<>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Dictionary<,>.KeyCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Dictionary<,>.ValueCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SortedSet<>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(HashSet<>), Description = EnumerableJSVisualizer.Description)]

//-Winforms
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(BaseCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(DataGridViewComboBoxCell.ObjectCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListBox.ObjectCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ComboBox.ObjectCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Control.ControlCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(TreeNodeCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ToolStripItemCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListView.ListViewItemCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListView.CheckedListViewItemCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListView.SelectedIndexCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListView.SelectedListViewItemCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListView.ColumnHeaderCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListView.CheckedIndexCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ListViewItem.ListViewSubItemCollection), Description = EnumerableJSVisualizer.Description)]

//-WPF
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(CompositeCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(CollectionView), Description = EnumerableJSVisualizer.Description)]

//-Other classes

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Collection<>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(Collection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Data.Linq.Table`1, System.Data.Linq", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ObjectListView), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ObjectListView<>), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(DataView), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(DataTable), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(DataTableCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SqlErrorCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SqlConnectionStringBuilder), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SqlParameterCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "Oracle.DataAccess.Client.OracleParameterCollection, Oracle.DataAccess.Client", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(XmlNodeList), Description = EnumerableJSVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(System.Xml.Linq.XContainer), Description = EnumerableJSVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11, System.Xml.Linq", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11`1, System.Xml.Linq", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Data.Common.ReadOnlyCollection`1, System.Data", Description = EnumerableJSVisualizer.Description)]

//[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(System.Data.EnumerableRowCollection), Description = EnumerableJSVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Data.EnumerableRowCollection, System.Data.DataSetExtensions", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ConfigurationElementCollection), Description = EnumerableJSVisualizer.Description)]

//-LLBL
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableJSVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableJSVisualizer.Description)]

//Not serializable

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(BindingSource), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(ProviderCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SettingsPropertyCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SettingsPropertyValueCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(PropertyDescriptorCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(AttributeCollection), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(InternalDataCollectionBase), Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(TraceListenerCollection), Description = EnumerableJSVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+ValuesCollection, System.Xml", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+NamesCollection, System.Xml", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataSource+DataProviderCollection, Microsoft.Data.ConnectionUI.Dialog", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = EnumerableJSVisualizer.Description)]

//LLBL
//[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase<>), Description = EnumerableJSVisualizer.Name)]
//[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery<>), Description = EnumerableJSVisualizer.Name)]
//[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase<>), Description = EnumerableJSVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableJSVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSource`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableJSVisualizer.Name)]

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFields, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFields2, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableJSVisualizer.Description)]

// Nested classes - seem to work in VS2010 but not in earlier versions

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__b1`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__71`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__a5`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__81`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__99`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__6a`4, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__92`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__61`4, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__aa`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RangeIterator>d__b8`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__bc`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__a0`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__7`2, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__14`2, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__1d`2, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__27`3, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__31`3, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__4d`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__52`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__59`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__40`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__46`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__88`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__0`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__3a`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+Iterator`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereArrayIterator`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereEnumerableIterator`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereListIterator`1, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereSelectArrayIterator`2, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereSelectEnumerableIterator`2, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+WhereSelectListIterator`2, System.Core", Description = EnumerableJSVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), Target = typeof(NameObjectCollectionBase.KeysCollection), Description = EnumerableJSVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableJSVisualizer), typeof(EnumerableJSVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__2, System.Web.Mvc", Description = EnumerableJSVisualizer.Description)]