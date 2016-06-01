//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 
//http://social.msdn.microsoft.com/Forums/en-US/vsdebug/thread/93d53290-998e-48ad-98bc-9fcd9e642f57 VS cannot locate a custom debug visualizer for a nested class

using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Configuration.Provider;
using System.Data;
using System.Data.Common;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Security;
using System.Security.AccessControl;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Policy;
using System.Security.Principal;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using ObjectAsSourceCodeVisualizer;

// type - Visualizer binding

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(WeakReference), Description = ObjectSourceVisualizer.Description)]

// mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(WeakReference), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ApplicationTrustCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Array), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ArrayList), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BaseChannelObjectWithProperties), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BitArray), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Collection<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CollectionBase), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConcurrentDictionary<,>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConcurrentQueue<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConcurrentStack<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Dictionary<,>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DictionaryBase), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Evidence), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(GenericAcl), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Hashtable), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(IdentityReferenceCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(KeyContainerPermissionAccessEntryCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(List<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(PermissionSet), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Queue), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ReadOnlyCollection<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ReadOnlyCollectionBase), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ReadOnlyDictionary<,>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ResourceReader), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ResourceSet), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedList), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Stack), Description = ObjectSourceVisualizer.Description)]

// System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(AsnEncodedDataCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(AttributeCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BlockingCollection<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CaptureCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CodeNamespaceImportCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConcurrentBag<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CookieCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CredentialCache), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DesignerCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(EventDescriptorCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(EventLogEntryCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(GatewayIPAddressInformationCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(GroupCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(HttpListenerPrefixCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(HybridDictionary), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(IPAddressCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(IPAddressInformationCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(LinkedList<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListDictionary), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListSortDescriptionCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(MatchCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(MulticastIPAddressInformationCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(NameObjectCollectionBase), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(OidCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(OrderedDictionary), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(PropertyDescriptorCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Queue<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SettingsPropertyCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SettingsPropertyValueCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedDictionary<,>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedList<,>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedSet<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Stack<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(StringCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(StringDictionary), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedDictionary<,>.KeyCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SortedDictionary<,>.ValueCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(NameObjectCollectionBase.KeysCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DesignerOptionService.DesignerOptionCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TypeConverter.StandardValuesCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TempFileCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TraceListenerCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(UnicastIPAddressInformationCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(X509ChainElementCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(X509ExtensionCollection), Description = ObjectSourceVisualizer.Description)]

// System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(EnumerableQuery<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ExpandoObject), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(HashSet<>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Lookup<,>), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ParallelQuery), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ReadOnlyCollectionBuilder<>), Description = ObjectSourceVisualizer.Description)]
// System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ArrangedElementCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(AutoCompleteStringCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BaseCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BindingContext), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(BindingSource), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataGridViewRowCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(GridItemCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(HtmlElementCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(HtmlWindowCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListViewGroupCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(NumericUpDownAccelerationCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ResXResourceReader), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CheckedListBox.CheckedIndexCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(CheckedListBox.CheckedItemCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ComboBox.ObjectCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataGridViewComboBoxCell.ObjectCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ImageList.ImageCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(LinkLabel.LinkCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListBox.IntegerCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListBox.ObjectCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListBox.SelectedIndexCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListBox.SelectedObjectCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.CheckedIndexCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.CheckedListViewItemCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.ColumnHeaderCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.ListViewItemCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.SelectedIndexCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListView.SelectedListViewItemCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ListViewItem.ListViewSubItemCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(Menu.MenuItemCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(PropertyGrid.PropertyTabCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(StatusBar.StatusBarPanelCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TabControl.TabPageCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ToolBar.ToolBarButtonCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TableLayoutStyleCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(TreeNodeCollection), Description = ObjectSourceVisualizer.Description)]

// PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
// System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataColumnMappingCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataTableMappingCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataView), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataViewManager), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DataViewSettingCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DbConnectionStringBuilder), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DbDataReader), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(DbParameterCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(InternalDataCollectionBase), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(OdbcErrorCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(OleDbErrorCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SqlErrorCollection), Description = ObjectSourceVisualizer.Description)]

// System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(XmlNamedNodeMap), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(XmlNamespaceManager), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(XmlNode), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(XmlNodeList), Description = ObjectSourceVisualizer.Description)]
#pragma warning disable 618
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(XmlSchemaCollection), Description = ObjectSourceVisualizer.Description)]
#pragma warning restore 618
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(XPathNodeIterator), Description = ObjectSourceVisualizer.Description)]

// System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConfigurationElementCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConfigurationLockCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ConfigurationPropertyCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(ProviderCollection), Description = ObjectSourceVisualizer.Description)]

// SD.LLBLGen.Pro.ORMSupportClasses, Version=4.2.0.0, Culture=neutral, PublicKeyToken=ca73b74ba4e3ff27
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.Grouping`2, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.GroupByCollection, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedListBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedListBase2`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.UniqueList`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.QuerySpec.Grouping`2, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependentRelatedEntityCoreInstances>d__6, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependingRelatedEntityCoreInstances>d__0, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetMemberEntityCollectionCoreInstances>d__c, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependentRelatedEntityCoreInstances>d__8, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependingRelatedEntityCoreInstances>d__2, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetMemberEntityCollectionCoreInstances>d__e, SD.LLBLGen.Pro.ORMSupportClasses", Description = ObjectSourceVisualizer.Description)]

//-LLBL 3
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = ObjectSourceVisualizer.Description)]

//-Other classes
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SqlErrorCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(SqlParameterCollection), Description = ObjectSourceVisualizer.Description)]
[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), TargetTypeName = "Oracle.DataAccess.Client.OracleParameterCollection, Oracle.DataAccess.Client", Description = ObjectSourceVisualizer.Description)]



