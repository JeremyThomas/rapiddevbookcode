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

using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    [TestFixture]
    public class ModalFormsTestWithoutBaseClassTest
    {
        //this is a working test by itself, but it is not on hidden desktop without base class.
        //so i called this method from another test that uses the desktop
        //[Test]
        public void ModalFormExample()
        {
            using (ModalFormTester tester = new ModalFormTester())
            {
                tester.FormHandler = ModalFormHandler;

                //using (ModalMultiForm form = new ModalMultiForm())
                //{
                //    ////    form.Show();

                //    ////    new ButtonTester("myButton", "Form").Click();

                //    ////    form.Close();                        
                //}
            }
        }

        public void ModalFormHandler(string name, System.IntPtr hWnd, System.Windows.Forms.Form form)
        {
            ButtonTester btnClose = new ButtonTester("btnClose", "Form-0");
            btnClose.Click();
        }

        //[Test]
        public void CompleteExampleWithoutBaseClass() //still not promising to clean up EVERYTHING
        {
            using (new Desktop())
            {
                using (new FormTester("Form"))
                {
                    using (ModalFormTester modalTester = new ModalFormTester())
                    {
                        modalTester.FormHandler = ModalFormHandler;
                        new ModalMultiForm().Show();
                        new ButtonTester("myButton", "Form").Click();
                    }
                }
            }
        }

        [Test]
        public void AnExampleOnAHiddenDesktopWithoutBaseClass()
        {
            using (new Desktop())
            {
                ModalFormExample();
            }
        }
    }
}