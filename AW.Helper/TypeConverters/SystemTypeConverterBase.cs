//////////////////////////////////////////////////////////////////////
// Public Class definitions for the System Type Converters assembly of LLBLGen Pro.
// (c) 2002-2011 Solutions Design, all rights reserved.
// http://www.llblgen.com/
//////////////////////////////////////////////////////////////////////
// The sourcecode for this type converter is released as BSD2 licensed open source, so licensees and others can
// modify, update, extend or use it to write other type converters 
//////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c)2002-2010 Solutions Design. All rights reserved.
// 
// This LLBLGen Pro type converter is released under the following license: (BSD2)
// -------------------------------------------------------------------------
// Redistribution and use in source and binary forms, with or without modification, 
// are permitted provided that the following conditions are met: 
//
// 1) Redistributions of source code must retain the above copyright notice, this list of 
//    conditions and the following disclaimer. 
// 2) Redistributions in binary form must reproduce the above copyright notice, this list of 
//    conditions and the following disclaimer in the documentation and/or other materials 
//    provided with the distribution. 
// 
// THIS SOFTWARE IS PROVIDED BY SOLUTIONS DESIGN ``AS IS'' AND ANY EXPRESS OR IMPLIED WARRANTIES, 
// INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A 
// PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL SOLUTIONS DESIGN OR CONTRIBUTORS BE LIABLE FOR 
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
// NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR 
// BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, 
// STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE 
// USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE. 
//
// The views and conclusions contained in the software and documentation are those of the authors 
// and should not be interpreted as representing official policies, either expressed or implied, 
// of Solutions Design. 
//
//////////////////////////////////////////////////////////////////////
// Contributers to the code:
//		- Frans Bouma [FB]
//////////////////////////////////////////////////////////////////////

using System;
using System.ComponentModel;

namespace AW.Helper.TypeConverters
{
	/// <inheritdoc />
	/// <summary>
	/// Abstract base class for the system type converters shipped with llblgen pro.
	/// </summary>
	/// <remarks>Classes derived from this class are recognized by the designer as 'designer only' type converters and can only be used if 
	/// the target framework of the project has the type converter defined as a system type converter, as the type converter is considered to have
	/// no real runtime code, it can't convert values at runtime.</remarks>
	[DesignOnly(true)]
	public abstract class SystemTypeConverterBase : TypeConverter
	{

		/// <summary>
		/// Returns whether this converter can convert an object of the given type to the type of this converter
		/// </summary>
		/// <param name="context">Ignored</param>
		/// <param name="sourceType">A <see cref="T:System.Type"/> that represents the type you want to convert from.</param>
		/// <returns><see langword="true "/>if this converter can perform the conversion; otherwise, <see langword="false"/>.</returns>
		public override bool CanConvertFrom(ITypeDescriptorContext context, Type sourceType)
		{
			return CheckType(sourceType);
		}


		/// <summary>
		/// Returns whether this converter can convert the object to the specified type.
		/// </summary>
		/// <param name="context">Ignored</param>
		/// <param name="destinationType">A <see cref="T:System.Type"/> that represents the type you want to convert to.</param>
		/// <returns><see langword="true "/>if this converter can perform the conversion; otherwise, <see langword="false"/>.</returns>
		public override bool CanConvertTo(ITypeDescriptorContext context, Type destinationType)
		{
			return CheckType(destinationType);
		}


		/// <summary>
		/// Checks the type if it's usable to convert to/from for this type converter.
		/// </summary>
		/// <param name="typeToCheck">The type to check.</param>
		/// <returns>
		/// true if the type is usable for this type converter, false otherwise
		/// </returns>
		protected virtual bool CheckType(Type typeToCheck)
		{
			return false;
		}
	}
}
