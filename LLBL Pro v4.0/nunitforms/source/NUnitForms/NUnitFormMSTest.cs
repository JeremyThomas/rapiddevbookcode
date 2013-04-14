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
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Extensions.Forms.SendKey;
using NUnit.Extensions.Forms.Util;
using NUnit.Extensions.Forms.Win32Interop;

namespace NUnit.Extensions.Forms
{
	/// <summary>
	/// One of three base classes for your NUnitForms tests.  This one can be
	/// used by people who do not need or want "built-in" Assert functionality.
	///
	/// This is the recommended base class for all unit tests that use NUnitForms.  
	/// </summary>
	/// <remarks>
	/// You should probably extend this class to create all of your test fixtures.  The benefit is that
	/// this class implements setup and teardown methods that clean up after your test.  Any forms that
	/// are created and displayed during your test are cleaned up by the tear down method.  This base
	/// class also provides easy access to keyboard and mouse controllers.  It has a method that allows
	/// you to set up a handler for modal dialog boxes.  It allows your tests to run on a separate 
	/// (usually hidden) desktop so that they are faster and do not interfere with your normal desktop
	/// activity.  If you want custom setup and teardown behavior, you should override the virtual 
	/// Setup and TearDown methods.  Do not use the setup and teardown attributes in your child class.
	/// </remarks>
	public class NUnitFormMSTest
	{
		private static readonly FieldInfo IsUserInteractive =
			typeof (SystemInformation).GetField("isUserInteractive", BindingFlags.Static | BindingFlags.NonPublic);

		private ModalFormTester _modal;

		private Desktop _testDesktop;

		/// <summary>
		/// True if the modal handlers for this test have been verified; else false.
		/// </summary>
		/// <remarks>
		/// It would be better form to make this private and provide a protected getter property, though
		/// that could break existing tests.
		/// </remarks>
		protected bool Verified;

		/// <summary>
		/// This property controls whether the separate hidden desktop is displayed for the duration of
		/// this test.  You will need to override and return true from this property if your test makes
		/// use of the keyboard or mouse controllers.  (The hidden desktop cannot accept user input.)  For
		/// tests that do not use the keyboard and mouse controller (most should not) you don't need to do
		/// anything with this.  The default behavior is fine.
		/// </summary>
		public virtual bool DisplayHidden
		{
			get { return false; }
		}

		/// <summary>
		/// This property controls whether a separate desktop is used at all. Tests on the separate desktop
		/// are faster and safer (there is no danger of keyboard or mouse input going to your own separate 
		/// running applications).  However, it fails on some systems; also, it is not possible to unlock 
		/// by hand a blocked test (e.g. due to a modal form). In order to enable it, you can override
		/// this method from your test class to return true. Or you can set an environment variable called
		/// "UseHiddenDesktop" and set that to "true".
		/// </summary>
		public virtual bool UseHidden
		{
			get
			{
				var useHiddenDesktop = Environment.GetEnvironmentVariable("UseHiddenDesktop");
				if (useHiddenDesktop != null && useHiddenDesktop.ToUpper().Equals("TRUE"))
				{
					return true;
				}
				return false;
			}
		}

		/// <summary>
		/// Returns a reference to the current MouseController for doing Mouse tests.  I recommend
		/// this only when you are writing your own custom controls and need to respond to actual
		/// mouse input to test them properly.  In most other cases there is a better way to test
		/// the form's logic.
		/// </summary>
		public MouseController Mouse { get; private set; }

		/// <summary>
		/// Returns a reference to the current KeyboardController for doing Keyboard tests.  I recommend
		/// this only when you are writing your own custom controls and need to respond to actual
		/// keyboard input to test them properly.  In most other cases there is a better way to test
		/// for the form's logic.
		/// </summary>
		public KeyboardController Keyboard { get; private set; }

		/// <summary>
		/// Records a single shot modal form handler. The handler receives as arguments the title of the window,
		/// its handle, and the corresponding form (null if it is not a form, i.e. a dialog box). The handler is
		/// single shot: it is removed after being run; therefore, if it is expected to trigger a new modal form,
		/// it should install a new handler before returning. The handler can work on dialog boxes by creating
		/// a message box tester or file dialog tester, passing the handle of the box (its second argument) to the
		/// tester's constructor. The tester constructors taking as argument the box title are unreliable and deprecated.
		/// </summary>
		public ModalFormHandler ModalFormHandler
		{
			get { return _modal.FormHandler; }
			set { _modal.FormHandler = value; }
		}

		/// <summary>
		/// Shorter version of ModalFormHandler without the form argument; meant for dialogs.
		/// </summary>
		public DialogBoxHandler DialogBoxHandler
		{
			set
			{
				if (value == null)
				{
					ModalFormHandler = null;
					return;
				}
				ModalFormHandler = delegate(string name, IntPtr hWnd, Form form) { value(name, hWnd); };
			}
		}


		/// <summary>
		/// This is the base classes setup method.  It will be called by NUnit before each test.
		/// You should not have anything to do with it.
		/// </summary>
		[TestInitialize]
		public void Init()
		{
			Verified = false;


			if (!SystemInformation.UserInteractive)
			{
				IsUserInteractive.SetValue(null, true);
			}

			if (UseHidden)
			{
				_testDesktop = new Desktop("NUnitForms Test Desktop", DisplayHidden);
			}

			_modal = new ModalFormTester();
			Mouse = new MouseController();
			Keyboard = new KeyboardController(new OldSendKeysFactory());
			GetMessageHook.InstallHook();
			Setup();
		}

		/// <summary>
		/// A patch method to allow migration to an alternative SendKeys class instead
		/// of the dot Net SendKeys class. Once the new class is completed this method
		/// will be replaced by a method to allow use of the dot Net class.
		/// 
		/// This method must only be called at the start of the test fixture's overriden
		/// SetUp().
		/// </summary>
		protected void EmulateSendKeys()
		{
			Keyboard =
				new KeyboardController(new SendKeysFactory(new SendKeysParserFactory(), new SendKeyboardInput()));
		}

		/// <summary>
		/// A patch method to allow migration to an alternative SendKeys class instead
		/// of the dot Net SendKeys class. Once the new class is completed this method
		/// will be replaced by a method to allow use of the dot Net class.
		/// 
		/// This method must only be called at the start of the test fixture's overriden
		/// SetUp().
		/// </summary>
		protected void EmulateWindowSpecificSendKeys()
		{
			Keyboard =
				new KeyboardController(
					new SendKeysFactory(new SendKeysParserFactory(), new WindowSpecificSendKeyboardInput()));
		}


		/// <summary>
		/// Override this Setup method if you have custom behavior to execute before each test
		/// in your fixture.
		/// </summary>
		public virtual void Setup()
		{
		}

		/// <summary>
		/// This method is called by NUnit after each test runs.  If you have custom
		/// behavior to run after each test, then override the TearDown method and do
		/// it there.  That method is called at the beginning of this one.
		/// You should not need to do anything with it.  Do not call it.
		/// If you do call it, call it as the last thing you do in your test.
		/// </summary>
		[TestCleanup]
		public void Verify()
		{
			try
			{
				TearDown();
				GetMessageHook.RemoveHook();

				if (ModalFormHandler == null)
				{
					// Make an effort to ensure that no window message is left dangling
					// Such a message might cause an unexpected dialog box
					for (var i = 0; i < 10; ++i)
					{
						Application.DoEvents();
					}
				}

				if (!Verified)
				{
					Verified = true;
					var allForms = new FormFinder().FindAll();

					foreach (var form in allForms)
					{
						if (!KeepAlive.ShouldKeepAlive(form))
						{
							form.Dispose();
							form.Hide();
						}
					}

					var modalResult = _modal.Verify();
					if (!modalResult.AllModalsShown)
					{
						throw new FormsTestAssertionException("Expected Modal Form did not show");
					}
					if (modalResult.UnexpectedModalWasShown)
					{
						var msg = modalResult.UnexpectedModals.Aggregate("Unexpected modals: ", (current, mod) => current + (mod + ", "));
						throw new FormsTestAssertionException(msg);
					}

					_modal.Dispose();

					if (UseHidden)
					{
						_testDesktop.Dispose();
					}
				}
			}
			finally
			{
				_modal.Dispose();
				Mouse.Dispose();
				Keyboard.Dispose();
			}
		}

		/// <summary>
		/// Override this TearDown method if you have custom behavior to execute after each test
		/// in your fixture.
		/// </summary>
		public virtual void TearDown()
		{
		}

		// Deprecated modal handling interface

		/// <summary>
		/// Unreliable. Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectFileDialog(string modalHandler)
		{
			ExpectModal(FileDialogTester.InitialFileDialogName, modalHandler);
		}

		/// <summary>
		/// Unreliable. Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectFileDialog(string modalHandler, bool expected)
		{
			ExpectModal(FileDialogTester.InitialFileDialogName, modalHandler, expected);
		}

		/// <summary>
		/// Unreliable. Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectFileDialog(ModalFormActivated handler)
		{
			_modal.ExpectModal(FileDialogTester.InitialFileDialogName, handler, true);
		}

		/// <summary>
		/// Unreliable. Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectFileDialog(ModalFormActivated handler, bool expected)
		{
			_modal.ExpectModal(FileDialogTester.InitialFileDialogName, handler, true);
		}

		/// <summary>
		/// Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectModal(string name, ModalFormActivated handler)
		{
			_modal.ExpectModal(name, handler, true);
		}

		/// <summary>
		/// Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectModal(string name, ModalFormActivated handler, bool expected)
		{
			_modal.ExpectModal(name, handler, expected);
		}

		/// <summary>
		/// Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectModal(string name, string handlerName, bool expected)
		{
			ExpectModal(name,
			            (ModalFormActivated) Delegate.CreateDelegate(typeof (ModalFormActivated), this, handlerName),
			            expected);
		}

		/// <summary>
		/// Deprecated in favor of ModalFormHandler/ModalDialogHandler.
		/// </summary>
		[Obsolete]
		protected void ExpectModal(string name, string handlerName)
		{
			ExpectModal(name, handlerName, true);
		}
	}
}