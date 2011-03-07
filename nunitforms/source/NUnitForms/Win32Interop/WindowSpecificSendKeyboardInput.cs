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
using System.Threading;
using System.Windows.Forms;


namespace NUnit.Extensions.Forms.Win32Interop
{
    public class WindowSpecificSendKeyboardInput : ISendKeyboardInput
    {
        private readonly byte[] keybstate = new byte[256];
        private readonly IntPtr layout;
        private bool altPressed = false;

        public WindowSpecificSendKeyboardInput()
        {
            layout = Win32.GetKeyboardLayout(Win32.GetCurrentThreadId());
            Win32.GetKeyboardState(keybstate);
        }

        public void SendInput(IntPtr window, VirtualKeyCodes keyCodes, SendInputFlags flags)
        {
            if (keyCodes == VirtualKeyCodes.MENU) altPressed = (flags == SendInputFlags.KeyDown);
            SetKeyState(keybstate, keyCodes, flags);
            if (flags == SendInputFlags.KeyDown)
            {
                PostKeyDown(window, keyCodes);
            }
            else
            {
                PostKeyUp(window, keyCodes);
            }
            Application.DoEvents();
            Thread.Sleep(1);
        }

        private static void SetKeyState(byte[] keybstate, VirtualKeyCodes key, SendInputFlags flag)
        {
            keybstate[(int) key] = (byte) (flag == SendInputFlags.KeyDown ? 0x80 : 0x00);
            Win32.SetKeyboardState(keybstate);
        }

        private void PostKeyDown(IntPtr hWnd, VirtualKeyCodes key)
        {
            uint code = Win32.MapVirtualKeyEx((uint) key, 0, layout);
            uint message = (altPressed ? Win32.WM_SYSKEYDOWN : Win32.WM_KEYDOWN);
            uint lParam = 0x00000001 + (code << 16);
            if (altPressed) lParam |= 0x20000000;
            Win32.PostMessage(hWnd, message, (int) key, lParam);
        }

        private void PostKeyUp(IntPtr hWnd, VirtualKeyCodes key)
        {
            uint code = Win32.MapVirtualKeyEx((uint) key, 0, layout);
            uint message = (altPressed && key != VirtualKeyCodes.MENU ? Win32.WM_SYSKEYUP : Win32.WM_KEYUP);
            uint lParam = 0xC0000001 + (code << 16);
            if (altPressed) lParam |= 0xF0000000;
            Win32.PostMessage(hWnd, message, (int) key, lParam);
        }
    }
}