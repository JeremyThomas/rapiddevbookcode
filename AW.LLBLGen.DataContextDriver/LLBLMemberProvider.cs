using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AW.Helper.LLBL;
using LINQPad;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.LLBLGen.DataContextDriver
{
  public class LLBLMemberProvider : ICustomMemberProvider
  {
    public static bool IsEntity(Type t)
    {
      return typeof (IEntityCore).IsAssignableFrom(t);
    }

    /// <summary>
    ///   Creates the LLBL display member provider if objectToWrite does not implement ICustomMemberProvider and is a LLBL
    ///   entity.
    /// </summary>
    /// <param name="objectToWrite">The object to write.</param>
    /// <param name="membersToExclude">The members to exclude.</param>
    /// <returns></returns>
    public static ICustomMemberProvider CreateCustomDisplayMemberProviderIfNeeded(object objectToWrite, IEnumerable<string> membersToExclude = null)
    {
      var objectToWriteType = objectToWrite.GetType();
      var isCustomMemberProvider = objectToWriteType.GetInterface("ICustomMemberProvider", true) != null;
      return !isCustomMemberProvider && IsEntity(objectToWriteType) ? new LLBLMemberProvider(objectToWrite, objectToWriteType, membersToExclude) : null;
    }

    private readonly object _objectToWrite;
    private readonly List<PropertyDescriptor> _propsToWrite;

    public LLBLMemberProvider(object objectToWrite, Type itemType, IEnumerable<string> membersToExclude = null)
    {
      _objectToWrite = objectToWrite;
      _propsToWrite = PropertyDescriptorCache.GetDescriptors(itemType, membersToExclude);
    }

    IEnumerable<string> ICustomMemberProvider.GetNames()
    {
      return _propsToWrite.Select(p => p.Name);
    }

    IEnumerable<Type> ICustomMemberProvider.GetTypes()
    {
      return _propsToWrite.Select(p => p.PropertyType);
    }

    IEnumerable<object> ICustomMemberProvider.GetValues()
    {
      return _propsToWrite.Select(GetValueIfAlreadyFetched);
    }

    private object GetValueIfAlreadyFetched(PropertyDescriptor p)
    {
      if (IsSelfServicingProperty(p))
      {
        var alreadyFetchedDescriptor = PropertyDescriptorCache.GetAlreadyFetchedDescriptor(p);
        if (alreadyFetchedDescriptor != null)
        {
          var alreadyFetched = (Boolean?) alreadyFetchedDescriptor.GetValue(_objectToWrite);
          if (!alreadyFetched.GetValueOrDefault())
            return null;
        }
      }
      return p.GetValue(_objectToWrite);
    }

    private static bool IsSelfServicingProperty(PropertyDescriptor propertyDescriptor)
    {
      return typeof (IEntityCollection).IsAssignableFrom(propertyDescriptor.PropertyType) || typeof (IEntity).IsAssignableFrom(propertyDescriptor.PropertyType);
    }
  }
}