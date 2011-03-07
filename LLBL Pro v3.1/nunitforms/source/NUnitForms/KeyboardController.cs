#region Copyright (c) 2003-2005, Luke T. Maxon

/********************************************************************************************************************
'
' Copyright (c) 2003-2005, Luke T. Maxon
' All rights reserved.
' 
' Redistribution and use in source and binary forms, with or without modification, are permitted provided
' that the following conditions are met:
' 
' * Redistributions of source code must retain the above copyright notice, this list of conditions and the
' 	following disclaimer.
' 
' * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and
' 	the following disclaimer in the documentation and/or other materials provided with the distribution.
' 
' * Neither the name of the author nor the names of its contributors may be used to endorse or 
' 	promote products derived from this software without specific prior written permission.
' 
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED
' WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
' PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
' ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
' LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
' INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
' OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN
' IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'
'*******************************************************************************************************************/

#endregion

using System;
using System.Windows.Forms;
using NUnit.Extensions.Forms.SendKey;

namespace NUnit.Extensions.Forms
{
    

    //TODO: should make sure caps lock is off and return it to its pretest state
    //make sure all keys are released at the end of each test.

    /// <summary>
    /// Provides testing control of the keyboard.
    /// </summary>
    /// <remarks>
    /// KeyboardController lets you send key presses to your application.  You can
    /// click, press, or release any key.  The UseOn() method allows you to assert
    /// focus on a specific control before sending the keys.  It also initializes
    /// the Keyboard controller for use by blocking user input.
    /// </remarks>
    public class KeyboardController : IDisposable
    {
        private readonly ISendKeysFactory sendKeysFactory;
        private ISendKeys sendKeys;
        private KeyboardControl keyboardControl = null;
        private bool restoreUserInput = false;

        internal KeyboardController(ISendKeysFactory sendKeysFactory)
        {
            this.sendKeysFactory = sendKeysFactory;
        }

        /// <summary>
        /// Creates a keyboard controller and sets the focus on the control
        /// indicated by the supplied ControlTester.
        /// </summary>
        /// <param name="controlTester">The ControlTester to use the keyboard
        /// on.</param>
        public KeyboardController(ControlTester controlTester) : this(new OldSendKeysFactory())
        {
            UseOn(controlTester);
        }

        #region IDisposable Members

        /// <summary>
        /// Implements the IDisposable interface.  This restores user input.
        /// It should eventually return the keyboard to its pre-test state.
        /// </summary>
        /// <remarks>
        /// If you are using the Keyboard controller through the base NUnitFormTest
        /// class, then you should not need to call this method or use finally or using
        /// blocks.  The base class handles this for you.</remarks>
        public void Dispose()
        {
            if (keyboardControl != null)
            {
                if (restoreUserInput)
                {
                    //if this next line returns false, I used to throw an exception...
                    Win32.BlockInput(false);
                    restoreUserInput = false;
                }
            }
        }

        #endregion

        /// <summary>
        /// Initializes the KeyboardController, blocks user input, and sets
        /// the focus on the specified control.
        /// </summary>
        /// <param name="control">The ControlTester to use the keyboard on.</param>
        public void UseOn(ReflectionTester control)
        {
            if (control == null)
            {
                throw new ArgumentNullException("control");
            }

            Control c = control.TheObject as Control;
            FormsAssert.IsTrue(c != null, "Keyboard control requires tester of Control");
            sendKeys = sendKeysFactory.Create(c.Handle);

            keyboardControl = new KeyboardControl(control);

            if (!restoreUserInput)
            {
                //if this next line returns false, I used to throw an exception...
                Win32.BlockInput(true);
                restoreUserInput = true;
            }
        }

        /// <summary>
        /// Overloaded.  Allows you to specify the control by name.
        /// </summary>
        /// <remarks>
        /// You should probably use this one if you are not sure.</remarks>
        /// <param name="name">The name of the control.</param>
        public void UseOn(string name)
        {
            UseOn(new ControlTester(name));
        }

        /// <summary>
        /// Overloaded.  Allows you to specify the control by name and
        /// qualified by a form name.
        /// </summary>
        /// <param name="name">The name of the control.</param>
        /// <param name="formName">The name of the form.</param>
        public void UseOn(string name, string formName)
        {
            UseOn(new ControlTester(name, formName));
        }

        /// <summary>
        /// Overloaded.  Allows you to specify the control by name and
        /// qualified by a form instance.  This should be obsolete soon.
        /// Do not use it unless necessary.
        /// </summary>
        /// <param name="name">The name of the control.</param>
        /// <param name="form">The form instance to test on.</param>
        [Obsolete()]
        public void UseOn(string name, Form form)
        {
            UseOn(new ControlTester(name, form));
        }

        /// <summary>
        /// This will send a string of key inputs.
        /// </summary>
        /// <remarks>
        /// Use + for SHIFT
        /// Use ^ for CONTROL
        /// Use % for ALT
        /// Use {} to escape or to group examples
        /// ^a is Control A
        /// +{abc} is SHIFT A SHIFT B SHIFT C
        /// {%} is %
        /// My goal is to support the strings as shown here: http://www.rutherfurd.net/python/sendkeys/
        /// but it is not done yet
        /// </remarks>
        /// <param name="keyString">the keys to type</param>
        public void Type(string keyString)
        {
            Press(keyString);
        }

        /// <summary>
        /// Press and release a key.
        /// these constants.
        /// </summary>
        /// <remarks>
        /// Use the Key class (in Key.cs) to find these constants.
        /// </remarks>
        /// <param name="key">The key to click.</param>
        public void Click(string key)
        {
            Press(key);
            Release(key);
        }

        /// <summary>
        /// Press a key.
        /// </summary>
        /// <remarks>
        /// Use the Key class (in Key.cs) to find these constants.
        /// </remarks>
        /// <param name="key">The key to press.</param>
        public void Press(string key)
        {
            keyboardControl.Focus();

			sendKeys.SendWait(key);

            Application.DoEvents();
        }

        /// <summary>
        /// Release a key.  
        /// </summary>
        /// <remarks>
        /// Use the Key class (in Key.cs) to find these constants.
        /// </remarks>
        /// <param name="key">The key to release.</param>
        public void Release(string key)
        {
            Application.DoEvents();
        }
    }
}