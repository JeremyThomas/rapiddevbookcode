using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace AW.Winforms.Helpers
{
  /// <summary>
  ///   Trace listener that outputs to a text box
  /// </summary>
  /// <remarks>
  ///   Thread safe.  Invokes call to update text box.
  ///   http://www.codeproject.com/KB/trace/TextBoxTraceListener.aspx
  /// </remarks>
  public class TextBoxTraceListener : TraceListener
  {
    private readonly TextBox _target;
    private readonly StringSendDelegate _invokeWrite;
    private readonly bool _scrollToBottom = true;

    /// <summary>
    ///   Create a new text box trace listener that writes to the
    /// </summary>
    /// <param name="target">The text box to write trace information to</param>
    public TextBoxTraceListener(TextBox target)
    {
      _target = target;
      _invokeWrite = SendString;
      Name = "TextBoxTraceListener";
    }

    public TextBoxTraceListener(TextBox target, bool _scrollToBottom) : this(target)
    {
      this._scrollToBottom = _scrollToBottom;
    }

    /// <summary>
    ///   Writes a string to the textbox
    /// </summary>
    /// <param name="message">The string to write to the textbox</param>
    public override void Write(string message)
    {
      if (!_target.InvokeRequired)
        SendString(message);
      else
      {
        var form = _target.FindForm();
        if (form != null && form.Visible)
          _target.Invoke(_invokeWrite, new object[] {message});
      }
    }

    /// <summary>
    ///   Writes a string followed by a new line character to the textbox
    /// </summary>
    /// <param name="message">The string to write to the textbox</param>
    public override void WriteLine(string message)
    {
      Write(message + Environment.NewLine);
    }

    /// <summary>
    ///   Delegate to invoke on the text box
    /// </summary>
    /// <param name="message">string to pass through to the writing method</param>
    private delegate void StringSendDelegate(string message);

    /// <summary>
    ///   Method passed for invokation by the text box
    /// </summary>
    /// <param name="message">The string to write</param>
    private void SendString(string message)
    {
      // No need to lock text box as this function will only ever be executed from the UI thread
      _target.Text += message;
      if (_scrollToBottom)
      {
        _target.SelectionStart = _target.Text.Length;
        _target.ScrollToCaret();
      }
    }
  }
}