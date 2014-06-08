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
    /// Methods for firing events via reflection.
    ///</summary>
    public static class EventHelper
    {
        ///<summary>
        /// Fires the named event on the given object using the object's "OnEventName" method.
        ///</summary>
        /// <remarks>
        /// <para>
        /// By convention, an event named "MyEvent(object sender, MyEventArgs e)" should have a virtual protected
        /// method "OnMyEvent(MyEventArgs e)" that actually calls any attached event handler.
        /// </para>
        /// <para>
        /// This method assumes that the target event has been implemented with this pattern.
        /// </para>
        /// </remarks>
        ///<param name="targetObject">The object raising the event.</param>
        ///<param name="eventName">The name of the event to raise.</param>
        public static void RaiseEvent(object targetObject, string eventName)
        {
            MethodInfo minfo = targetObject.GetType().GetMethod("On" + eventName,
                                                                BindingFlags.Instance | BindingFlags.Public |
                                                                BindingFlags.NonPublic);
            ParameterInfo[] param = minfo.GetParameters();
            Type parameterType = param[0].ParameterType;
            minfo.Invoke(targetObject, new[] {Activator.CreateInstance(parameterType)});
        }

        ///<summary>
        /// Fires the named event on the given object using the object's "OnEventName" method.
        ///</summary>
        /// <remarks>
        /// <para>
        /// By convention, an event named "MyEvent(object sender, MyEventArgs e)" should have a virtual protected
        /// method "OnMyEvent(MyEventArgs e)" that actually calls any attached event handler.
        /// </para>
        /// <para>
        /// This method assumes that the target event has been implemented with this pattern.
        /// </para>
        /// </remarks>
        ///<param name="targetObject">The object raising the event.</param>
        ///<param name="eventName">The name of the event to raise.</param>
        ///<param name="args">A list of arguments to pass to the EventArgs-derived parameter's constructor.</param>
        public static void RaiseEvent(object targetObject, string eventName, object[] args)
        {
            MethodInfo minfo = targetObject.GetType().GetMethod("On" + eventName,
                                                                BindingFlags.Instance | BindingFlags.Public |
                                                                BindingFlags.NonPublic);
            ParameterInfo[] param = minfo.GetParameters();
            Type parameterType = param[0].ParameterType;
            minfo.Invoke(targetObject, new[] {Activator.CreateInstance(parameterType, args)});
        }

        ///<summary>
        /// Fires the named event on the given object using the object's "OnEventName" method.
        ///</summary>
        /// <remarks>
        /// <para>
        /// By convention, an event named "MyEvent(object sender, MyEventArgs e)" should have a virtual protected
        /// method "OnMyEvent(MyEventArgs e)" that actually calls any attached event handler.
        /// </para>
        /// <para>
        /// This method assumes that the target event has been implemented with this pattern.
        /// </para>
        /// </remarks>
        ///<param name="targetObject">The object raising the event.</param>
        ///<param name="eventName">The name of the event to raise.</param>
        ///<param name="arg">The EventArgs-derived class to pass to this event.</param>
        public static void RaiseEvent(object targetObject, string eventName, EventArgs arg)
        {
            MethodInfo minfo = targetObject.GetType().GetMethod("On" + eventName,
                                                                BindingFlags.Instance | BindingFlags.Public |
                                                                BindingFlags.NonPublic);
            minfo.Invoke(targetObject, new object[] {arg});
        }

        ///<summary>
        /// Calls the given method on the target object with the specified arguments.
        ///</summary>
        ///<returns>The return value of the called method, if any.</returns>
        public static object Call(object targetObject, string methodName, object[] args)
        {
            Type[] types = new Type[args.Length];
            for (int i = 0; i < types.Length; i++)
            {
                types[i] = args[i].GetType();
            }
            MethodInfo minfo =
                targetObject.GetType().GetMethod(methodName,
                                                 BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                                 null, types, null);
            return minfo.Invoke(targetObject, args);
        }
    }
}