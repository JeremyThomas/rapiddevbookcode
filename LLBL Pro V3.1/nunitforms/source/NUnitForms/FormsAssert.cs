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

namespace NUnit.Extensions.Forms
{
    ///<summary>
    /// Additional assertion methods for NUnitForms.
    ///</summary>
    public class FormsAssert
    {
        ///<summary>
        /// Asserts that the given objects are equal.
        ///</summary>
        ///<param name="o"></param>
        ///<param name="o2"></param>
        ///<param name="error"></param>
        ///<exception cref="FormsTestAssertionException"></exception>
        public static void AreEqual(object o, object o2, string error)
        {
            if (!o.Equals(o2))
            {
                throw new FormsTestAssertionException("should be equal " + o + " : " + o2 + " , " + error);
            }
        }

        ///<summary>
        /// Asserts that the given value is true.
        ///</summary>
        ///<param name="val"></param>
        ///<exception cref="FormsTestAssertionException"></exception>
        public static void IsTrue(bool val)
        {
            IsTrue(val, "was not true.");
        }

        ///<summary>
        /// Asserts that the given value is true.
        ///</summary>
        ///<param name="val"></param>
        ///<param name="error"></param> 
        ///<exception cref="FormsTestAssertionException"></exception>
        public static void IsTrue(bool val, string error)
        {
            if (!val)
            {
                throw new FormsTestAssertionException(error);
            }
        }
    }
}