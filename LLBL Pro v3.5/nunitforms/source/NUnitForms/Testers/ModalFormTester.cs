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
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// Used to specify a handler for a Modal form that is displayed during testing.
    /// </summary>
    /// <param name="name">Title of the form. Note that the titles of the file dialog boxes are not reliable.</param>
    /// <param name="hWnd">Handle of the modal form. Can be passed to the constructors of the dialog box testers.</param>
    /// <param name="form">Reference to the modal form. Null if it is a dialog box.</param>
    public delegate void ModalFormHandler(string name, IntPtr hWnd, Form form);
    /// <summary>
    /// Same as ModalFormHandler, without the form argument.
    /// </summary>
    public delegate void DialogBoxHandler(string name, IntPtr hWnd);

    [Obsolete]
    public delegate void ModalFormActivated();
    [Obsolete]
    internal delegate void ModalFormActivatedHwnd(IntPtr hWnd);

    ///<summary>
    /// A class for testing Modal Forms.
    ///</summary>
    public class ModalFormTester : IDisposable
    {
        private const int CbtHookType = 5;
        private const int HCBT_DESTROYWND = 4;
        private const int HCBT_ACTIVATE = 5;
        private const int HCBT_MOVESIZE = 0;
        private const int HCBT_SETFOCUS = 9;


        ModalFormHandler formHandler;
        public ModalFormHandler FormHandler
        {
            get
            {
                return formHandler;
            }
            set
            {
                formHandler = value;
            }
        }

        private Win32.CBTCallback callback = null;
        private IntPtr handleToHook = IntPtr.Zero;

        /// <summary>
        /// This list is used to keep track of which windows that have been created.
        /// </summary>
        private List<IntPtr> hwndList;

        /// <summary>
        /// True if we have begun listening for CBT Activate events.
        /// </summary>
        private bool listening = false;

        public ModalFormTester()
        {
            hwndList = new List<IntPtr>();
            unexpectedModals = new System.Collections.Generic.List<string>();
            BeginListening();
        }

        #region IDisposable Members

        ///<summary>
        /// Disposes any resources being managed.
        ///</summary>
        public void Dispose()
        {
            if (handleToHook != IntPtr.Zero)
            {
                Win32.UnhookWindowsHookEx(handleToHook);
                handleToHook = IntPtr.Zero;
            }
            GC.SuppressFinalize(this);
        }

        #endregion

        public void ClearWindowList()
        {
            // Clear the list of open windows. Should be called from Setup to make sure no windows is in the list 
            // when starting a new testcase.
            hwndList.Clear();
        }

        ~ModalFormTester()
        {
            Dispose();
        }


        public class Result
        {
            bool allModalsShown;
            public bool AllModalsShown
            {
                get { return allModalsShown; }
            }
            System.Collections.Generic.List<string> unexpectedModals;
            public System.Collections.Generic.IEnumerable<string> UnexpectedModals
            {
                get { return unexpectedModals; }
            }
            public bool UnexpectedModalWasShown
            {
                get { return unexpectedModals.Count > 0; }
            }
            public Result(bool allShown, System.Collections.Generic.List<string> unexpected)
            {
                allModalsShown = allShown;
                unexpectedModals = unexpected;
            }
        }
        /// <summary>
        /// Verifies that all expected handlers were invoked,
        /// and that no unexpected ones were.
        /// </summary>
        public Result Verify()
        {
            if (handlers.Count == 0)
            {
                Result res = new Result(FormHandler == null, unexpectedModals);
                unexpectedModals = new List<string>();
                return res;
            }
            else // the old interface was used
            {
                foreach (string name in handlers.Keys)
                {
                    Handler h = (Handler)handlers[name];
                    if (!h.Verify()) return new Result(false, new List<string>());
                }
                return new Result(true, new List<string>());
            }
        }

        private void BeginListening()
        {
            if (!listening)
            {
                listening = true;
                // Note: the callback is saved as a member to keep the CLR from shuffling off the pointer
                // before the callback is used.
                // If we try to assign the call back "inline" we get memory violation errors.
                callback = Callback_ModalListener;
                handleToHook = Win32.SetWindowsHookEx(HCBT_ACTIVATE, callback, IntPtr.Zero, Win32.GetCurrentThreadId());
            }
        }

        private void Invoke(string name, IntPtr hWnd, Form form)
        {

            if (name == null) return;
            if (name == string.Empty) name = "Unnamed";
            ModalFormHandler h = formHandler;
            formHandler = null;

            if (h == null) h = UnexpectedModal;

            h(name, hWnd, form);
        }

        System.Collections.Generic.List<string> unexpectedModals;

        private void UnexpectedModal(string name, IntPtr hWnd, Form form)
        {

            Win32.DestroyWindow(hWnd);
            unexpectedModals.Add(name);
        }



        /// <summary>
        /// CBT callback called when a form is activated.
        /// If the newly activated form is modal, invoke the registered handler.
        /// </summary>
        private IntPtr Callback_ModalListener(int code, IntPtr wParam, IntPtr lParam)
        {
            if (code == HCBT_ACTIVATE)
            {
                // Some controls sends an HCBT_ACTIVATE when changed for example tabPages. We do not 
                // want our handler to be called when a tabPage is changed. This is a problem in Modal
                // modal windows.
                bool b = true;
                if (hwndList.Contains(wParam))
                {
                    b = false;
                }

                if (b)
                {
                    hwndList.Add(wParam);
                    FindWindowNameAndInvokeHandler(wParam);
                }

            }
            if (code == HCBT_DESTROYWND)
            {
                // Need to remove the handle when the window is destroyed.
                
                if (hwndList.Contains(wParam))
                {
                    hwndList.Remove(wParam);
                }
            }

            return Win32.CallNextHookEx(handleToHook, code, wParam, lParam);
        }

        private void RemoveModal(IntPtr hwnd)
        {
            string name = null;

            Form form = Form.FromHandle(hwnd) as Form;
            if (form != null && form.Modal)
            {
                name = form.Name;
            }
            else if (WindowHandle.IsDialog(hwnd))
            {
                name = WindowHandle.GetCaption(hwnd);
                if (name == null)
                {
                    name = string.Empty;
                }
            }

        }
        private void FindWindowNameAndInvokeHandler(IntPtr hwnd)
        {
            string name = null;

            Form form = Form.FromHandle(hwnd) as Form;
            if (form != null && form.Modal)
            {

                name = form.Name;

            }
            else if (WindowHandle.IsDialog(hwnd))
            {
                name = WindowHandle.GetCaption(hwnd);
                if (name == null)
                {
                    name = string.Empty;
                }

            }

            Invoke(name, hwnd, form);
        }

        // Old interface compatibility
        

        ///<summary>
        /// Registers an expected handler for the given form caption.
        ///</summary>
        ///<param name="name">The caption of the form to handle.</param>
        ///<param name="handler">The handler.</param>
        [Obsolete]
        public void ExpectModal(string name, ModalFormActivated handler)
        {
            ExpectModal(name, handler, true);
        }

        ///<summary>
        /// Registers an expected or unexpected handler for the given form caption.
        ///</summary>
        ///<param name="name">The caption of the form to handle.</param>
        ///<param name="handler">The handler.</param>
        ///<param name="expected">True if this handler is expected; false if this handler is not expected.</param>
        [Obsolete]
        public void ExpectModal(string name, ModalFormActivated handler, bool expected)
        {
            this.FormHandler = Adapter;
            handlers[name] = new Handler(handler, (expected ? 1 : 0), name);
        }

        void Adapter(string name, IntPtr hWnd, Form f)
        {
            if (name == null) return;
            if (name == string.Empty) name = "Unnamed";
            // Vista 64 hack
            if (name == "Save as" || name == "Enregistrer sous") name = FileDialogTester.InitialFileDialogName;
            Handler namedHandler = handlers[name] as Handler;
            if (namedHandler == null)
            {
                namedHandler = Add(name, (ModalFormActivatedHwnd)
                                         Delegate.CreateDelegate(typeof(ModalFormActivatedHwnd), this,
                                                                 "UnexpectedModal"), 0);
            }
            namedHandler.Invoke(hWnd);
            this.FormHandler = Adapter;
        }

        ///<summary>
        /// Registers an expected or unexpected handler for the given form caption.
        ///</summary>
        ///<param name="name">The caption of the form to handle.</param>
        ///<param name="handler">The handler.</param>
        ///<param name="expectedCount">number of times this handler is expected</param>
        internal Handler Add(string name, ModalFormActivatedHwnd handler, int expectedCount)
        {
            Handler handlerObject = new Handler(handler, expectedCount, name);
            handlers[name] = handlerObject;
            return handlerObject;
        }


        /// <summary>
        /// A <see cref="ModalFormActivatedHwnd"/> that tries to click the OK button of the modal form.
        ///</summary>
        public void UnexpectedModal(IntPtr hWnd)
        {
            MessageBoxTester messageBox = new MessageBoxTester(hWnd);
            messageBox.ClickOk();
        }



        private readonly Hashtable handlers = new Hashtable();

        /// <summary>
        /// This class encapsulates a event handler
        /// along with information on whether it was
        /// expected to be called, and if it was actually called.
        /// </summary>
        internal class Handler
        {
            private readonly int expectedCount = 0;
            private readonly Delegate handler = null;
            private readonly string name;
            private int invokedCount = 0;

            /// <summary>
            /// Constructs a new <see cref="Handler"/>.
            /// </summary>
            public Handler(Delegate handler, int expectedTimes, string name)
            {
                this.handler = handler;
                expectedCount = expectedTimes;
                this.name = name;
            }

            public string Name
            {
                get { return name; }
            }

            /// <summary>
            /// Verify that this handler was either expected and invoked,
            /// or not expected and not invoked.
            /// </summary>
            public bool Verify()
            {
                return expectedCount == invokedCount;
            }

            /// <summary>
            /// Invokes the wrapped event handler with the given window handle.
            /// </summary>
            /// <param name="hWnd"></param>
            public void Invoke(IntPtr hWnd)
            {
                invokedCount++;
                try
                {
                    if (handler is ModalFormActivated)
                    {
                        handler.DynamicInvoke(new object[] { });
                    }
                    else if (handler is ModalFormActivatedHwnd)
                    {
                        handler.DynamicInvoke(new object[] { hWnd });
                    }
                }
                catch (TargetInvocationException ex)
                {
                    // Unwrap any exceptions that happen in the Reflection layer.
                    if (ex.InnerException != null)
                    {
                        throw ex.InnerException;
                    }
                }
            }


            public string GetError()
            {
                if (Verify())
                {
                    throw new InvalidOperationException("Don't call GetError when there are not errors");
                }
                return
                    string.Format("expected {0} invocations of modal, but was invoked {1} times", expectedCount,
                                  invokedCount);
            }
        }


    }
}