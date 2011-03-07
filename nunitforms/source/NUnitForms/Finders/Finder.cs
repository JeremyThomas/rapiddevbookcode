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
using System.ComponentModel;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms
{
    /// <summary>
    /// Internal use only.  Finds controls, components, and menuitems
    /// according to their name property.
    /// </summary>
    /// <remarks>
    /// It is also used by the recorder application which is why it is not
    /// internal.
    /// </remarks>
    /// the recorder application.
    public class Finder<T>
    {
        private readonly List<Form> forms = null;
        private readonly string name;

        public Finder()
        {
        }

        /// <summary>
        /// Creates a Finder that will find things on a specific Form according to their name.
        /// </summary>
        /// <param name="name">The name of the Control to find.</param>
        /// <param name="form">The form to search for the control.</param>
        public Finder(string name, Form form)
        {
            this.name = name;
            if (form != null)
            {
                forms = new List<Form>();
                forms.Add(form);
            }
        }

        /// <summary>
        /// Creates a Finder that will find things according to their name.  
        /// </summary>
        /// <param name="name">The name of the thing to find.</param>
        public Finder(string name)
        {
            this.name = name;
        }

        public int Count
        {
            get { return FindAll(typeof (T)).Count; }
        }

        private List<Form> FormCollection
        {
            get
            {
                if (forms == null)
                {
                    return new FormFinder().FindAll();
                }
                return forms;
            }
        }

        /// <summary>
        /// Finds a control.  
        /// </summary>
        /// <exception>
        /// If there is more than one with the specified name, it will
        /// throw an AmbiguousNameException.  If the Control does not exist, it will throw
        /// a NoSuchControlException.
        /// </exception>
        /// <returns>The control if one is found.</returns>
        public T Find()
        {
            return Find(-1);
        }

        public T Find(int index)
        {
            return (T) Find(index, typeof (T));
        }

        private List<object> FindAll()
        {
            List<Object> found = new List<Object>();
            foreach (Form form in FormCollection)
            {
                found.AddRange(Find(name, form, null));
            }
            return found;
        }

        private List<object> FindAll(Type type)
        {
            List<Object> found = new List<object>();
            List<Object> allFound = FindAll();
            foreach (object o in allFound)
            {
                if (type.IsAssignableFrom(o.GetType()))
                {
                    found.Add(o);
                }
            }
            return found;
        }

        private Object Find(int index, Type type)
        {
            List<Object> found = FindAll(type);
            if (index < 0)
            {
                if (found.Count == 1)
                {
                    return found[0];
                }
                else if (found.Count == 0)
                {
                    throw new NoSuchControlException(name);
                }
                else
                {
                    throw new AmbiguousNameException(name);
                }
            }
            else
            {
                if (found.Count > index)
                {
                    return found[index];
                }
                else
                {
                    throw new NoSuchControlException(name + "[" + index + "]");
                }
            }
        }

        private List<Object> Find(string name, Object obj, Object src)
        {
            List<Object> results = new List<Object>();

            if (Matches(name, obj, src))
            {
                results.Add(obj);
            }

            if (obj is Form)
            {
                Form f = (Form) obj;
                if (f.Menu != null)
                {
                    results.AddRange(Find(name, f.Menu, f));
                }
            }

            if (obj is ToolStrip)
            {
                ToolStrip t = (ToolStrip) obj;
                foreach (ToolStripItem t2 in t.Items)
                {
                    results.AddRange(Find(name, t2, null));
                }
            }

            if (obj is ToolStripDropDownItem)
            {
                ToolStripDropDownItem i = (ToolStripDropDownItem) obj;
                foreach (ToolStripItem i2 in i.DropDownItems)
                {
                    results.AddRange(Find(name, i2, null));
                }
            }

            if (obj is Control)
            {
                Control c = (Control) obj;
                foreach (Control c2 in c.Controls)
                {
                    results.AddRange(Find(name, c2, null));
                }
                if (c.ContextMenu != null)
                {
                    results.AddRange(Find(name, c.ContextMenu, c));
                }
                if (c.ContextMenuStrip != null)
                {
                    foreach (ToolStripItem item in c.ContextMenuStrip.Items)
                    {
                        results.AddRange(Find(name, item, null));
                    }
                }
            }

            if (obj is Menu)
            {
                Menu m = (Menu) obj;
                foreach (MenuItem m2 in m.MenuItems)
                {
                    results.AddRange(Find(name, m2, src));
                }
            }
            return results;
        }

        private bool Matches(string name, object control, object src)
        {
            object c = control;
            string[] names = name.Split('.');
            for (int i = names.Length - 1; i >= 0; i--)
            {
                if (!names[i].Equals(Name(c)))
                {
                    return false;
                }
                c = Parent(c);
                if (c == null && src != null)
                {
                    c = src;
                }
            }
            return true;
        }

        public object Parent(object o)
        {
            if (o is Control)
            {
                return ((Control) o).Parent;
            }
            if (o is MenuItem)
            {
                return ((MenuItem) o).Parent;
            }
            if (o is Component)
            {
                return ((Component) o).Container;
            }
            return null;
        }

        public string Name(object o)
        {
            if (o is ToolStripControlHost)
            {
                return ((ToolStripControlHost) o).Name;
            }
            if (o is ToolStripItem)
            {
                return ((ToolStripItem) o).Name;
            }
            if (o is Control)
            {
                return ((Control) o).Name;
            }
            if (o is MenuItem)
            {
                return ((MenuItem) o).Text.Replace("&", string.Empty).Replace(".", string.Empty);
            }
            if (o is MainMenu)
            {
                return "MainMenu";
            }
            if (o is ContextMenu)
            {
                return "ContextMenu";
            }
            if (o is Component)
            {
                return ((Component) o).Site.Name;
            }
            throw new Exception("Object name not defined");
        }
    }
}