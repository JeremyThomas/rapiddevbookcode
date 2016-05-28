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
using System.Diagnostics.CodeAnalysis;
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
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using AW.DebugVisualizers;
using AW.Helper;
using JesseJohnston;

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
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__6, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.Partitioner+<CreateRanges>d__9, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Diagnostics.Tracing.ActivityFilter+<GetFilterAsTuple>d__7, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<get_DeclaredNestedTypes>d__23, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Reflection.TypeInfo+<GetDeclaredMethods>d__9, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsIdentity+<get_Claims>d__51, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.ClaimsPrincipal+<get_Claims>d__37, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Claims.RoleClaimProvider+<get_Claims>d__5, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsIdentity+<get_Claims>d__95, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_DeviceClaims>d__13, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Security.Principal.WindowsPrincipal+<get_UserClaims>d__11, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.Tasks.ThreadPoolTaskScheduler+<FilterTasksFromWorkItems>d__7, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Threading.ThreadPool+<EnumerateQueuedWorkItems>d__21, mscorlib", Description = VisualizerRegistration.DescriptionV46)]
// System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (AsnEncodedDataCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (AttributeCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BlockingCollection<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CaptureCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CodeNamespaceImportCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConcurrentBag<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CookieCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CredentialCache), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DesignerCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EventDescriptorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (EventLogEntryCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (GatewayIPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (GroupCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (HttpListenerPrefixCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (HybridDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (IPAddressCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (IPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (LinkedList<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListSortDescriptionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (MatchCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (MulticastIPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (NameObjectCollectionBase), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (OidCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (OrderedDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (PropertyDescriptorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Queue<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SettingsPropertyCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SettingsPropertyValueCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedDictionary<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedList<,>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedSet<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Stack<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (StringCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (StringDictionary), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedDictionary<, >.KeyCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SortedDictionary<, >.ValueCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (NameObjectCollectionBase.KeysCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DesignerOptionService.DesignerOptionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TypeConverter.StandardValuesCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TempFileCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TraceListenerCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (UnicastIPAddressInformationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (X509ChainElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (X509ExtensionCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.SortedList`2+KeyList, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.SortedList`2+ValueList, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.ListDictionary+NodeKeyValueCollection, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.OrderedDictionary+OrderedDictionaryKeyValueCollection, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.StringDictionary+GenericAdapter, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Specialized.StringDictionary+GenericAdapter+ICollectionToGenericCollectionAdapter, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Net.ProxyChain, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Net.SpnDictionary+ValueCollection, System", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.BlockingCollection`1+<GetConsumingEnumerable>d__0, System", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.SortedSet`1+<Reverse>d__12, System", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Concurrent.BlockingCollection`1+<GetConsumingEnumerable>d__68, System", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.SortedSet`1+<Reverse>d__104, System", Description = VisualizerRegistration.DescriptionV46)]

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
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.ExpandoObject+MetaExpando+<GetDynamicMemberNames>d__6, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Select>d__3`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Dynamic.Utils.CollectionExtensions+<Where>d__5`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<CastIterator>d__94`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ConcatIterator>d__58`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DefaultIfEmptyIterator>d__90`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<DistinctIterator>d__63`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ExceptIterator>d__72`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<GroupJoinIterator>d__40`4, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<IntersectIterator>d__69`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<JoinIterator>d__37`4, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<OfTypeIterator>d__92`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RangeIterator>d__110, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<RepeatIterator>d__112`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ReverseIterator>d__74`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectIterator>d__5`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__16`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__18`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__20`3, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SelectManyIterator>d__22`3, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipIterator>d__30`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__32`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<SkipWhileIterator>d__34`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeIterator>d__24`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__26`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<TakeWhileIterator>d__28`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<UnionIterator>d__66`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<WhereIterator>d__2`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Enumerable+<ZipIterator>d__60`3, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Lookup`2+<ApplyResultSelector>d__13`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.CancellableEnumerable+<Wrap>d__0`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapEnumerable>d__0`1, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ExceptionAggregator+<WrapQueryEnumerator>d__1`2, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.PartitionerQueryOperator`1+<AsSequentialQuery>d__5, System.Core", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Linq.Parallel.ZipQueryOperator`3+<AsSequentialQuery>d__9, System.Core", Description = VisualizerRegistration.DescriptionV46)]
// System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ArrangedElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (AutoCompleteStringCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BaseCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BindingContext), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (BindingSource), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataGridViewRowCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (GridItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (HtmlElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (HtmlWindowCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListViewGroupCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (NumericUpDownAccelerationCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ResXResourceReader), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CheckedListBox.CheckedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (CheckedListBox.CheckedItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ComboBox.ObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataGridViewComboBoxCell.ObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ImageList.ImageCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (LinkLabel.LinkCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListBox.IntegerCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListBox.ObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListBox.SelectedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListBox.SelectedObjectCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.CheckedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.CheckedListViewItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.ColumnHeaderCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.ListViewItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.SelectedIndexCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListView.SelectedListViewItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ListViewItem.ListViewSubItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (Menu.MenuItemCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (PropertyGrid.PropertyTabCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (StatusBar.StatusBarPanelCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TabControl.TabPageCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ToolBar.ToolBarButtonCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TableLayoutStyleCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (TreeNodeCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.ClientUtils+WeakRefCollection, System.Windows.Forms", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.DataGridViewCellLinkedList, System.Windows.Forms", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.DataGridViewIntLinkedList, System.Windows.Forms", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Forms.PropertyGridInternal.MergePropertyDescriptor+MultiMergeCollection, System.Windows.Forms", Description = VisualizerRegistration.Description)]

// PresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
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
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.ColumnDefinitionCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.CustomDictionarySources, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.DataGridColumnHeaderCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.MultipleCopiesCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.Selector+InternalSelectedItemsStorage, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.RowDefinitionCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.UIElementCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.VirtualizedCellInfoCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Data.CollectionView, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Data.CompositeCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentReferenceCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.FigureStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.ListItemStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.ListStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.ParagraphStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.SectionStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.StoryFragment, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.StoryFragments, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableCellStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableRowGroupStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableRowStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.DocumentStructures.TableStructure, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.FixedTextBuilder+FlowModelBuilder+LogicalHyperlinkContainer, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.PageContentCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.TableCellCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.TableColumnCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.TableRowCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.TableRowGroupCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Documents.TextElementCollection`1, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.LogicalTreeHelper+EnumeratorWrapper, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Localizer.BamlLocalizationDictionary, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+PartiallyOrderedList`2, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.XmlnsDictionary, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Media.Animation.ThicknessKeyFrameCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Navigation.JournalEntryStack, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Navigation.LimitedJournalEntryStackEnumerable, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Navigation.UnifiedJournalEntryStackEnumerable, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.ResourceDictionary, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.ResourceDictionary+ResourceValuesCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.TriggerActionCollection, PresentationFramework", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.WindowCollection, PresentationFramework", Description = VisualizerRegistration.Description)]

[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Ink.ClipboardProcessor+<get_PreferredFormats>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Ink.InkCanvasSelection+<get_SelectedElementsBoundsEnumerator>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarButtons>d__7, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarDayButtons>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.SelectedDatesCollection+<GetDaysInRange>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.SpellingError+<get_Suggestions>d__0, PresentationFramework", Description = VisualizerRegistration.DescriptionV45)]
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
//.net4.6
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Ink.ClipboardProcessor+<get_PreferredFormats>d__5, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Ink.InkCanvasSelection+<get_SelectedElementsBoundsEnumerator>d__39, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarButtons>d__56, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.Primitives.CalendarItem+<GetCalendarDayButtons>d__51, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.SelectedDatesCollection+<GetDaysInRange>d__28, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Controls.SpellingError+<get_Suggestions>d__4, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementDictionaryItemsPseudoProperty+<get_Items>d__8, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementItemsPseudoProperty+<get_Items>d__8, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementMarkupObject+<GetProperties>d__5, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ElementPropertyBase+<get_Items>d__6, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierMarkupObject+<GetProperties>d__3, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.ExtensionSimplifierProperty+<get_Items>d__6, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryContent+<get_Items>d__8, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.FrameworkElementFactoryMarkupObject+<GetProperties>d__8, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateAllMappings>d__19, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.Primitives.MarkupWriter+Scope+<get_EnumerateLocalMappings>d__17, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Windows.Markup.XmlnsDictionary+<GetNamespacePrefixes>d__15, PresentationFramework", Description = VisualizerRegistration.DescriptionV46)]
// System.Data, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataColumnMappingCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataTableMappingCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataView), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataViewManager), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DataViewSettingCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DbConnectionStringBuilder), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DbDataReader), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (DbParameterCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (InternalDataCollectionBase), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (OdbcErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (OleDbErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (SqlErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Common.ReadOnlyCollection`1, System.Data", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.RBTree`1, System.Data", Description = VisualizerRegistration.Description)]

// System.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (XmlNamedNodeMap), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (XmlNamespaceManager), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (XmlNode), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (XmlNodeList), Description = VisualizerRegistration.Description)]
#pragma warning disable 618
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (XmlSchemaCollection), Description = VisualizerRegistration.Description)]
#pragma warning restore 618
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (XPathNodeIterator), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+NamesCollection, System.Xml", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.XmlSchemaObjectTable+ValuesCollection, System.Xml", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.SchemaInfo+<System.Xml.IDtdInfo.GetAttributeLists>d__0, System.Xml", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Schema.SchemaInfo+<System-Xml-IDtdInfo-GetAttributeLists>d__60, System.Xml", Description = VisualizerRegistration.DescriptionV46)]
// System.Xml.Linq, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "MS.Internal.Xml.Linq.ComponentModel.XDeferredAxis`1, System.Xml.Linq", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAncestors>d__f`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAttributes>d__8, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendantNodes>d__16`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendants>d__1f`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetElements>d__29`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<Nodes>d__0`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendantNodes>d__4, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendants>d__a, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__11, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<Nodes>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XElement+<GetAttributes>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetAncestors>d__8, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsAfterSelf>d__c, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsBeforeSelf>d__11, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesAfterSelf>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesBeforeSelf>d__4, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<Annotations>d__6`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<AnnotationsIterator>d__0, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.XPath.XPathEvaluator+<EvaluateIterator>d__0`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV45)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAncestors>d__19`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetAttributes>d__18, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendantNodes>d__20`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetDescendants>d__21`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<GetElements>d__22`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.Extensions+<Nodes>d__6`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendantNodes>d__38, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetDescendants>d__39, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<GetElements>d__40, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XContainer+<Nodes>d__18, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XElement+<GetAttributes>d__104, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetAncestors>d__40, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsAfterSelf>d__41, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<GetElementsBeforeSelf>d__42, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesAfterSelf>d__21, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XNode+<NodesBeforeSelf>d__22, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<Annotations>d__16`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.Linq.XObject+<AnnotationsIterator>d__15, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Xml.XPath.XPathEvaluator+<EvaluateIterator>d__1`1, System.Xml.Linq", Description = VisualizerRegistration.DescriptionV46)]

// System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Caching.Cache, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Caching.CacheInternal, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Hosting.MapPathBasedVirtualPathCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.HttpSessionStateBase, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.HttpStaticObjectsCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.HttpStaticObjectsCollectionBase, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelBinderDictionary, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelStateDictionary, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Profile.ProfileInfoCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Routing.RouteValueDictionary, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.SessionState.HttpSessionState, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.SiteMapNodeCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.ControlCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.DataBindingCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.ExpressionBindingCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.FilteredAttributeDictionary, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.HtmlControls.HtmlTableCellCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.HtmlControls.HtmlTableRowCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.ParsedAttributeCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.StateBag, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.StateManagedCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.ValidatorCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataGridColumnCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataGridItemCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataKeyArray, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataKeyCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.DataListItemCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.DetailsViewRowCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.DummyDataSource, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.GridViewRowCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.ListItemCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.MenuItemCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.MethodParametersDictionary, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.PagedDataSource, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.RepeaterItemCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.SelectedDatesCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.TableCellCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.TableRowCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.TreeNodeCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.WebParts.PersonalizationDictionary, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.WebParts.PersonalizationStateInfoCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.WizardStepCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.XmlDataSourceView+XmlDataSourceNodeDescriptorEnumeration, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.UI.WebControls.XmlHierarchicalEnumerable, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Util.EmptyCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Util.FileEnumerator, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Util.ObjectSet, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Util.SingleObjectCollection, System.Web", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelValidator+CompositeModelValidator+<Validate>d__1, System.Web", Description = VisualizerRegistration.Description)]
//.net4.5
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Hosting.ApplicationManager+<CreateFutureMicrosoftWebInfrastructureStrongNames>d__19, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__0, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.CollectionModelBinderUtil+<GetZeroBasedIndexes>d__0, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.DataAnnotationsModelValidator+<Validate>d__15, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.DictionaryHelpers+<FindKeysWithPrefix>d__0`1, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.ValidatableObjectAdapter+<ConvertResults>d__2, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.AntiXss.CssEncoder+<CssSafeList>d__0, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlParameterSafeList>d__0, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlPathSafeList>d__6, System.Web", Description = VisualizerRegistration.DescriptionV45)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.RoleClaimProvider+<get_Claims>d__0, System.Web", Description = VisualizerRegistration.DescriptionV45)]
//.net4.6
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Hosting.ApplicationManager+<CreateFutureMicrosoftWebInfrastructureStrongNames>d__73, System.Web", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.AssociatedMetadataProvider+<GetMetadataForPropertiesImpl>d__4, System.Web", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.CollectionModelBinderUtil+<GetZeroBasedIndexes>d__4, System.Web", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.DataAnnotationsModelValidator+<Validate>d__11, System.Web", Description = VisualizerRegistration.DescriptionV46)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.DictionaryHelpers+<FindKeysWithPrefix>d__0`1, System.Web", Description = VisualizerRegistration.DescriptionV46)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.ModelValidator+CompositeModelValidator+<Validate>d__1, System.Web", Description = VisualizerRegistration.DescriptionV46)]
//[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.ModelBinding.ValidatableObjectAdapter+<ConvertResults>d__2, System.Web", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.AntiXss.CssEncoder+<CssSafeList>d__3, System.Web", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlParameterSafeList>d__8, System.Web", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.AntiXss.HtmlParameterEncoder+<UrlPathSafeList>d__12, System.Web", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Security.RoleClaimProvider+<get_Claims>d__4, System.Web", Description = VisualizerRegistration.DescriptionV46)]
// System.Web.Mvc, Version=5.2.3.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.ComponentModel.AttributeList, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.CopyOnWriteDictionary`2, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.GlobalFilterCollection, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ModelBinderDictionary, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ModelStateDictionary, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.MultiSelectList, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.Routing.RouteCollectionRoute, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.Routing.SubRouteCollection, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.TempDataDictionary, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ValueProviderDictionary, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ViewDataDictionary, System.Web.Mvc", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Collections.Generic.DictionaryExtensions+<FindKeysWithPrefix>d__1`1, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ClientDataTypeModelValidatorProvider+<GetValidatorsImpl>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.CompareAttribute+<GetClientValidationRules>d__8, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.CompareAttributeAdapter+<GetClientValidationRules>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ControllerInstanceFilterProvider+<GetFilters>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.DataErrorInfoModelValidatorProvider+<GetValidatorsImpl>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.DataTypeAttributeAdapter+<GetClientValidationRules>d__1, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.DefaultModelBinder+<GetZeroBasedIndexes>d__18, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.DictionaryHelpers+<FindKeysWithPrefix>d__0`1, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.FileExtensionsAttributeAdapter+<GetClientValidationRules>d__1, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.FilterAttributeFilterProvider+<GetFilters>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.Html.TemplateHelpers+<GetViewNames>d__4, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.MembershipPasswordAttributeAdapter+<GetClientValidationRules>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ModelValidator+CompositeModelValidator+<Validate>d__1, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ModelValidatorProviderCollection+<GetValidators>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.RemoteAttribute+<GetClientValidationRules>d__0, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ValidatableObjectAdapter+<ConvertResults>d__2, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Web.Mvc.ViewDataDictionary+ViewDataEvaluator+<GetRightToLeftExpressions>d__2, System.Web.Mvc", Description = VisualizerRegistration.DescriptionV46)]

// Microsoft.Web.Administration, Version=7.9.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationAttributeCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationAttributeSchemaCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationChildElementCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationElementCollectionBase`1, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationElementSchemaCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationEnumValueCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.ConfigurationMethodCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.SectionDefinitionCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Web.Administration.SectionGroupCollection, Microsoft.Web.Administration", Description = VisualizerRegistration.Description)]

// System.Configuration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConfigurationElementCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConfigurationLockCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ConfigurationPropertyCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), Target = typeof (ProviderCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+ConfigurationElementsCollection, System.Configuration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+EmptyCollection, System.Configuration", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "System.Configuration.ConfigurationValues+InvalidValuesCollection, System.Configuration", Description = VisualizerRegistration.Description)]

// System.DirectoryServices, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.DirectoryServices.DirectoryEntries, System.DirectoryServices", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.DirectoryServices.PropertyCollection, System.DirectoryServices", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.DirectoryServices.PropertyCollection+ValuesCollection, System.DirectoryServices", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.DirectoryServices.SchemaNameCollection, System.DirectoryServices", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.DirectoryServices.SearchResultCollection, System.DirectoryServices", Description = VisualizerRegistration.Description)]

// Microsoft.VisualBasic, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.VisualBasic.Collection, Microsoft.VisualBasic", Description = VisualizerRegistration.Description)]

// System.Data.DataSetExtensions, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.EnumerableRowCollection, System.Data.DataSetExtensions", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.TypedTableBase`1, System.Data.DataSetExtensions", Description = VisualizerRegistration.Description)]

// SD.LLBLGen.Pro.ORMSupportClasses, Version=4.2.0.0, Culture=neutral, PublicKeyToken=ca73b74ba4e3ff27
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.Grouping`2, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.GroupByCollection, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.PredicateExpression, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedListBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedListBase2`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.TypedViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.UniqueList`1, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.QuerySpec.Grouping`2, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependentRelatedEntityCoreInstances>d__6, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetDependingRelatedEntityCoreInstances>d__0, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase+<GetMemberEntityCollectionCoreInstances>d__c, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependentRelatedEntityCoreInstances>d__8, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetDependingRelatedEntityCoreInstances>d__2, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityBase2+<GetMemberEntityCollectionCoreInstances>d__e, SD.LLBLGen.Pro.ORMSupportClasses", Description = VisualizerRegistration.Description)]

//-LLBL 3
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.CollectionCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.DataSourceBase2`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.LinqSupportClasses.LLBLGenProQuery`1, SD.LLBLGen.Pro.LinqSupportClasses.NET35", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityViewBase`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "SD.LLBLGen.Pro.ORMSupportClasses.EntityFieldsCore`1, SD.LLBLGen.Pro.ORMSupportClasses.NET20", Description = VisualizerRegistration.Description)]

//misc
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataSource+DataProviderCollection, Microsoft.Data.ConnectionUI.Dialog", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof (EnumerableVisualizer), typeof (EnumerableVisualizerObjectSource), TargetTypeName = "Microsoft.Data.ConnectionUI.DataConnectionDialog+DataSourceCollection, Microsoft.Data.ConnectionUI.Dialog", Description = VisualizerRegistration.Description)]

//-Other classes
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.Table`1, System.Data.Linq", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "System.Data.Linq.DataQuery`1, System.Data.Linq", Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ObjectListView), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(ObjectListView<>), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(DataTable), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SqlErrorCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), Target = typeof(SqlParameterCollection), Description = VisualizerRegistration.Description)]
[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), TargetTypeName = "Oracle.DataAccess.Client.OracleParameterCollection, Oracle.DataAccess.Client", Description = VisualizerRegistration.Description)]

namespace AW.DebugVisualizers
{
  [SuppressMessage("ReSharper", "MemberCanBePrivate.Global")]
  [SuppressMessage("ReSharper", "UnusedMember.Global")]
  public static class VisualizerRegistration
  {
    /// <summary>
    ///   Enumerable Visualizer
    /// </summary>
    public const string Description = "Enumerable Visualizer";

    public const string DescriptionV46 = Description + " V4.6";
    public const string DescriptionV45 = Description + " V4.0";
    private const string VisualizerRegistrationsPart1 = "[assembly: DebuggerVisualizer(typeof(EnumerableVisualizer), typeof(EnumerableVisualizerObjectSource), ";
    private const string TargetTypeNameDescriptionVisualizerRegistrationDescription = "TargetTypeName = \"{0}\", Description = VisualizerRegistration.Description)]";
    private const string TargetTypeNameFormat = VisualizerRegistrationsPart1 + TargetTypeNameDescriptionVisualizerRegistrationDescription;
    private const string TargetTypeNameDescriptionVisualizerRegistrationDescriptionVersion = "TargetTypeName = \"{0}\", Description = VisualizerRegistration.DescriptionV{1})]";
    private const string TargetTypeNameFormatVersion = VisualizerRegistrationsPart1 + TargetTypeNameDescriptionVisualizerRegistrationDescriptionVersion;
    private const string TargetTypeDescriptionVisualizerRegistrationDescription = "Target = typeof ({0}), Description = VisualizerRegistration.Description)]";
    private const string TargetTypeFormat = VisualizerRegistrationsPart1 + TargetTypeDescriptionVisualizerRegistrationDescription;

    public static IEnumerable<string> CreateForPrivateNestedNotSerializableSealed(Assembly assembly)
    {
      var majorMinorVersion = MetaDataHelper.GetBclMajorMinorVersion().Replace(".", "");
      var visualizerRegistrations = from t in GetBaseEnumerableTypes(assembly)
                                    where
                                      IsPrivateNestedNotSerializableSealed(t)
                                    select String.Format(TargetTypeNameFormatVersion, MetaDataHelper.GetClassAssemblyName(t), majorMinorVersion);
      return visualizerRegistrations.OrderBy(n => n);
    }

    private static bool IsPrivateNestedNotSerializableSealed(Type t)
    {
      return !t.IsSerializable
             && t.IsNestedPrivate
             && t.IsSealed
             && t.Name.Contains("_");
    }

    public static IEnumerable<string> CreateOtherPrivateVisualizerRegistrations(Assembly assembly)
    {
      return CreateTargetTypeNameVisualizerRegistrations(assembly, true);
    }

    private static IEnumerable<string> CreateTargetTypeNameVisualizerRegistrations(Assembly assembly, bool invisibleOnly)
    {
      var enumerableTypes = GetBaseEnumerableTypes(assembly);
      if (invisibleOnly)
        enumerableTypes = enumerableTypes.Where(t => !t.IsVisible);
      enumerableTypes = enumerableTypes.Where(t => !IsPrivateNestedNotSerializableSealed(t));
      return CreateTargetTypeNameVisualizerRegistrations(enumerableTypes).OrderBy(n => n);
    }

    private static IEnumerable<string> CreateTargetTypeNameVisualizerRegistrations(IEnumerable<Type> enumerableTypes)
    {
      return enumerableTypes.Select(t => String.Format(TargetTypeNameFormat, MetaDataHelper.GetClassAssemblyName(t)));
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

    public static IEnumerable<string> CreatePublicVisualizerRegistrationsAsTarget(Assembly assembly)
    {
      var visualizerRegistrations = from t in GetBaseEnumerableTypes(assembly)
                                    where t.IsVisible
                                    select String.Format(TargetTypeFormat, (t.IsNested ? t.FullName : t.Name).Replace("`1", "<>").Replace("`2", "<,>").Replace("+", "."));
      return visualizerRegistrations.OrderBy(n => n);
    }

    public static string CreateVisualizerRegistrations(params Assembly[] assemblies)
    {
      return CreateVisualizerRegistrations(assemblies, true);
    }

    public static string CreateVisualizerRegistrationsAsTargetTypeName(params Assembly[] assemblies)
    {
      return CreateVisualizerRegistrations(assemblies, false);
    }

    private static string CreateVisualizerRegistrations(IEnumerable<Assembly> assemblies, bool createVisibleAsTarget)
    {
      var stringBuilder = new StringBuilder();
      foreach (var assembly in assemblies)
      {
        stringBuilder.Append("// " + assembly.FullName);
        stringBuilder.AppendLine();
        var visualizerRegistrations = createVisibleAsTarget
          ? CreatePublicVisualizerRegistrationsAsTarget(assembly).Union(CreateOtherPrivateVisualizerRegistrations(assembly)).Union(CreateForPrivateNestedNotSerializableSealed(assembly))
          : CreateTargetTypeNameVisualizerRegistrations(assembly, false).Union(CreateForPrivateNestedNotSerializableSealed(assembly));
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