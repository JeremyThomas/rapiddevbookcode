using System;
using System.IO;
using AW.Winforms.Helpers.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;

//http://msdn.microsoft.com/en-us/library/aa991998(VS.100).aspx 'Use IVisualizerObjectProvider..::.GetData when the object is not serializable by .NET and requires custom serialization. 
// In that case, you must also override the VisualizerObjectSource..::.Serialize method.'

namespace ObjectSourceVisualizer
{
  public class ObjectSourceVisualizer : DialogDebuggerVisualizer
  {
    private IDialogVisualizerService _modalService;

    /// <summary>
    ///   Enumerable Visualizer
    /// </summary>
    public const string Description = "ObjectSourceVisualizer";

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
      var s = o as string;

      if (s != null)
      {
        var textEditor = new TextEditor();
        // AWHelper.ShowForm(textEditor);
        // Application.DoEvents();
        textEditor.Open(s);
        _modalService.ShowDialog(textEditor);
      }
    }
  }

  public class ObjectSourceVisualizerObjectSource : VisualizerObjectSource
  {
    #region Overrides of VisualizerObjectSource

    /// <summary>
    ///   Gets data from the specified object and serializes it into the outgoing data stream
    ///   This class implements the debugee side of the visualizer. It is responsible for running the commands against the
    ///   server.
    /// </summary>
    /// <remarks>
    ///   Strategy is: if the items are serializable then
    ///   if the enumerable is also serializable
    ///   serialize the enumerable
    ///   else
    ///   create a ObjectListView to contains the items and serialize that instead.
    ///   Full back is to copy the enumerable to a data table and serialize that instead.
    /// </remarks>
    /// <param name="target">Object being visualized.</param>
    /// <param name="outgoingData">Outgoing data stream.</param>
    public override void GetData(object target, Stream outgoingData)
    {
      var wr = target as WeakReference;
      if (wr != null)
        target = wr.Target;
      var result = ObjectToObjectLiteral.ToObjectInitializer
        (
          target, ""
        );

      Serialize(outgoingData, result);
    }

    #endregion
  }
}