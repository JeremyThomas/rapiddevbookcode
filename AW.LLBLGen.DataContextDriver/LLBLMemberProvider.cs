using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using AW.Helper;
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

    public static bool IsEntityOrEntities(object objectToWrite)
    {
      if (objectToWrite == null)
        return false;
      var objects = objectToWrite as IEnumerable;
      return IsEntity(objects == null ? objectToWrite.GetType() : MetaDataHelper.GetEnumerableItemType(objects));
    }

    private readonly object _objectToWrite;
    private readonly IEnumerable<PropertyDescriptor> _propsToWrite;

    public LLBLMemberProvider(object objectToWrite)
    {
      _objectToWrite = objectToWrite;
      _propsToWrite = MetaDataHelper.GetPropertiesToDisplay(objectToWrite.GetType());
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
      return _propsToWrite.Select(p => p.GetValue(_objectToWrite));
    }
  }
}