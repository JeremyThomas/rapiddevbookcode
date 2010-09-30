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
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
	[TestFixture]
	[Category("DisplayHidden")]
	[Category("ControlsKeyboard")]
    [Ignore("They all fail on my systems. Planning to investigate.")]
	public class SimpleAPIKeyboardTest : NUnitFormTest
	{
		public override bool DisplayHidden
		{
			get { return true; }
		}

		[Test]
		public void PressEnterClicksButton()
		{
			Form form = new ButtonTestForm();
			form.Show();
			LabelTester label = new LabelTester("myLabel", form);
			ButtonTester button = new ButtonTester("myButton", form);

			Assert.AreEqual("0", label.Text);

			Keyboard.UseOn(button);
			Keyboard.Click(Key.RETURN);

			Assert.AreEqual("1", label.Text);
		}

		[Test]
		public void TextBox()
		{
			Form form = new TextBoxTestForm();
			form.Show();

			TextBoxTester box = new TextBoxTester("myTextBox", form);
			Assert.AreEqual("default", box.Text);

			Keyboard.UseOn(box);

			Keyboard.Click(Key.A);
			Keyboard.Click(Key.B);
			Keyboard.Click("+(c)");
			Keyboard.Click("C");

			Assert.AreEqual("abCC", box.Text);
		}

		[Test]
		public void TypeShiftAB()
		{
			new TextBoxTestForm().Show();
			TextBoxTester box = new TextBoxTester("myTextBox");
			Assert.AreEqual("default", box.Text);

			Keyboard.UseOn(box);

			Keyboard.Type("+ab");

			Assert.AreEqual("Ab", box.Text);
		}

		[Test]
		public void TypeSpecialKey()
		{
			new TextBoxTestForm().Show();
			TextBoxTester box = new TextBoxTester("myTextBox");
			Assert.AreEqual("default", box.Text);

			Keyboard.UseOn(box);

			Keyboard.Type("abc1def ghi");

			Assert.AreEqual("abc1def ghi", box.Text);
		}

		[Test]
		public void ReplaceOneWithDIGIT_1WhenNotInBraces()
		{
			new TextBoxTestForm().Show();
			TextBoxTester box = new TextBoxTester("myTextBox");
			Assert.AreEqual("default", box.Text);

			Keyboard.UseOn(box);

			Keyboard.Type("1231");

			Assert.AreEqual("1231", box.Text);
		}

		[Test]
		public void ToUpper()
		{
			new TextBoxTestForm().Show();
			TextBoxTester box = new TextBoxTester("myTextBox");
			Assert.AreEqual("default", box.Text);

			Keyboard.UseOn(box);

			Keyboard.Type("a");

			Assert.AreEqual("a", box.Text);
		}

		[Test]
		public void TypeShiftAGroup()
		{
			new TextBoxTestForm().Show();
			TextBoxTester box = new TextBoxTester("myTextBox");
			Assert.AreEqual("default", box.Text);

			Keyboard.UseOn(box);

			Keyboard.Type("q+(ABC)d");

			Assert.AreEqual("qABCd", box.Text);
		}

		[Test]
		[Ignore("This test leaves keyboard controller in a shift state affecting following test.")]
		[ExpectedException(typeof (ArgumentException))]
		public void UnbalancedGroupDelimitersThrowsException()
		{
			new TextBoxTestForm().Show();
			TextBoxTester box = new TextBoxTester("myTextBox");
			Assert.AreEqual("default", box.Text);

			Keyboard.UseOn(box);

			Keyboard.Click(Key.A);
			Keyboard.Press(Key.SHIFT);
		}

		[Test]
		public void KeyDefinitions_ShiftAndRelease()
		{
			new TextBoxTestForm().Show();
			TextBoxTester box = new TextBoxTester("myTextBox");

			Keyboard.UseOn(box);

			Keyboard.Click(Key.A);
			Keyboard.Click(Key.B);
			Keyboard.Press(Key.SHIFT + Key.C + Key.SHIFT_RELEASE);

			Assert.AreEqual("abC", box.Text);
		}
	}
}