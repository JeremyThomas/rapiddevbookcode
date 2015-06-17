//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 
//http://social.msdn.microsoft.com/Forums/en-US/vsdebug/thread/93d53290-998e-48ad-98bc-9fcd9e642f57 VS cannot locate a custom debug visualizer for a nested class

using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.Linq;
using System.Data.SqlClient;
using System.Diagnostics;
using System.DirectoryServices;
using System.Dynamic;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security;
using System.Security.AccessControl;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Windows.Data;
using System.Windows.Forms;
using System.Xml;
using AW.DebugVisualizers;
using AW.Helper;
using JesseJohnston;
using Microsoft.VisualBasic;
using PropertyCollection = System.DirectoryServices.PropertyCollection;

// type - Visualizer binding

//http://joshsmithonwpf.wordpress.com/2008/01/20/the-rock-star-hack-of-2008/
//http://code.google.com/p/linqpadvisualizer/

// mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ApplicationTrustCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Array), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ArrayList), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BaseChannelObjectWithProperties), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BitArray), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Collection<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CollectionBase), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConcurrentDictionary<,>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConcurrentQueue<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConcurrentStack<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Dictionary<,>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DictionaryBase), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Evidence), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(GenericAcl), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Hashtable), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(IdentityReferenceCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(KeyContainerPermissionAccessEntryCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(List<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(PermissionSet), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Queue), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ReadOnlyCollection<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ReadOnlyCollectionBase), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ReadOnlyDictionary<,>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ResourceReader), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ResourceSet), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedList), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Stack), Description = EnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ArrayList+FixedSizeList, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ArrayList+ReadOnlyList, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ArrayList+SyncIList, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.OrderablePartitioner`1+EnumerableDropIndices, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForArray`1+InternalPartitionEnumerable, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable`1+InternalPartitionEnumerable, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForIList`1+InternalPartitionEnumerable, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.EmptyReadOnlyDictionaryInternal, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.Dictionary`2+KeyCollection, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.Dictionary`2+ValueCollection, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.List`1+SynchronizedList, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Hashtable+KeyCollection, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Hashtable+ValueCollection, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal+NodeKeyValueCollection, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ObjectModel.ReadOnlyDictionary`2+KeyCollection, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ObjectModel.ReadOnlyDictionary`2+ValueCollection, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.SortedList+KeyList, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.SortedList+ValueList, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.IO.Iterator`1, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Resources.ResourceFallbackManager, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ConstantSplittableMap`2, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.DictionaryKeyCollection`2, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.DictionaryValueCollection`2, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ICustomPropertyProviderProxy`2, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ReadOnlyDictionaryKeyCollection`2, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ReadOnlyDictionaryValueCollection`2, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.Remoting.Channels.AggregateDictionary, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.Remoting.Messaging.MessageDictionary, mscorlib", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.SingleProducerSingleConsumerQueue`1, mscorlib", Description = EnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__7, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__7, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__a, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__0, mscorlib", Description = EnumerableVisualizer.DescriptionV45)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__2, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(WeakReference), Description = EnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedSet<>), Description = EnumerableVisualizer.Description)]

//-Collections.Specialized classes

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(HybridDictionary), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListDictionary), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(NameObjectCollectionBase), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(OrderedDictionary), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StringCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StringDictionary), Description = EnumerableVisualizer.Description)]


//-Winforms

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BaseCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataGridViewComboBoxCell.ObjectCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListBox.ObjectCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ComboBox.ObjectCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Control.ControlCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TreeNodeCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ToolStripItemCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.ListViewItemCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.CheckedListViewItemCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.SelectedIndexCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.SelectedListViewItemCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.ColumnHeaderCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.CheckedIndexCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListViewItem.ListViewSubItemCollection), Description = EnumerableVisualizer.Description)]

//-WPF

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CompositeCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CollectionView), Description = EnumerableVisualizer.Description)]

//-Other classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Table<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataView), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTable), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTableCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SqlErrorCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SqlConnectionStringBuilder), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SqlParameterCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Oracle.DataAccess.Client.OracleParameterCollection, Oracle.DataAccess.Client", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (XmlNodeList), Description = EnumerableVisualizer.Description)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Xml.Linq.XContainer), Description = EnumerableVisualizer.Description)]


[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Common.ReadOnlyCollection`1, System.Data", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EnumerableRowCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConfigurationElementCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTableSurrogate), Description = EnumerableVisualizer.Description)]

//-LLBL

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = EnumerableVisualizer.Description)]

//Not serializable

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BindingSource), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ExpandoObject), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (HashSet<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ReadOnlyCollectionBuilder<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EnumerableQuery<>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Lookup<,>), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ParallelQuery), Description = EnumerableVisualizer.Description)] //Does System.Linq.ParallelQuery<> and OrderedParallelQuery

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ProviderCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SettingsPropertyCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SettingsPropertyValueCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (PropertyDescriptorCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (AttributeCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (InternalDataCollectionBase), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TraceListenerCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SearchResultCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (PropertyCollection), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DirectoryEntries), Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationElementCollection, Microsoft.Web.Administration", Description = EnumerableVisualizer.Description)]

//LLBL

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = EnumerableVisualizer.Description)]
//Fails DebuggerVisualizerAttributeTest [assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = EnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = EnumerableVisualizer.Description)]

// Nested classes - seem to work in VS2010 but not in earlier versions
// Found by doing 
//typeof(System.Linq.Enumerable)
//.Assembly
//.GetTypes().Where(t => 
//t.GetInterface("IEnumerable")!=null && !t.IsInterface 
//&& !t.IsPublic && t.IsNested && t.IsGenericType &&t.IsSealed //&&t.GetGenericArguments().Length==2
//&& t.BaseType.FullName=="System.Object").OrderBy(t=>t.FullName)
//.Select(t=>string.Format("[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = \"{0}\", Description = EnumerableVisualizer.DescriptionV46)]", t.FullName)).OrderBy(n => n)//&&t.IsPublic

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Select>d__0`2, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Where>d__6`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__b1`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__71`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__a5`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__81`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__99`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__6a`4, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__92`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__61`4, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__aa`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__bc`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__a0`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__7`2, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__14`2, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__1d`2, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__27`3, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__31`3, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__4d`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__52`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__59`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__3a`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__40`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__46`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__88`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__0`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ZipIterator>d__7a`3, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2+<ApplyResultSelector>d__3`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.CancellableEnumerable+<Wrap>d__0`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapEnumerable>d__0`1, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapQueryEnumerator>d__6`2, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.PartitionerQueryOperator`1+<AsSequentialQuery>d__0, System.Core", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ZipQueryOperator`3+<AsSequentialQuery>d__0, System.Core", Description = EnumerableVisualizer.DescriptionV45)]

//.net4.6
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Select>d__1`2, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Where>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__1`4, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__1`4, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__1`2, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__1`2, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__2`2, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__3`3, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__4`3, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__2`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__2`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ZipIterator>d__1`3, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2+<ApplyResultSelector>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.CancellableEnumerable+<Wrap>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapEnumerable>d__1`1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapQueryEnumerator>d__1`2, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.PartitionerQueryOperator`1+<AsSequentialQuery>d__1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ZipQueryOperator`3+<AsSequentialQuery>d__1, System.Core", Description = EnumerableVisualizer.DescriptionV46)]

//System.Core Private, Not sealed

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+KeyCollection, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+ValueCollection, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+Iterator`1, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Expressions.BlockExpressionList, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Expressions.ListArgumentProvider, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`3, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`4, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2+Grouping, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable`1, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.EnumerableWrapperWeakToStrong, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.GroupByGrouping`2, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ListChunk`1, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.Lookup`2, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.MergeExecutor`1, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.OrderedGroupByGrouping`3, System.Core", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.QueryResults`1, System.Core", Description = EnumerableVisualizer.Description)]

//mscorlib IsNested, !IsGenericType, IsSealed

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__2, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__1, mscorlib", Description = EnumerableVisualizer.DescriptionV46)]

//misc

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (NameObjectCollectionBase.KeysCollection), Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+ValuesCollection, System.Xml", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+NamesCollection, System.Xml", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataSource+DataProviderCollection, Microsoft.Data.ConnectionUI.Dialog", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = EnumerableVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11, System.Xml.Linq", Description = EnumerableVisualizer.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__1, System.Xml.Linq", Description = EnumerableVisualizer.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__2, System.Web.Mvc", Description = EnumerableVisualizer.Description)]