﻿//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
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
using System.Diagnostics;
using System.Windows.Forms;
using AW.DebugVisualizers;
using JesseJohnston;
using Microsoft.VisualBasic;

// type - visualizer binding

//Serializable

//-Collections classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ArrayList), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BitArray), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CollectionBase), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Hashtable), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Queue), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedList), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Stack), Description = "Enumerable Visualizer")]

//-Collections.Specialized classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (HybridDictionary), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListDictionary), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (NameObjectCollectionBase), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (OrderedDictionary), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (StringCollection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (StringDictionary), Description = "Enumerable Visualizer")]

//-Collections.Generic classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Dictionary<,>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (LinkedList<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (List<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Queue), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedDictionary<,>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedList<,>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Stack<>), Description = "Enumerable Visualizer")]

//-Other classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.Table`1, System.Data.Linq", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView<>), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataView), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTable), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConfigurationElementCollection), Description = "Enumerable Visualizer")]


//-LLBL
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2<>), Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase<>), Description = "Enumerable Visualizer")]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityCollectionBase2`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = "Enumerable Visualizer")]

//Not serializable

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BindingSource), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.EnumerableQuery, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ProviderCollection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (PropertyDescriptorCollection), Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (InternalDataCollectionBase), Description = "Enumerable Visualizer")]

//LLBL
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase<>), Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery<>), Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase<>), Description = "Enumerable Visualizer")]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = "Enumerable Visualizer")]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSource`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = "Enumerable Visualizer")]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = "Enumerable Visualizer")]

// Nested classes - seem to work in VS2010 but not in earlier versions

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable.Iterator`1, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+Iterator`1, System.Core", Description = "Enumerable Visualizer")]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof(NameObjectCollectionBase.KeysCollection), Description = "Enumerable Visualizer")]