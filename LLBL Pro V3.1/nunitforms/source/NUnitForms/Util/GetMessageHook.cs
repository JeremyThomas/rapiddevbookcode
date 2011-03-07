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
using System.Collections.Generic;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.Util
{
    /// <summary>
    /// Installs a GetMessageHook, and maintains a list of user supplied callbacks.
    /// Every time the hook is run, all the callbacks are run, and those that returned true are discarded.
    /// When a callback is recorded, or when the list of callbacks is not empy after a run, a message is
    /// posted to the current thread to ensure that the recorded callbacks will be run. Of course one should
    /// be wary of infinite loops.
    /// 
    /// Due to the static design, this class will not work in the case of multiple UI threads,
    /// each operating a message pump. If this is a concern, it should be feasible to modify it.
    /// </summary>
    public class GetMessageHook
    {
        ///// <returns>true to keep the callback, false to remove it</returns>
        public delegate bool Callback();
        static int msgid;

        static private Win32.MSGCallback callback = null;
        static private IntPtr handleToHook = IntPtr.Zero;

        ///// <summary>
        ///// Called at test setup by NUnitFormTest
        ///// </summary>
        public static void InstallHook()
        {
            msgid = Win32.RegisterWindowMessage("NUnitForms Callback");
            callbacks = new List<Callback>();
            callback = ProcessCallbacks;

            handleToHook = Win32.SetMSGWindowsHookEx(3, callback, IntPtr.Zero, Win32.GetCurrentThreadId());
        }

        /// <summary>
        /// Called at test teardown by NUnitFormTest
        /// </summary>
        public static void RemoveHook()
        {
            Win32.UnhookWindowsHookEx(handleToHook);
        }

        static List<Callback> callbacks;

        public static void Record(Callback c)
        {
            bool wasEmpty = callbacks.Count == 0;
            callbacks.Add(c);
            if (wasEmpty) Post();

        }

        static void Post()
        {
            Win32.PostThreadMessage((uint)Win32.GetCurrentThreadId(), (uint)msgid, UIntPtr.Zero, IntPtr.Zero);
        }

        static IntPtr ProcessCallbacks(int code, IntPtr wParam, ref System.Windows.Forms.Message lParam)
        {
            if (code >= 0 && lParam.Msg == msgid)
            {

                List<Callback> tmp = callbacks;
                callbacks = new List<Callback>();
                foreach (Callback c in tmp)
                {
                    if (!c()) callbacks.Add(c);

                }
                if (callbacks.Count > 0) Post();

            }
            return Win32.CallNextMSGHookEx(handleToHook, code, wParam, ref lParam);

        }
    }
}
