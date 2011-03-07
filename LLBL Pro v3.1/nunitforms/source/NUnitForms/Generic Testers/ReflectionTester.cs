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
using System.Reflection;

namespace NUnit.Extensions.Forms
{
    ///<summary>
    /// Abstract base class for control and component testers that
    /// handles getting and setting properties and fields via reflection.
    ///</summary>
    public abstract class ReflectionTester
    {
        /// <summary>
        /// Derived testers must overtide this method to provide the object being tested.
        /// </summary>
        public abstract object TheObject { get; }

        /// <summary>
        /// Convenience accessor / mutator for any nonsupported property on a control
        /// to test.
        /// </summary>
        /// <example>
        /// ControlTester t = new ControlTester("t");
        /// t["Text"] = "a";
        /// AssertEqual("a", t["Text"]);
        /// </example>
        /// 
        public object this[string propertyName]
        {
            get
            {
                PropertyInfo prop = GetPropertyInfo(propertyName);
                if (prop != null)
                {
                    return prop.GetValue(TheObject, null);
                }
                else
                {
                    FieldInfo field = GetFieldInfo(propertyName);
                    if (field != null)
                        return field.GetValue(TheObject);
                }

                return null;
            }
            set
            {
                PropertyInfo prop = GetPropertyInfo(propertyName);
                if (prop != null)
                {
                    prop.SetValue(TheObject, value, null);
                    DoAfterSetProperty(propertyName);
                }
                else
                {
                    FieldInfo field = GetFieldInfo(propertyName);
                    if (field != null)
                        field.SetValue(TheObject, value);
                }
            }
        }

        /// <summary>
        /// Called after this[string] is used to set a property value.
        /// Typically calls "EndCurrentEdit" on the object's data binding binding for that property.
        /// </summary>
        protected virtual void DoAfterSetProperty(string propertyName)
        {
        }

        private FieldInfo GetFieldInfo(string fieldName)
        {
            return
                TheObject.GetType().GetField(fieldName,
                                             BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        }

        private PropertyInfo GetPropertyInfo(string propertyName)
        {
            return
                TheObject.GetType().GetProperty(propertyName,
                                                BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic);
        }

        /// <summary>
        /// Simulates firing of an event by the control being tested.
        /// </summary>
        /// <param name="eventName">The name of the event to fire.</param>
        /// <param name="args">The optional arguments required to construct the EventArgs for the specified event.</param>
        public void FireEvent(string eventName, params object[] args)
        {
            EventHelper.RaiseEvent(TheObject, eventName, args);
        }

        /// <summary>
        /// Simulates firing of an event by the control being tested.
        /// </summary>
        /// <param name="eventName">The name of the event to fire.</param>
        /// <param name="arg">The EventArgs object to pass as a parameter on the event.</param>
        public void FireEvent(string eventName, EventArgs arg)
        {
            EventHelper.RaiseEvent(TheObject, eventName, arg);
        }

        /// <summary>
        /// Simulates firing of an event by the control being tested.
        /// </summary>
        /// <param name="eventName">The name of the event to fire.</param>
        public void FireEvent(string eventName)
        {
            EventHelper.RaiseEvent(TheObject, eventName);
        }

        /// <summary>
        /// Convenience method invoker for any nonsupported method on a control to test
        /// </summary>
        /// <param name="methodName">the name of the method to invoke</param>
        /// <param name="args">the arguments to pass into the method</param>
        public object Invoke(string methodName, params object[] args)
        {
            return EventHelper.Call(TheObject, methodName, args);
        }
    }
}