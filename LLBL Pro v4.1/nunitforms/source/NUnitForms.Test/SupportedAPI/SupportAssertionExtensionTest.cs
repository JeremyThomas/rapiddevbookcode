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
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    /// <summary>
    /// A note about this class: it only tests that those methods exist on the
    /// base class and not that they are completely implemented correctly.  I think
    /// that it works, tell me if it does not.  It may be marked obsolete shortly
    /// because that is what the next version of nunit does.
    /// </summary>
    [Obsolete()]
    [TestFixture]
    public class SupportsAssertionExtensionTest : NUnitFormsAssertionTest
    {
        public void BaseClassAssertNotNull()
        {
            AssertNotNull("test");
            AssertNotNull("message", "test");
        }

        [Test]
        public void BaseClassAssert()
        {
            Assert(true);
            Assert(true, "message");
        }

        [Test]
        public void BaseClassAssertEquals()
        {
            AssertEquals(1.0d, 1.0d, 0.0d);
            AssertEquals(1.0f, 1.0f, 0.0f);
            AssertEquals("test", "test");
            AssertEquals(1, 1);
            AssertEquals("message", 1.0d, 1.0d, 0.0d);
            AssertEquals("message", 1.0f, 1.0f, 0.0f);
            AssertEquals("message", "test", "test");
            AssertEquals("message", 1, 1);
        }

        [Test]
        [ExpectedException(typeof (AssertionException))]
        public void BaseClassAssertFail()
        {
            Fail();
        }

        [Test]
        [ExpectedException(typeof (AssertionException))]
        public void BaseClassAssertFailMessage()
        {
            Fail("message");
        }

        [Test]
        public void BaseClassAssertSame()
        {
            AssertSame("test", "test");
            AssertSame("message", "test", "test");
        }
    }
}