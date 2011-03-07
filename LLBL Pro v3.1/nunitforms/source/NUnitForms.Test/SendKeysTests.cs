#region Copyright (c) 2003-2007, Luke T. Maxon

/********************************************************************************************************************
'
' Copyright (c) 2003-2007, Luke T. Maxon
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
using NMock2;
using NUnit.Extensions.Forms.Win32Interop;
using NUnit.Framework;
using NUnit.Extensions.Forms.SendKey;

namespace NUnit.Extensions.Forms.UnitTests
{
	[TestFixture]
	public class SendKeysTests : MockingTestFixture
	{
        private AlternateSendKeys keyboardSendKeys;
		private ISendKeyboardInput keyboardInput;
		private ISendKeysParserFactory parserFactory;
		private ISendKeysParser parser;
	    private IntPtr window;

	    protected override void SetUp()
		{
			keyboardInput = NewMock<ISendKeyboardInput>();
			parserFactory = NewMock<ISendKeysParserFactory>();
			parser = NewMock<ISendKeysParser>();

	        window = new IntPtr(0x12345);
            keyboardSendKeys = new AlternateSendKeys(keyboardInput, parserFactory, window);
		}

		protected override void TearDown()
		{
			keyboardSendKeys.Dispose();
		}

		[Test]
		public void SendWait_SingleCharLowerCase()
		{
			StubFormatter("b", "b", "", VirtualKeyCodes.None);

			ExpectKeyDownAndRelease(VirtualKeyCodes.B);

			keyboardSendKeys.SendWait("b");
		}

		[Test]
		public void SendWait_SingleCharUpperCase()
		{
			StubFormatter("B", "B", "", VirtualKeyCodes.None);

			ExpectKeyDown(VirtualKeyCodes.SHIFT);
			ExpectKeyDownAndRelease(VirtualKeyCodes.B);
			ExpectKeyUp(VirtualKeyCodes.SHIFT);

			keyboardSendKeys.SendWait("B");
		}

		[Test]
		public void SendWait_ShiftFormatted()
		{
			StubFormatter("+(ab)", "ab", "+", VirtualKeyCodes.None);

			ExpectKeyDown(VirtualKeyCodes.SHIFT);
			ExpectKeyDownAndRelease(VirtualKeyCodes.A);
			ExpectKeyDownAndRelease(VirtualKeyCodes.B);
			ExpectKeyUp(VirtualKeyCodes.SHIFT);

			keyboardSendKeys.SendWait("+(ab)");
		}

		[Test]
		public void SendWait_ControlFormatted()
		{
			StubFormatter("^(ab)", "ab", "^", VirtualKeyCodes.None);

			ExpectKeyDown(VirtualKeyCodes.CONTROL);
			ExpectKeyDownAndRelease(VirtualKeyCodes.A);
			ExpectKeyDownAndRelease(VirtualKeyCodes.B);
			ExpectKeyUp(VirtualKeyCodes.CONTROL);

			keyboardSendKeys.SendWait("^(ab)");
		}

		[Test]
		public void SendWait_AltFormatted()
		{
			StubFormatter("%(ab)", "ab", "%", VirtualKeyCodes.None);

			ExpectKeyDown(VirtualKeyCodes.MENU);
			ExpectKeyDownAndRelease(VirtualKeyCodes.A);
			ExpectKeyDownAndRelease(VirtualKeyCodes.B);
			ExpectKeyUp(VirtualKeyCodes.MENU);

			keyboardSendKeys.SendWait("%(ab)");
		}

		[Test]
		public void SendWait_AltShiftControlFormatted()
		{
			StubFormatter("%+^(ab)", "ab", "%+^", VirtualKeyCodes.None);

			ExpectKeyDown(VirtualKeyCodes.MENU);
			ExpectKeyDown(VirtualKeyCodes.CONTROL);
			ExpectKeyDown(VirtualKeyCodes.SHIFT);

			ExpectKeyDownAndRelease(VirtualKeyCodes.A);
			ExpectKeyDownAndRelease(VirtualKeyCodes.B);

			ExpectKeyUp(VirtualKeyCodes.SHIFT);
			ExpectKeyUp(VirtualKeyCodes.CONTROL);
			ExpectKeyUp(VirtualKeyCodes.MENU);

			keyboardSendKeys.SendWait("%+^(ab)");
		}

		[Test]
		[Ignore("This test is keyboard layout dependent.")]
		public void SendWait_SimpleText()
		{
			StubFormatter("aA {{}1.", "aA {1.", "", VirtualKeyCodes.None);

			ExpectKeyDownAndRelease(VirtualKeyCodes.A);

			ExpectKeyDown(VirtualKeyCodes.SHIFT);
			ExpectKeyDownAndRelease(VirtualKeyCodes.A);
			ExpectKeyUp(VirtualKeyCodes.SHIFT);

			ExpectKeyDownAndRelease(VirtualKeyCodes.SPACE);

			// This will be keyboard layout dependent
			ExpectKeyDown(VirtualKeyCodes.SHIFT);
			ExpectKeyDownAndRelease(VirtualKeyCodes.OEM_4);	// '[' key shifted to give '{'
			ExpectKeyUp(VirtualKeyCodes.SHIFT);

			ExpectKeyDownAndRelease(VirtualKeyCodes.DIGIT_1);
			ExpectKeyDownAndRelease(VirtualKeyCodes.OEM_PERIOD);

			keyboardSendKeys.SendWait("aA {{}1.");
		}

		private void ExpectKeyDown(VirtualKeyCodes keyCode)
		{
			Expect.Once.On(keyboardInput).Method("SendInput").With(window, keyCode, SendInputFlags.KeyDown);
		}

		private void ExpectKeyUp(VirtualKeyCodes keyCode)
		{
			Expect.Once.On(keyboardInput).Method("SendInput").With(window, keyCode, SendInputFlags.KeyUp);
		}

		private void ExpectKeyDownAndRelease(VirtualKeyCodes keyCode)
		{
            Expect.Once.On(keyboardInput).Method("SendInput").With(window, keyCode, SendInputFlags.KeyDown);
            Expect.Once.On(keyboardInput).Method("SendInput").With(window, keyCode, SendInputFlags.KeyUp);
		}

		private void StubFormatter(string rawText, string body, string modifiers, VirtualKeyCodes escapedKeys)
		{
			Stub.On(parserFactory).Method("Create").With(rawText).Will(Return.Value(parser));

			ISendKeysParserGroup group = NewMock<ISendKeysParserGroup>();
			Stub.On(group).GetProperty("ModifierCharacters").Will(Return.Value(modifiers));
			Stub.On(group).GetProperty("EscapedKey").Will(Return.Value(escapedKeys));
			Stub.On(group).GetProperty("Body").Will(Return.Value(body));

			Stub.On(parser).GetProperty("Groups").Will(Return.Value(new ISendKeysParserGroup[] { group }));
		}
	}
}
