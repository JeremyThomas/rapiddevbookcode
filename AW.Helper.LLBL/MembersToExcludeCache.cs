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
  ///   Simple cache to re-use exclude members array for entity types. For use by LINQPad Driver.
  /// </summary>
  public static class MembersToExcludeCache
  {
    #region Class Member Declarations

    private static readonly object Semaphore = new object();
    private static readonly Dictionary<Type, string[]> Cache = new Dictionary<Type, string[]>();

    private static readonly string[] EntityBasePropertyNames = typeof(EntityBase).GetProperties().Select(p => p.Name)
      .Union(typeof(EntityBase2).GetProperties().Select(p => p.Name)).Distinct().ToArray();

    #endregion

    /// <summary>
    /// Gets the entity property names that should not be displayed. I.e. Base properties and alwaysFetch/AlreadyFetched flag properties.
    /// </summary>
    /// <param name="elementType">Type of the element.</param>
    /// <returns></returns>
    public static IEnumerable<string> GetEntityPropertyNamesThatShouldNotBeDisplayed(Type elementType)
    {
      if (typeof(IEntityCore).IsAssignableFrom(elementType))
      {
        IEnumerable<string> entityBasePropertyNames = EntityBasePropertyNames;
        if (typeof(IEntity).IsAssignableFrom(elementType))
        {
          // remove alwaysFetch/AlreadyFetched flag properties
           entityBasePropertyNames = entityBasePropertyNames
            .Union(elementType.GetProperties()
              .Where(p => p.PropertyType == typeof(bool) &&
                          (p.Name.StartsWith("AlreadyFetched") || p.Name.StartsWith("AlwaysFetch") || p.Name.EndsWith("NewIfNotFound")))
              .Select(p => p.Name));
        }
        return entityBasePropertyNames;
      }
      return Enumerable.Empty<string>();
    }

    /// <summary>
    /// Gets the members to exclude for the type specified. If they're not available in the cache, they're added.
    /// </summary>
    /// <param name="entityType">Type of the entity.</param>
    /// <param name="otherMembersToExclude">The other members to exclude.</param>
    /// <returns>Base properties names and alwaysFetch/AlreadyFetched flag properties names and any that the user has supplied.</returns>
    public static string[] GetMembersToExclude(Type entityType, IEnumerable<string> otherMembersToExclude = null)
    {
      lock (Semaphore)
      {
        string[] membersToExclude;
        if (Cache.TryGetValue(entityType, out membersToExclude)) return membersToExclude;
        var allMembersToExclude = GetEntityPropertyNamesThatShouldNotBeDisplayed(entityType);
        if (otherMembersToExclude != null)
          allMembersToExclude = allMembersToExclude.Union(otherMembersToExclude);
        membersToExclude = allMembersToExclude.Distinct().ToArray();
        Cache[entityType] = membersToExclude;
        return membersToExclude;
      }
    }
  }
}