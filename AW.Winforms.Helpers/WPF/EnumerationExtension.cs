using System;
using System.Linq;
using System.Windows.Markup;
using AW.Helper;

namespace AW.Winforms.Helpers.WPF
{
  public class EnumerationExtension : MarkupExtension
  {
    private Type _enumType;

    public EnumerationExtension(Type enumType)
    {
      if (enumType == null) throw new ArgumentNullException("enumType");
      EnumType = enumType;
    }

    public Type EnumType
    {
      get { return _enumType; }
      private set
      {
        if (_enumType == value) return;
        var enumType = MetaDataHelper.GetCoreType(value);
        if (enumType.IsEnum == false) throw new ArgumentException("Type must be an Enum.");
        _enumType = value;
      }
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
      var enumValues = Enum.GetValues(EnumType);
      return (from object enumValue in enumValues select new EnumerationMember { Value = enumValue, Description = ((Enum)enumValue).EnumToString() }).ToArray();
    }

    public class EnumerationMember
    {
      public string Description { get; set; }
      public object Value { get; set; }
    }

  }
}
