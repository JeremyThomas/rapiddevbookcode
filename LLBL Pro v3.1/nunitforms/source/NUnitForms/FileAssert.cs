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

using System.IO;

namespace NUnit.Extensions.Forms
{
    ///<summary>
    /// Assertions for files.
    ///</summary>
    public static class FileAssert
    {
        ///<summary>
        /// Compare two files for binary equality.
        ///</summary>
        ///<param name="filePathOne">The path to the first file to compare.</param>
        ///<param name="filePathTwo">The path to the second file to compare.</param>
        ///<returns>True if the given files have the same contents.</returns>
        public static bool AreBinaryEqual(string filePathOne, string filePathTwo)
        {
            if (!File.Exists(filePathOne) || !File.Exists(filePathTwo))
                return false;

            using (BinaryReader fileOne = new BinaryReader(File.OpenRead(filePathOne)))
            using (BinaryReader fileTwo = new BinaryReader(File.OpenRead(filePathTwo)))
            {
                while (fileOne.PeekChar() != -1 && fileTwo.PeekChar() != -1)
                {
                    if (fileOne.ReadByte() != fileTwo.ReadByte())
                        return false;
                }

                return true;
            }
        }
    }
}