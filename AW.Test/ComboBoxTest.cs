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

using AW.Test.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Extensions.Forms;
using NUnit.Extensions.Forms.TestApplications;

namespace AW.Tests
{
  [TestClass]
  public class ComboBoxTest : NUnitFormMSTest
  {
    private ComboBoxTester _box;

    public override void Setup()
    {
      new ComboBoxTestForm().Show();
      _box = new ComboBoxTester("myComboBox");
    }

    [TestMethod]
    public void MethodInvokeOnControlTester()
    {
      var foundIndex = _box.Invoke("FindStringExact", "three");
      Assert.AreEqual(2, foundIndex);
    }

    [TestMethod]
    public void Select()
    {
      _box.Select(2);
      Assert.AreEqual("three", _box.Text);
    }

    [TestMethod]
    [ExpectedException(typeof (FormsTestAssertionException))]
    //    ExpectedMessage = "Could not find text 'not-in-the-box' in ComboBox 'myComboBox'")]
    public void SelectByBadText()
    {
      _box.Select("not-in-the-box");
    }

    [TestMethod]
    public void SelectByText()
    {
      _box.Select("three");
      Assert.AreEqual("three", _box.Text);
    }

    [TestMethod]
    public void TextBox()
    {
      Assert.AreEqual("None", _box.Text);
      _box.Enter("Text");
      Assert.AreEqual("Text", _box.Text);
    }
  }
}