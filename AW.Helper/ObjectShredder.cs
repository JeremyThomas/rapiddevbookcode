using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;

namespace AW.Helper
{
  public delegate IEnumerable<PropertyDescriptor> PropertyDescriptorGenerator(Type type);

  /// <summary>
  ///   How to: Implement CopyToDataTable Where the Enumerable Item Type Is Not a DataRow.
  /// </summary>
  /// <see cref="http://msdn.microsoft.com/en-us/library/bb669096.aspx" />
  public class ObjectShredder
  {
    public enum ShreddingMode
    {
      AllFields,
      NonSerializableAsString,
      Safe
    }
    protected IEnumerable<PropertyDescriptor> Pd;
    protected readonly Dictionary<string, int> OrdinalMap;
    protected Type Type;
    protected PropertyDescriptorGenerator PropertyDescriptorGenerator;
    private readonly ShreddingMode _shreddingMode;

    /// <summary>
    ///   Initializes a new instance of the <see cref="ObjectShredder" /> class.
    /// </summary>
    /// <param name="propertyDescriptorGenerator">The property descriptor generator.</param>
    /// <param name="shreddingMode">if set to <c>true</c> [safe mode].</param>
    public ObjectShredder(PropertyDescriptorGenerator propertyDescriptorGenerator = null, ShreddingMode shreddingMode = ShreddingMode.AllFields)
    {
      PropertyDescriptorGenerator = propertyDescriptorGenerator;
      _shreddingMode = shreddingMode;
      OrdinalMap = new Dictionary<string, int>();
    }

    public void SetType(IEnumerable source)
    {
      if (Type == null)
      {
        Type = MetaDataHelper.GetEnumerableItemType(source);
        SetProperties(Type);
      }
    }

    protected void SetProperties(Type type)
    {
      Pd = GetProperties(type);
    }

    private IEnumerable<PropertyDescriptor> GetProperties(Type type)
    {
      return PropertyDescriptorGenerator == null ? TypeDescriptor.GetProperties(type).Cast<PropertyDescriptor>() : PropertyDescriptorGenerator(type);
    }

    /// <summary>
    ///   Loads a DataTable from a sequence of objects.
    /// </summary>
    /// <param name="source">The sequence of objects to load into the DataTable.</param>
    /// <param name="table">
    ///   The input table. The schema of the table must match that
    ///   the type T.  If the table is null, a new table is created with a schema
    ///   created from the public properties and fields of the type T.
    /// </param>
    /// <param name="options">
    ///   Specifies how values from the source sequence will be applied to
    ///   existing rows in the table.
    /// </param>
    /// <returns>A DataTable created from the source sequence.</returns>
    public DataTable Shred(IEnumerable source, DataTable table, LoadOption? options)
    {
      SetType(source);
      // Load the table from the scalar sequence if _type is a primitive type.
      if (ValueTypeWrapper.TypeNeedsWrappingForBinding(Type))
        return ShredPrimitive(source, table, options);

      // Create a new table if the input table is null.
      if (table == null)
        table = new DataTable(Type.Name);

      // Initialize the ordinal map and extend the table schema based on type T.
      table = ExtendTable(table, Type);

      // Enumerate the source sequence and load the object values into rows.
      table.BeginLoadData();
      var e = source.GetEnumerator();
      {
        while (e.MoveNext())
        {
          if (options != null)
            table.LoadDataRow(ShredObject(table, e.Current), (LoadOption) options);
          else
            table.LoadDataRow(ShredObject(table, e.Current), true);
        }
      }
      table.EndLoadData();

      // Return the table.
      return table;
    }

    public DataTable ShredPrimitive(IEnumerable source, DataTable table, LoadOption? options)
    {
      SetType(source);
      // Create a new table if the input table is null.
      if (table == null)
        table = new DataTable(Type.Name);

      if (!table.Columns.Contains("Value"))
        table.Columns.Add("Value", Type);

      // Enumerate the source sequence and load the scalar values into rows.
      table.BeginLoadData();
      var e = source.GetEnumerator();
      {
        var values = new object[table.Columns.Count];
        while (e.MoveNext())
        {
          values[table.Columns["Value"].Ordinal] = e.Current;

          if (options != null)
            table.LoadDataRow(values, (LoadOption) options);
          else
            table.LoadDataRow(values, true);
        }
      }
      table.EndLoadData();

      // Return the table.
      return table;
    }

    private object[] ShredObject(DataTable table, object instance)
    {
      var type = instance.GetType();
      if (type != Type)
      {
        // If the instance is derived from T, extend the table schema
        // and get the properties and fields.
        ExtendTable(table, type);
        SetProperties(type);
      }

      // Add the property and field values of the instance to an array.
      var values = new object[table.Columns.Count];
      var stringType = typeof (string);
      foreach (var p in GetProperties(type))
        try
        {
          var value = p.GetValue(instance);
          var ordinal = OrdinalMap[p.Name];
          if (_shreddingMode== ShreddingMode.AllFields)
          {
            values[ordinal] = value;
          }
          else
          {
            if (table.Columns[ordinal].DataType == stringType)
              values[ordinal] = MetaDataHelper.ConvertToIdentifiableString(value);
            else
            {
              values[ordinal] = value;
            }
          }
        }
        catch (Exception e)
        {
          e.TraceOut();
        }

      // Return the property and field values of the instance.
      return values;
    }

    private DataTable ExtendTable(DataTable table, Type type)
    {
      // Extend the table schema if the input table was null or if the value 
      // in the sequence is derived from type T.            
      foreach (var p in GetProperties(type))
      {
        if (!OrdinalMap.ContainsKey(p.Name))
        {
          // Add the property as a column in the table if it doesn't exist
          // already.
          var dc = table.Columns.Contains(p.Name)
            ? table.Columns[p.Name]
            : table.Columns.Add(p.Name, GetColumnType(p));

          // Add the property to the ordinal map.
          OrdinalMap.Add(p.Name, dc.Ordinal);
        }
      }

      // Return the table.
      return table;
    }

    private Type GetColumnType(PropertyDescriptor p)
    {
      var columnType = MetaDataHelper.GetCoreType(p.PropertyType);
      if (_shreddingMode == ShreddingMode.AllFields)
        return columnType;
      if (columnType.IsValueType)
        return columnType;
      if (Type.GetTypeCode(columnType) == TypeCode.Object)
        return typeof (string);
      return columnType;
    }
  }

  internal class ObjectShredder<T> : ObjectShredder
  {
    // ObjectShredder constructor.
    public ObjectShredder(PropertyDescriptorGenerator propertyDescriptorGenerator)
      : base(propertyDescriptorGenerator)
    {
      Type = typeof (T);
      SetProperties(Type);
    }
  }
}