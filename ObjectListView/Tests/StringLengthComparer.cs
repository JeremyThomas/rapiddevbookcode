// ObjectListView
// Copyright � 2006, 2007 Jesse Johnston.  All rights reserved.

#pragma warning disable 1591	// Missing XML comment

#if TEST
using System;
using System.Collections;

namespace JesseJohnston.Tests
{
	public class StringLengthComparer : IComparer
	{
		public int Compare(object x, object y)
		{
			return ((string)x).Length.CompareTo(((string)y).Length);
		}
	}
}
#endif
