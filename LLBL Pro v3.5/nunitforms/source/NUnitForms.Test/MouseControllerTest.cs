#region Copyright (c) 2003-2005, Luke T. Maxon (Richard Schneider is the original author)

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
using System.Drawing;
using System.Windows.Forms;
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    /// <summary>
    ///   Tests the <see cref="MouseController"/>.
    /// </summary>
    [TestFixture]
    [Category("DisplayHidden")]
    [Category("ControlsMouse")]
    [Ignore()]
    public class MouseControllerTest : NUnitFormTest
    {
        private Form CurrentForm;

        public override void Setup()
        {
            CurrentForm = new TextBoxTestForm();
            CurrentForm.Show();
        }

        public override bool DisplayHidden
        {
            get { return true; }
        }

        private int enter;

        private int leave;

        private int move;

        private void OnMouseEnter(object sender, EventArgs e)
        {
            ++enter;
        }

        private void OnMouseLeave(object sender, EventArgs e)
        {
            ++leave;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            ++move;
        }

        private int hover;


        private int up;

        private int down;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            ++down;
        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            ++up;
        }

        private int click;

        private void OnClick(object sender, EventArgs e)
        {
            ++click;
        }

        private int doubleClick;

        private void OnDoubleClick(object sender, EventArgs e)
        {
            ++doubleClick;
        }

        private int drag;

        private int lastX;

        private int lastY;

        private void OnDrag(object sender, MouseEventArgs e)
        {
            if (lastX != e.X || lastY != e.Y)
            {
                Assert.AreEqual(lastX + 1, e.X);
                Assert.AreEqual(lastY + 1, e.Y);
                ++drag;
                lastX = e.X;
                lastY = e.Y;
            }
        }

        [Test]
        public void ButtonEvents()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            CurrentForm.MouseDown += new MouseEventHandler(OnMouseDown);
            CurrentForm.MouseUp += new MouseEventHandler(OnMouseUp);

            down = 0;
            up = 0;
            Mouse.UseOn(formTester);
            Mouse.Press(MouseButtons.Left);
            Assert.AreEqual(1, down);
            Assert.AreEqual(0, up);

            Mouse.Release(MouseButtons.Left);
            Assert.AreEqual(1, down);
            Assert.AreEqual(1, up);
        }

        [Test]
        public void Buttons()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.UseOn(formTester);
            Mouse.Press(MouseButtons.Left);
            Assert.AreEqual(MouseButtons.Left, Control.MouseButtons);

            Mouse.Release(MouseButtons.Left);
            Assert.AreEqual(MouseButtons.None, Control.MouseButtons);

            Mouse.Press(MouseButtons.Right);
            Assert.AreEqual(MouseButtons.Right, Control.MouseButtons);

            Mouse.Release(MouseButtons.Right);
            Assert.AreEqual(MouseButtons.None, Control.MouseButtons);

            Mouse.Press(MouseButtons.Middle);
            Assert.AreEqual(MouseButtons.Middle, Control.MouseButtons);

            Mouse.Release(MouseButtons.Middle);
            Assert.AreEqual(MouseButtons.None, Control.MouseButtons);
        }

        [Test]
        public void Clicking()
        {
            TextBoxTester textBox = new TextBoxTester("myTextBox", CurrentForm);
            textBox.Properties.Click += new EventHandler(OnClick);
            textBox.Properties.MouseDown += new MouseEventHandler(OnMouseDown);
            textBox.Properties.MouseUp += new MouseEventHandler(OnMouseUp);
            Mouse.UseOn(textBox);
            down = 0;
            up = 0;
            click = 0;
            Mouse.Click(1, 3);
            Assert.AreEqual(1, down);
            Assert.AreEqual(1, up);
            Assert.AreEqual(1, click);
        }

        [Test]
        public void Disposing()
        {
            Point originalPosition = Control.MousePosition;
            MouseButtons originalButtons = Control.MouseButtons;
            Keys originalModifiers = Control.ModifierKeys;

            TextBoxTester textBox = new TextBoxTester("myTextBox", CurrentForm);
            Mouse.UseOn(textBox);
            Mouse.Position = new PointF(10, 10);
            Mouse.Press(MouseButtons.Middle);
            Mouse.Press(Keys.Shift);

            Assert.AreEqual(originalPosition, Control.MousePosition);
            Assert.AreEqual(originalButtons, Control.MouseButtons);
            Assert.AreEqual(originalModifiers, Control.ModifierKeys);
        }

        [Test]
        public void DoubleClicking()
        {
            TextBoxTester textBox = new TextBoxTester("myTextBox", CurrentForm);
            textBox.Properties.DoubleClick += new EventHandler(OnDoubleClick);
            doubleClick = 0;
            Mouse.UseOn(textBox);
            Mouse.DoubleClick(1, 3);

            Assert.AreEqual(1, doubleClick);
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void DragEmpty()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.Drag(new PointF(0, 0), new PointF[0]);
        }

        [Test]
        public void Dragging()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            CurrentForm.MouseMove += new MouseEventHandler(OnDrag);

            drag = 0;
            lastX = -1;
            lastY = -1;
            Mouse.Drag(new PointF(0, 0), new PointF(1, 1), new PointF(2, 2));
            Assert.AreEqual(3, drag);

            drag = 0;
            lastX = -1;
            lastY = -1;
            Mouse.Drag(0, 0, 1, 1, 2, 2);
            Assert.AreEqual(3, drag);
        }

        [Test]
        [ExpectedException(typeof (ArgumentNullException))]
        public void DragNull()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.Drag(new PointF(0, 0), null);
        }

        [Test]
        [ExpectedException(typeof (ArgumentException))]
        public void DragOdd()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.Drag(0, 0, 100, 100, 200);
        }

        [Test]
        public void Hovering()
        {
            TextBoxTester textBox = new TextBoxTester("myTextBox", CurrentForm);
            textBox.Properties.MouseHover += delegate { ++hover; };

            hover = 0;

            Mouse.Hover();
            Assert.AreEqual(1, hover);

            Mouse.Hover();
            Assert.AreEqual(2, hover);

            Mouse.Hover(1, 2);
            Assert.AreEqual(3, hover);
            Assert.AreEqual(new Point(1, 2), textBox.Properties.PointToClient(Control.MousePosition));

            Mouse.Hover(new PointF(1, 3));
            Assert.AreEqual(4, hover);
            Assert.AreEqual(new Point(1, 3), textBox.Properties.PointToClient(Control.MousePosition));
        }

        [Test]
        [ExpectedException(typeof (NoSuchControlException))]
        public void MissingControl()
        {
            Mouse.UseOn(new ControlTester("unknownTextBox"));
            Mouse.Position = new PointF(1, 1);
        }

        [Test]
        [Ignore("")]
        public void Modifiers()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);

            Mouse.Press(Keys.Alt);
            Assert.AreEqual(Keys.Alt, Control.ModifierKeys);
            Mouse.Release(Keys.Alt);
            Assert.AreEqual(Keys.None, Control.ModifierKeys);

            Mouse.Press(Keys.Shift);
            Assert.AreEqual(Keys.Shift, Control.ModifierKeys);
            Mouse.Release(Keys.Shift);
            Assert.AreEqual(Keys.None, Control.ModifierKeys);

            Mouse.Press(Keys.Control);
            Assert.AreEqual(Keys.Control, Control.ModifierKeys);
            Mouse.Release(Keys.Control);
            Assert.AreEqual(Keys.None, Control.ModifierKeys);

            Mouse.Press(Keys.Control | Keys.Alt | Keys.Shift);
            Assert.AreEqual(Keys.Control | Keys.Alt | Keys.Shift, Control.ModifierKeys);
            Mouse.Release(Keys.Control | Keys.Alt | Keys.Shift);
            Assert.AreEqual(Keys.None, Control.ModifierKeys);
        }

        [Test]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void ModifiersInvalid1()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.Press(Keys.A);
        }

        [Test]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void ModifiersInvalid2()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.Release(Keys.A);
        }

        [Test]
        public void PositioningEvents()
        {
            TextBoxTester textBox = new TextBoxTester("myTextBox", CurrentForm);
            textBox.Properties.MouseEnter += new EventHandler(OnMouseEnter);
            textBox.Properties.MouseLeave += new EventHandler(OnMouseLeave);
            textBox.Properties.MouseMove += new MouseEventHandler(OnMouseMove);

            enter = 0;
            leave = 0;
            move = 0;

            Mouse.Position = new PointF(1, 1);
            Assert.AreEqual(1, enter);
            Assert.AreEqual(0, leave);
            Assert.AreEqual(1, move);

            Mouse.Position = new PointF(1, 2);
            Assert.AreEqual(1, enter);
            Assert.AreEqual(0, leave);
            Assert.AreEqual(2, move);

            Mouse.Position = (Point) textBox.Properties.Size + new Size(1, 1);
            Assert.AreEqual(1, enter);
            Assert.AreEqual(1, leave);
            Assert.AreEqual(2, move);
        }

        [Test]
        public void PositioningInControl()
        {
            TextBoxTester textBox = new TextBoxTester("myTextBox", CurrentForm);

            Mouse.Position = new PointF(1, 1);
            Assert.AreEqual(new PointF(1, 1), Mouse.Position);

            Assert.AreEqual(textBox.Properties.PointToScreen(new Point(1, 1)), Control.MousePosition);
        }

        [Test]
        public void PositioningInForm()
        {
            Mouse.UseOn(new FormTester(CurrentForm.Name));
            Mouse.Position = new PointF(10, 10);
            Assert.AreEqual(new PointF(10, 10), Mouse.Position);
            Assert.AreEqual(CurrentForm.PointToScreen(new Point(10, 10)), Control.MousePosition);
        }

        [Test]
        public void PositioningUnits()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.UseOn(formTester);
            int dpiX, dpiY;
            using (Graphics graphics = CurrentForm.CreateGraphics())
            {
                dpiX = (int) graphics.DpiX;
                dpiY = (int) graphics.DpiY;
            }
            Point targetPoint = CurrentForm.PointToScreen(new Point(dpiX, 2*dpiY));

            Mouse.PositionUnit = GraphicsUnit.Pixel;
            Mouse.Position = new PointF(10, 10);
            Assert.AreEqual(new PointF(10, 10), Mouse.Position);
            Assert.AreEqual(CurrentForm.PointToScreen(new Point(10, 10)), Control.MousePosition);

            Mouse.PositionUnit = GraphicsUnit.Display;
            Mouse.Position = new PointF(75, 150);
            Assert.AreEqual(new PointF(75, 150), Mouse.Position);
            Assert.AreEqual(targetPoint, Control.MousePosition);

            Mouse.PositionUnit = GraphicsUnit.Document;
            Mouse.Position = new PointF(300, 600);
            Assert.AreEqual(new PointF(300, 600), Mouse.Position);
            Assert.AreEqual(targetPoint, Control.MousePosition);

            Mouse.PositionUnit = GraphicsUnit.Inch;
            Mouse.Position = new PointF(1, 2);
            Assert.AreEqual(new PointF(1, 2), Mouse.Position);
            Assert.AreEqual(targetPoint, Control.MousePosition);

            Mouse.PositionUnit = GraphicsUnit.Point;
            Mouse.Position = new PointF(72, 144);
            Assert.AreEqual(new PointF(72, 144), Mouse.Position);
            Assert.AreEqual(targetPoint, Control.MousePosition);

            Mouse.PositionUnit = GraphicsUnit.Millimeter;
            Mouse.Position = new PointF(25.40f, 50.80F);
            Assert.AreEqual(new PointF(25.40f, 50.80F), Mouse.Position);
            Assert.AreEqual(targetPoint, Control.MousePosition);
        }

        [Test]
        [ExpectedException(typeof (NotSupportedException))]
        public void PositioningUnitsWorld()
        {
            Mouse.UseOn(new FormTester(CurrentForm.Name));
            Mouse.PositionUnit = GraphicsUnit.World;
        }

        [Test]
        public void XButtonEvents()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            CurrentForm.MouseDown += new MouseEventHandler(OnMouseDown);
            CurrentForm.MouseUp += new MouseEventHandler(OnMouseUp);
            Mouse.UseOn(formTester);
            down = 0;
            up = 0;
            if (SystemInformation.MouseButtons > 3)
            {
                Mouse.Press(MouseButtons.XButton1);
                Assert.AreEqual(1, down);
                Assert.AreEqual(0, up);
            }

            if (SystemInformation.MouseButtons > 4)
            {
                Mouse.Release(MouseButtons.Left);
                Assert.AreEqual(1, down);
                Assert.AreEqual(1, up);
            }
        }

        [Test]
        public void XButtons()
        {
            FormTester formTester = new FormTester(CurrentForm.Name);
            Mouse.UseOn(formTester);
            if (SystemInformation.MouseButtons > 3)
            {
                Mouse.Press(MouseButtons.XButton1);
                Assert.AreEqual(MouseButtons.XButton1, Control.MouseButtons);
                Mouse.Press(MouseButtons.XButton2);
                Assert.AreEqual(MouseButtons.XButton1 | MouseButtons.XButton2, Control.MouseButtons);
            }

            if (SystemInformation.MouseButtons > 3)
            {
                Mouse.Release(MouseButtons.XButton2);
                Assert.AreEqual(MouseButtons.XButton1, Control.MouseButtons);

                Mouse.Release(MouseButtons.XButton1);
                Assert.AreEqual(MouseButtons.None, Control.MouseButtons);
            }
        }
    }
}