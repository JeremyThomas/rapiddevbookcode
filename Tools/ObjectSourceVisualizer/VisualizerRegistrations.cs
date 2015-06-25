//http://msdn.microsoft.com/en-us/library/e2zc529c.aspx 'You can write a custom visualizer for an object of any managed class except for Object or Array.'
//http://weblogs.asp.net/fbouma/archive/2006/02/06/437536.aspx Debugger visualizers won't work on interface types 
//http://social.msdn.microsoft.com/Forums/en-US/vsdebug/thread/93d53290-998e-48ad-98bc-9fcd9e642f57 VS cannot locate a custom debug visualizer for a nested class

using System;
using System.Diagnostics;
using ObjectAsSourceCodeVisualizer;

// type - Visualizer binding

[assembly: DebuggerVisualizer(typeof(ObjectSourceVisualizer), typeof(ObjectSourceVisualizerObjectSource), Target = typeof(WeakReference), Description = ObjectSourceVisualizer.Description)]

