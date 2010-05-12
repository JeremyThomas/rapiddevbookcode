using System;
using System.Collections.Generic;

namespace LINQPad
{
  /// <summary>
  ///  To control what fields/properties of custom types are displayed via LINQPad's Dump method implement this interface
  /// </summary>
  /// <see cref="http://www.linqpad.net/FAQ.aspx"/>
  public interface ICustomMemberProvider
  {
    // Each of these methods must return a sequence
    // with the same number of elements:
    IEnumerable<string> GetNames();
    IEnumerable<Type> GetTypes();
    IEnumerable<object> GetValues();
  }
}