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

using System;
using System.Collections.Generic;
using System.Reflection;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// Additional methods for working with Types and other Reflection objects.
    /// </summary>
    public static class Types
    {
        ///<summary>
        /// Returns true if the given type has any declared public properties.
        ///</summary>
        public static bool HasPublicProperties(Type type)
        {
            PropertyInfo info =
                type.GetProperty("Properties",
                                 BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly);
            return info != null;
        }

        ///<summary>
        /// Retrives a list of names of events that the given type publishes.
        ///</summary>
        ///<param name="type"></param>
        ///<returns></returns>
        public static ICollection<string> GetEventNames(Type type)
        {
            List<string> list = new List<string>();
            foreach (EventInfo info in type.GetEvents())
            {
                list.Add(info.Name);
            }
            return list;
        }
    }
}