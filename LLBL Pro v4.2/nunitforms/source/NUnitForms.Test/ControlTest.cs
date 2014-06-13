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
using System.Collections.Generic;
using System.Reflection;
using System.Windows.Forms;
using NUnit.Framework;

namespace NUnit.Extensions.Forms.TestApplications
{
    ///<summary>
    /// Basic tests for the <see cref="ControlTester"/> class.
    ///</summary>
    [TestFixture]
    public class ControlTest : NUnitFormTest
    {
        private ControlTester label;

        public override void Setup()
        {
            new LabelTestForm().Show();
            label = new ControlTester("myLabel");
        }

        /// <summary>
        /// Verify that the given type has an int indexer.
        /// </summary>
        /// <param name="testerType">The <see cref="Type"/> to test.</param>
        private static bool HasIntIndexer(Type testerType)
        {
            PropertyInfo propIndexer = testerType.GetProperty("Item", testerType);
            if (propIndexer != null)
            {
                ParameterInfo[] indexParams = propIndexer.GetIndexParameters();

                if (indexParams.Length == 1 && indexParams[0].ParameterType == typeof (int))
                {
                    propIndexer.GetGetMethod().Invoke(
                        Activator.CreateInstance(testerType, new object[] {"string"}),
                        new object[] {0});
                    return true;
                }
            }
            return false;
        }

        private static void VerifyAllConstructors(string typeName, ConstructorInfo[] constructors)
        {
            bool argString = false;
            bool argStringString = false;
            bool argStringForm = false;
            bool argControltesterInt = false;

            foreach (ConstructorInfo constructor in constructors)
            {
                argString = argString || CheckMatches(constructor, "string");
                argStringString = argString || CheckMatches(constructor, "string", "string");
                argStringForm = argString || CheckMatches(constructor, "string", new Form());
                argControltesterInt = argString || CheckMatches(constructor, new ControlTester("string"), 1);
            }
            Assert.IsTrue(argString, typeName + " missing constructor 1");
            Assert.IsTrue(argStringString, typeName + " missing constructor 2");
            Assert.IsTrue(argStringForm, typeName + " missing constructor 3");
            Assert.IsTrue(argControltesterInt, typeName + " missing constructor 4");
        }

        private static bool CheckMatches(ConstructorInfo constructor, params object[] args)
        {
            ParameterInfo[] parameters = constructor.GetParameters();

            if (parameters.Length != args.Length)
            {
                return false;
            }
            for (int i = 0; i < args.Length; i++)
            {
                if (parameters[i].ParameterType != args[i].GetType())
                {
                    return false;
                }
            }

            constructor.Invoke(args); //test it

            return true;
        }

        ///<summary>
        /// Test finding a control with an invalid index.
        ///</summary>
        [Test]
        [ExpectedException(typeof (ArgumentOutOfRangeException))]
        public void BadIndex()
        {
            object o = new ControlTester("s")[-1];
            Assert.Fail("Should not find: " + o);
        }

        [Test]
        public void ControlClick()
        {
            Assert.AreEqual("myValue", label.Text);
        }

        ///<summary>
        /// Verifies that all control testers have the expected constructors.
        ///</summary>
        /// <remarks>
        /// <para>
        /// Control testers should usually be defined with the 4 standard constructors
        /// so that tests can be scripted propertly.
        /// </para>
        /// <para>
        /// Certain dialog tests have fewer constructors, and no check is made for
        /// </para>
        /// </remarks>
        [Test]
        public void ControlTestersHaveFourConstructorsAndIndexer()
        {
            IList<Type> typesToSkip = new[] {typeof (MessageBoxTester), typeof (FormTester)};

            Type[] types = typeof (ControlTester).Assembly.GetTypes();
            foreach (Type type in types)
            {
                if (typeof (ControlTester).IsAssignableFrom(type))
                {
                    // Skip tests for generic classes (for now.)
                    if (type.IsGenericType)
                        continue;

                    // Explicitly skip tests for these types.
                    if (typesToSkip.Contains(type))
                        continue;

                    ConstructorInfo[] constructors = type.GetConstructors();

                    // OpenFileDialogTester only has one construtor.
                    if (type == typeof (OpenFileDialogTester))
                    {
                        Assert.AreEqual(1, constructors.Length,
                                        string.Format("{0}has incorrect constructor count.", type.Name));
                        continue;
                    }

                    Assert.IsTrue(4 <= constructors.Length,
                                  string.Format("{0}has incorrect constructor count.", type.Name));

                    VerifyAllConstructors(type.Name, constructors);
                    Assert.IsTrue(HasIntIndexer(type),
                                  string.Format("Type {0} does not have an int indexer.", type.Name));
                }
            }
        }

        [Test]
        public void ControlText()
        {
            Assert.AreEqual("myValue", label.Text);
        }

        [Test]
        public void Property()
        {
            Assert.AreEqual("myValue", label["Text"]);
            label["Text"] = "try to change it";
            Assert.AreEqual("try to change it", label["Text"]);
        }
    }
}