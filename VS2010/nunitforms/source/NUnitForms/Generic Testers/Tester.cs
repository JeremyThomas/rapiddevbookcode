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
using System.Collections;
using System.Collections.Generic;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    public class Tester<T, TThis> : ReflectionTester, IEnumerable<TThis>
        where TThis : Tester<T, TThis>, new()
    {
        private Form form;
        private string formName;
        private int index = -1;

        /// <summary>
        /// The name of the underlying test object (sometimes acontrol).
        /// </summary>
        protected string name;

        public Tester(string name, string formName)
        {
            this.formName = formName;
            this.name = name;
        }

        public Tester(string name, Form form)
        {
            this.form = form;
            this.name = name;
        }

        public Tester(string name)
        {
            this.name = name;
        }

        public Tester(Tester<T, TThis> tester, int index)
        {
            InitFromTester(tester, index);
        }

        ///<summary>
        /// Default constructor for generic support.
        ///</summary>
        protected Tester()
        {
        }

        public int Count
        {
            get { return GetFinder().Count; }
        }

        /// <summary>
        /// The underlying <see cref="Control"/> for this tester.
        /// </summary>
        public virtual T Properties
        {
            get { return GetFinder().Find(index); }
        }

        /// <summary>
        /// The Control being tested.
        /// </summary>
        public override object TheObject
        {
            get { return Properties; }
        }

        public virtual TThis this[int index]
        {
            get
            {
                TThis newTester = new TThis();
                newTester.InitFromTester(this, index);
                return newTester;
            }
        }

        #region IEnumerable<TThis> Members

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        ///<summary>
        ///Returns an enumerator that iterates through the collection.
        ///</summary>
        public IEnumerator<TThis> GetEnumerator()
        {
            List<TThis> items = new List<TThis>();
            for (int i = 0; i < Count; i++)
            {
                items.Add(this[i]);
            }
            return items.GetEnumerator();
        }

        #endregion

        protected void InitFromTester(Tester<T, TThis> tester, int controlIndex)
        {
            if (controlIndex < 0)
                throw new ArgumentOutOfRangeException("controlIndex", controlIndex, "Should not have index < 0");
            index = controlIndex;
            form = tester.form;
            formName = tester.formName;
            name = tester.name;
        }

        private Finder<T> GetFinder()
        {
            if (form != null)
            {
                return new Finder<T>(name, form);
            }
            else if (formName != null)
            {
                return new Finder<T>(name, new FormFinder().Find(formName));
            }
            else
            {
                return new Finder<T>(name);
            }
        }
    }
}