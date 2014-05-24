////////////////////////////////////////////////////////////////////////////////////////////////////////
// LLBLGen Pro LINQPad driver is (c) 2002-2012 Solutions Design. All rights reserved.
// http://www.llblgen.com
////////////////////////////////////////////////////////////////////////////////////////////////////////
// COPYRIGHTS:
// Copyright (c)2002-2012 Solutions Design. All rights reserved.
// http://www.llblgen.com
// 
// The LLBLGen Pro LINQPad driver sourcecode is released under the following license (BSD2):
// ----------------------------------------------------------------------
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
// Special thanks to:
//		- Jeremy Thomas
// From "http://llblgenlinqpad.codeplex.com"
//////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Helper.LLBL
{
  /// <summary>
  ///   Simple cache to re-use property descriptor lists for entity types. For use by LINQPad Driver.
  /// </summary>
  public static class PropertyDescriptorCache
  {
    #region Class Member Declarations

    private static readonly object Semaphore = new object();
    private static readonly Dictionary<Type, List<PropertyDescriptor>> Cache = new Dictionary<Type, List<PropertyDescriptor>>();

    #endregion

    /// <summary>
    /// Gets the property descriptors for the type specified. If they're not available in the cache, they're added.
    /// </summary>
    /// <param name="entityType">Type of the entity.</param>
    /// <param name="otherMembersToExclude">The other members to exclude.</param>
    /// <returns></returns>
    /// <remarks>
    /// Only returns descriptors for properties which don't implement IEntityCollection,
    /// don't implement IEntity and which are browsable and which aren't in the list of Members To Exclude.
    /// </remarks>
    public static List<PropertyDescriptor> GetDescriptors(Type entityType, IEnumerable<string> otherMembersToExclude = null)
    {
      lock (Semaphore)
      {
        List<PropertyDescriptor> descriptors;
        if (!Cache.TryGetValue(entityType, out descriptors))
        {
          var rawDescriptors = TypeDescriptor.GetProperties(entityType);
          var membersToExclude = MembersToExcludeCache.GetMembersToExclude(entityType, otherMembersToExclude);
          descriptors = rawDescriptors.AsEnumerable().Where(descriptor => descriptor.IsBrowsable
                                                                          && !membersToExclude.Contains(descriptor.Name)
                                                                          && !typeof (IEntityCollection).IsAssignableFrom(descriptor.PropertyType)
                                                                          && !typeof (IEntity).IsAssignableFrom(descriptor.PropertyType)).ToList();
          Cache[entityType] = descriptors;
        }
        return descriptors;
      }
    }
  }
}