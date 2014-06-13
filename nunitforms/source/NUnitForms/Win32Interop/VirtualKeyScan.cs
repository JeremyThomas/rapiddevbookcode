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
' LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES, LOSS OF USE, DATA, OR PROFITS, OR BUSINESS
' INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
' OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN
' IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'
'*******************************************************************************************************************/

#endregion

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace NUnit.Extensions.Forms.Win32Interop
{
	internal class VirtualKeyScan
	{
		private readonly short scanCode;

		public VirtualKeyScan(char character)
		{
			scanCode = VkKeyScan(character);
		}

		public VirtualKeyCodes KeyCodesCode
		{
			get { return (VirtualKeyCodes)(scanCode & 0x00ff); }
		}

		public VirtualKeyCodes[] GetShiftKeys()
		{
			VirtualKeyScanShiftCodes shiftCodes = (VirtualKeyScanShiftCodes)(scanCode & 0xff00);

			List<VirtualKeyCodes> shiftKeys = new List<VirtualKeyCodes>();
			if ((shiftCodes & VirtualKeyScanShiftCodes.Alt) != 0)
			{
				shiftKeys.Add(VirtualKeyCodes.MENU);
			}
			if ((shiftCodes & VirtualKeyScanShiftCodes.Control) != 0)
			{
				shiftKeys.Add(VirtualKeyCodes.CONTROL);
			}
			if ((shiftCodes & VirtualKeyScanShiftCodes.Shift) != 0)
			{
				shiftKeys.Add(VirtualKeyCodes.SHIFT);
			}

			return shiftKeys.ToArray();
		}

		[Flags]
		private enum VirtualKeyScanShiftCodes
		{
			Shift = 0x0100, // Either SHIFT key is pressed.
			Control = 0x0200, // Either CTRL key is pressed.
			Alt = 0x0400, // Either ALT key is pressed.
		}

		[DllImport("user32.dll")]
		private static extern short VkKeyScan(char ch);
	}
}
