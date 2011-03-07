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

using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    public class ControlTester<T, TThis> : Tester<T, TThis>
        where T : Control
        where TThis : Tester<T, TThis>, new()
    {
        public ControlTester()
        {
        }

        public ControlTester(string name, string formName) : base(name, formName)
        {
        }

        public ControlTester(string name, Form form) : base(name, form)
        {
        }

        public ControlTester(string name) : base(name)
        {
        }

        public ControlTester(ControlTester<T, TThis> tester, int index) : base(tester, index)
        {
        }

        /// <summary>
        /// Convenience method retrieves the Text property of the tested control.
        /// </summary>
        public virtual string Text
        {
            get { return Properties.Text; }
        }

        /// <summary>
        /// Convenience method "Clicks" on the control being tested if it is visible
        /// and enabled.
        /// </summary>
        public virtual void Click()
        {
            if (!Properties.Visible)
            {
                throw new ControlNotVisibleException(name);
            }
            if (!Properties.Enabled)
            {
                throw new ControlNotEnabledException(name);
            }
            FireEvent("Click");
        }

        /// <summary>
        /// Convenience method "DoubleClicks" on the control being tested if it is visible.
        /// </summary>
        /// <exception>
        /// ControlNotVisibleException is thrown if the Control is not Visible.
        /// </exception>
        public virtual void DoubleClick()
        {
            if (!Properties.Visible)
                throw new ControlNotVisibleException(name);
            FireEvent("DoubleClick");
        }

        /// <summary>
        /// Default handler for entering text into a text control.
        /// Must be exposed publically by testers that want to use it.
        /// </summary>
        protected virtual void EnterText(string text)
        {
            FireEvent("Enter");
            Properties.Text = text;
            FireEvent("Leave");

            EndCurrentEdit("Text");
        }

        /// <summary>
        /// Should call this method after editing something in order to trigger any
        /// databinding done with the Databindings collection.  (ie text box to a data
        /// set)
        /// </summary>
        public void EndCurrentEdit(string propertyName)
        {
            if (Properties.DataBindings[propertyName] != null)
            {
                Properties.DataBindings[propertyName].BindingManagerBase.EndCurrentEdit();
            }
        }

        /// <summary>
        /// Calls EndCurrentEdit on this control's data binding for the given property.
        /// </summary>
        /// <param name="propertyName"></param>
        protected override void DoAfterSetProperty(string propertyName)
        {
            EndCurrentEdit(propertyName);
        }
    }
}