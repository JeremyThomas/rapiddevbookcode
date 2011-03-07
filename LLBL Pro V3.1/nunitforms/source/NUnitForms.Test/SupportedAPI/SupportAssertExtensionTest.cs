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
    public class SupportsAssertExtensionTest : NUnitFormsAssertTest
    {
        //a note about this class.. it only tests that those methods exist on the
        //base.. and not that they are completely implemented correctly.  I think
        //that it works, tell me if it does not.  

        public void BaseClassIsNull()
        {
            IsNull(null);
            IsNull(null, "message");
        }

        public void BaseClassIsNotNull()
        {
            IsNotNull("test");
            IsNotNull("test", "message");
        }

        [Test]
        public void BaseClassAreEqual()
        {
            AreEqual(1.0d, 1.0d, 0.0d);
            AreEqual(1.0f, 1.0f, 0.0f);
            AreEqual("test", "test");
            AreEqual(1, 1);
            AreEqual(new decimal(1.0d), new decimal(1.0d));
            AreEqual(1.0d, 1.0d, 0.0d, "message");
            AreEqual(1.0f, 1.0f, 0.0f, "message");
            AreEqual("test", "test", "message");
            AreEqual(1, 1, "message");
            AreEqual(new decimal(1.0d), new decimal(1.0d), "message");
        }

        [Test]
        public void BaseClassAreSame()
        {
            AreSame("test", "test");
            AreSame("test", "test", "message");
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
        public void BaseClassIsFalse()
        {
            IsFalse(false);
            IsFalse(false, "message");
        }

        [Test]
        public void BaseClassIsTrue()
        {
            IsTrue(true);
            IsTrue(true, "message");
        }
    }
}