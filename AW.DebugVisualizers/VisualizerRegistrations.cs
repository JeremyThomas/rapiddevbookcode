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
using System.Data.Linq;
using System.Data.Odbc;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.DirectoryServices;
using System.Dynamic;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Reflection;
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
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Documents.DocumentStructures;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Windows.Markup;
using System.Windows.Markup.Localizer;
using System.Windows.Media.Animation;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using AW.DebugVisualizers;
using AW.Helper;
using JesseJohnston;
using Microsoft.VisualBasic;
using PropertyCollection = System.DirectoryServices.PropertyCollection;

// type - Visualizer binding

//http://joshsmithonwpf.wordpress.com/2008/01/20/the-rock-star-hack-of-2008/
//http://code.google.com/p/linqpadvisualizer/

// mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (WeakReference), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ApplicationTrustCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Array), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ArrayList), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BaseChannelObjectWithProperties), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BitArray), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CollectionBase), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConcurrentDictionary<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConcurrentQueue<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConcurrentStack<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Dictionary<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DictionaryBase), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Evidence), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (GenericAcl), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Hashtable), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (IdentityReferenceCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (KeyContainerPermissionAccessEntryCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (List<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (PermissionSet), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Queue), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ReadOnlyCollection<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ReadOnlyCollectionBase), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ReadOnlyDictionary<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ResourceReader), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ResourceSet), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedList), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Stack), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ArrayList+FixedSizeList, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ArrayList+ReadOnlyList, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ArrayList+SyncIList, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.OrderablePartitioner`1+EnumerableDropIndices, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForArray`1+InternalPartitionEnumerable, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForIEnumerable`1+InternalPartitionEnumerable, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+DynamicPartitionerForIList`1+InternalPartitionEnumerable, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.EmptyReadOnlyDictionaryInternal, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.Dictionary`2+KeyCollection, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.Dictionary`2+ValueCollection, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.List`1+SynchronizedList, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Hashtable+KeyCollection, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Hashtable+ValueCollection, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ListDictionaryInternal+NodeKeyValueCollection, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ObjectModel.ReadOnlyDictionary`2+KeyCollection, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.ObjectModel.ReadOnlyDictionary`2+ValueCollection, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.SortedList+KeyList, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.SortedList+ValueList, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.IO.Iterator`1, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Resources.ResourceFallbackManager, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ConstantSplittableMap`2, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.DictionaryKeyCollection`2, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.DictionaryValueCollection`2, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ICustomPropertyProviderProxy`2, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ReadOnlyDictionaryKeyCollection`2, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.InteropServices.WindowsRuntime.ReadOnlyDictionaryValueCollection`2, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.Remoting.Channels.AggregateDictionary, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Runtime.Remoting.Messaging.MessageDictionary, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.SingleProducerSingleConsumerQueue`1, mscorlib", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__7, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__7, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__a, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__0, mscorlib", Description = VisualizerRegistration.DescriptionV45)]
//.net4.6

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__2, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__1, mscorlib", Description = VisualizerRegistration.DescriptionV46)]

// System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(AsnEncodedDataCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(AttributeCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BlockingCollection<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CaptureCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CodeNamespaceImportCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConcurrentBag<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CookieCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CredentialCache), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DesignerCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(EventDescriptorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(EventLogEntryCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(GatewayIPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(GroupCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(HttpListenerPrefixCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(HybridDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(IPAddressCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(IPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(LinkedList<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListSortDescriptionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(MatchCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(MulticastIPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(NameObjectCollectionBase), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(OidCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(OrderedDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(PropertyDescriptorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Queue<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SettingsPropertyCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SettingsPropertyValueCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedDictionary<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedList<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SortedSet<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Stack<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StringCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StringDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Collections.Generic.SortedDictionary<,>.KeyCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Collections.Generic.SortedDictionary<,>.ValueCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Collections.Specialized.NameObjectCollectionBase.KeysCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.ComponentModel.Design.DesignerOptionService.DesignerOptionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.ComponentModel.TypeConverter.StandardValuesCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TempFileCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TraceListenerCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(UnicastIPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(X509ChainElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(X509ExtensionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.SortedList`2+KeyList, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.SortedList`2+ValueList, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.ListDictionary+NodeKeyValueCollection, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.OrderedDictionary+OrderedDictionaryKeyValueCollection, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.StringDictionary+GenericAdapter, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.StringDictionary+GenericAdapter+ICollectionToGenericCollectionAdapter, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Net.ProxyChain, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Net.SpnDictionary+ValueCollection, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.BlockingCollection`1+<GetConsumingEnumerable>d__0, System", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.SortedSet`1+<Reverse>d__12, System", Description = VisualizerRegistration.DescriptionV45)]

// System.Core, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(EnumerableQuery<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ExpandoObject), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(HashSet<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(Lookup<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ParallelQuery), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ReadOnlyCollectionBuilder<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+KeyCollection, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+ValueCollection, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+Iterator`1, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Expressions.BlockExpressionList, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Expressions.ListArgumentProvider, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Expressions.Set`1, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`3, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.GroupedEnumerable`4, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2+Grouping, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.OrderedEnumerable`1, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.EnumerableWrapperWeakToStrong, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.GroupByGrouping`2, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ListChunk`1, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.Lookup`2, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.MergeExecutor`1, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.OrderedGroupByGrouping`3, System.Core", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.QueryResults`1, System.Core", Description = VisualizerRegistration.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+MetaExpando+<GetDynamicMemberNames>d__1b, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Select>d__0`2, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Where>d__6`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__b1`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__71`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__a5`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__81`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__99`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__6a`4, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__92`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__61`4, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__aa`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RangeIterator>d__b8, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__bc`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__a0`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__7`2, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__14`2, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__1d`2, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__27`3, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__31`3, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__4d`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__52`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__59`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__3a`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__40`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__46`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__88`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__0`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ZipIterator>d__7a`3, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2+<ApplyResultSelector>d__3`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.CancellableEnumerable+<Wrap>d__0`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapEnumerable>d__0`1, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapQueryEnumerator>d__6`2, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.PartitionerQueryOperator`1+<AsSequentialQuery>d__0, System.Core", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ZipQueryOperator`3+<AsSequentialQuery>d__0, System.Core", Description = VisualizerRegistration.DescriptionV45)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Select>d__1`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Where>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__1`4, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__1`4, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__1`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__1`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__2`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__3`3, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__4`3, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__2`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__2`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ZipIterator>d__1`3, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2+<ApplyResultSelector>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.CancellableEnumerable+<Wrap>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapEnumerable>d__1`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapQueryEnumerator>d__1`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.PartitionerQueryOperator`1+<AsSequentialQuery>d__1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ZipQueryOperator`3+<AsSequentialQuery>d__1, System.Core", Description = VisualizerRegistration.DescriptionV46)]

// System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ArrangedElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(AutoCompleteStringCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BaseCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BindingContext), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BindingSource), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataGridViewRowCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(GridItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(HtmlElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(HtmlWindowCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListViewGroupCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(NumericUpDownAccelerationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ResXResourceReader), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.CheckedListBox.CheckedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.CheckedListBox.CheckedItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ComboBox.ObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.DataGridViewComboBoxCell.ObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ImageList.ImageCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.LinkLabel.LinkCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListBox.IntegerCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListBox.ObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListBox.SelectedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListBox.SelectedObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListView.CheckedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListView.CheckedListViewItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListView.ColumnHeaderCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListView.ListViewItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListView.SelectedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListView.SelectedListViewItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ListViewItem.ListViewSubItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.Menu.MenuItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.PropertyGrid.PropertyTabCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.StatusBar.StatusBarPanelCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.TabControl.TabPageCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(System.Windows.Forms.ToolBar.ToolBarButtonCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableLayoutStyleCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TreeNodeCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.ClientUtils+WeakRefCollection, System.Windows.Forms", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.DataGridViewCellLinkedList, System.Windows.Forms", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.DataGridViewIntLinkedList, System.Windows.Forms", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.PropertyGridInternal.MergePropertyDescriptor+MultiMergeCollection, System.Windows.Forms", Description = VisualizerRegistration.Description)]

// PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(BamlLocalizationDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CollectionView), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ColumnDefinitionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(CompositeCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DocumentReferenceCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(FigureStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListItemStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ListStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(PageContentCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ParagraphStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ResourceDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(RowDefinitionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SectionStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StoryFragment), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(StoryFragments), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableCellCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableCellStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableColumnCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableRowCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableRowGroupCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableRowGroupStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableRowStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TableStructure), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TextElementCollection<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ThicknessKeyFrameCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TriggerActionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(UIElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(WindowCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XmlnsDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Annotations.ObservableDictionary, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Controls.EmptyEnumerable, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Data.IndexedEnumerable, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Data.LiveShapingList, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Data.RBTree`1, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Documents.ContentElementCollection`2, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.ListOfObject, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.WeakDictionary`2, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.WeakDictionary`2+KeyCollection`2, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.WeakDictionary`2+ValueCollection`2, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.WeakHashSet`1, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.CustomDictionarySources, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.DataGridColumnHeaderCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.MultipleCopiesCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.Selector+InternalSelectedItemsStorage, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.VirtualizedCellInfoCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.LogicalTreeHelper+EnumeratorWrapper, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+PartiallyOrderedList`2, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Navigation.JournalEntryStack, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Navigation.LimitedJournalEntryStackEnumerable, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Navigation.UnifiedJournalEntryStackEnumerable, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.ResourceDictionary+ResourceValuesCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Ink.ClipboardProcessor+<get_PreferredFormats>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Ink.InkCanvasSelection+<get_SelectedElementsBoundsEnumerator>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarButtons>d__7, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarDayButtons>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.SelectedDatesCollection+<GetDaysInRange>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.SpellingError+<get_Suggestions>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.FixedTextBuilder+FlowModelBuilder+LogicalHyperlinkContainer, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementDictionaryItemsPseudoProperty+<get_Items>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementItemsPseudoProperty+<get_Items>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementMarkupObject+<GetProperties>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementPropertyBase+<get_Items>d__2, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierMarkupObject+<GetProperties>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierProperty+<get_Items>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryContent+<get_Items>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryMarkupObject+<GetProperties>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateAllMappings>d__f, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateLocalMappings>d__9, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.XmlnsDictionary+<GetNamespacePrefixes>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]

// System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataColumnMappingCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataTableMappingCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataView), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataViewManager), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataViewSettingCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DbConnectionStringBuilder), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DbDataReader), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DbParameterCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(InternalDataCollectionBase), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(OdbcErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(OleDbErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SqlErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Common.ReadOnlyCollection`1, System.Data", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.RBTree`1, System.Data", Description = VisualizerRegistration.Description)]

// System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XmlNamedNodeMap), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XmlNamespaceManager), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XmlNode), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XmlNodeList), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XmlSchemaCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(XPathNodeIterator), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+NamesCollection, System.Xml", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+ValuesCollection, System.Xml", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.SchemaInfo+<System.Xml.IDtdInfo.GetAttributeLists>d__0, System.Xml", Description = VisualizerRegistration.DescriptionV45)]

// System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Xml.Linq.ComponentModel.XDeferredAxis`1, System.Xml.Linq", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAncestors>d__f`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAttributes>d__8, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendantNodes>d__16`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendants>d__1f`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetElements>d__29`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<Nodes>d__0`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendantNodes>d__4, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendants>d__a, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<Nodes>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XElement+<GetAttributes>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetAncestors>d__8, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsAfterSelf>d__c, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsBeforeSelf>d__11, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesAfterSelf>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesBeforeSelf>d__4, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<Annotations>d__6`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<AnnotationsIterator>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.XPath.XPathEvaluator+<EvaluateIterator>d__0`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]

// System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConfigurationElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConfigurationLockCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ConfigurationPropertyCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ProviderCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+ConfigurationElementsCollection, System.Configuration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+EmptyCollection, System.Configuration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+InvalidValuesCollection, System.Configuration", Description = VisualizerRegistration.Description)]

// System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DirectoryEntries), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(PropertyCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SchemaNameCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SearchResultCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.DirectoryServices.PropertyCollection+ValuesCollection, System.DirectoryServices", Description = VisualizerRegistration.Description)]

//-Other classes

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Collection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Table<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ObjectListView<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTable), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SqlErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SqlParameterCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Oracle.DataAccess.Client.OracleParameterCollection, Oracle.DataAccess.Client", Description = VisualizerRegistration.Description)]


[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EnumerableRowCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(TypedTableBase<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTableSurrogate), Description = VisualizerRegistration.Description)]

//-LLBL

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]

//Not serializable

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationElementCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]

//LLBL

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
//Fails DebuggerVisualizerAttributeTest [assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = EnumerableVisualizer.Description)]

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]

//misc

[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataSource+DataProviderCollection, Microsoft.Data.ConnectionUI.Dialog", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__2, System.Web.Mvc", Description = VisualizerRegistration.Description)]

namespace AW.DebugVisualizers
{
  public static class VisualizerRegistration
  {
    /// <summary>
    ///   Enumerable Visualizer
    /// </summary>
    public const string Description = "Enumerable Visualizer";

    public const string DescriptionV46 = Description + " V4.6";
    public const string DescriptionV45 = Description + " V4.0";

    public static IEnumerable<string> CreateForPrivateNestedNotSerializableSealed(Assembly assembly)
    {
      var majorMinorVersion = MetaDataHelper.GetBclMajorMinorVersion().Replace(".", "");
      var visualizerRegistrations = from t in GetBaseEnumerableTypes(assembly)
        where
          !t.IsSerializable
          && t.IsNestedPrivate
          && t.IsSealed
        select String.Format("[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = \"{0}\", Description = VisualizerRegistration.DescriptionV{1})]", 
        MetaDataHelper.GetClassAssemblyName(t), majorMinorVersion);
      return visualizerRegistrations.OrderBy(n => n);
    }

    public static IEnumerable<string> CreateOtherPrivateVisualizerRegistrations(Assembly assembly)
    {
      var visualizerRegistrations = from t in GetBaseEnumerableTypes(assembly)
        where
          !t.IsVisible
          && (t.IsSerializable || !t.IsNestedPrivate || !t.IsSealed)
        select String.Format("[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = \"{0}\", Description = VisualizerRegistration.Description)]", 
        MetaDataHelper.GetClassAssemblyName(t));
      return visualizerRegistrations.OrderBy(n => n);
    }

    public static IEnumerable<Type> GetBaseEnumerableTypes(Assembly assembly)
    {
      var baseEnumerableTypes = from t in assembly.GetTypes()
        where
          t.Implements("IEnumerable") && !t.IsInterface
          && (t.BaseType == null || !t.BaseType.Implements("IEnumerable"))
        select t;
      return baseEnumerableTypes;
    }

    public static IEnumerable<string> CreatePublicVisualizerRegistrations(Assembly assembly)
    {
      var visualizerRegistrations = from t in GetBaseEnumerableTypes(assembly)
        where t.IsVisible
        select String.Format("[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof ({0}), Description = VisualizerRegistration.Description)]",
          (t.IsNested ? t.FullName : t.Name).Replace("`1", "<>").Replace("`2", "<,>").Replace("+", "."));
      return visualizerRegistrations.OrderBy(n => n);
    }

    public static string CreateVisualizerRegistrations(params Assembly[] assemblies)
    {
      var stringBuilder = new StringBuilder();
      foreach (var assembly in assemblies)
      {
        stringBuilder.Append("// " + assembly.FullName);
        stringBuilder.AppendLine();
        var visualizerRegistrations = CreatePublicVisualizerRegistrations(assembly).Union(CreateOtherPrivateVisualizerRegistrations(assembly)).Union(CreateForPrivateNestedNotSerializableSealed(assembly));
        foreach (var visualizerRegistration in visualizerRegistrations)
        {
          stringBuilder.Append(visualizerRegistration);
          stringBuilder.AppendLine();
        }
      }
      return stringBuilder.ToString();
    }
  }
}