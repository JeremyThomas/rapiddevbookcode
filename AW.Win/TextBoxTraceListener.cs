using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Forms;

namespace Logging
{
    /// <summary>
    /// Trace listener that outputs to a text box
    /// </summary>
    /// <remarks>Thread safe.  Invokes call to update text box</remarks>
    public class TextBoxTraceListener : TraceListener
    {
        private TextBox _target;
        private StringSendDelegate _invokeWrite;

        /// <summary>
        /// Create a new text box trace listener that writes to the 
        /// </summary>
        /// <param name="target">The text box to write trace information to</param>
        public TextBoxTraceListener(TextBox target)
        {
            _target = target;
            _invokeWrite = new StringSendDelegate(SendString);
        }

        /// <summary>
        /// Writes a string to the textbox
        /// </summary>
        /// <param name="message">The string to write to the textbox</param>
        public override void Write(string message)
        {
            _target.Invoke(_invokeWrite, new object[] { message });
        }

        /// <summary>
        /// Writes a string followed by a new line character to the textbox
        /// </summary>
        /// <param name="message">The string to write to the textbox</param>
        public override void WriteLine(string message)
        {
            _target.Invoke(_invokeWrite, new object[] { message + Environment.NewLine });
        }

        /// <summary>
        /// Delegate to invoke on the text box
        /// </summary>
        /// <param name="message">string to pass through to the writing method</param>
        private delegate void StringSendDelegate(string message);

        /// <summary>
        /// Method passed for invokation by the text box
        /// </summary>
        /// <param name="message">The string to write</param>
        private void SendString(string message)
        {
            // No need to lock text box as this function will only ever be executed from the UI thread
            _target.Text += message;
        }
    }
}
