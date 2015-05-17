using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.Linq;

namespace AW.Helper
{
  /// <summary>
  ///   Author : Ravinder Vuppula.
  ///   Purpose : To implement binary serialization of the DataSet through a Surrogate object./
  ///   Notes:
  ///   1. All the surrogate objects DataSetSurrogate, DataTableSurrogate, DataColumnSurrogate are marked [Serializable] and
  ///   hence will get automatically serialized by the remoting framework.
  ///   2. The data is serialized in binary "column" wise.
  ///   3. This class can be used as a wrapper around DataSet. A DataSetSurrogate object can be constructed from DataSet and
  ///   vice-versa. This helps if the user wants to wrap the DataSet in DataSetSurrogate and serialize and deserialize
  ///   DataSetSurrogate instead.
  ///   History:
  ///   05/10/04 - Fix for the  issue of serializing default values.
  /// </summary>
  /// <see cref="http://support.microsoft.com/default.aspx?scid=kb;en-us;829740" />
  /// <see cref="http://msdn.microsoft.com/en-us/library/microsoft.synchronization.data.datatablesurrogate(SQL.105).aspx" />
  [Serializable]
  public class DataSetSurrogate : IEnumerable
  {
    //DataSet properties
    private readonly string _datasetName;
    private readonly string _namespace;
    private readonly string _prefix;
    private readonly bool _caseSensitive;
    private readonly CultureInfo _locale;
    private readonly bool _enforceConstraints;

    //ForeignKeyConstraints
    private readonly ArrayList _fkConstraints; //An ArrayList of foreign key constraints :  [constraintName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[AcceptRejectRule, UpdateRule, Delete]->[extendedProperties]

    //Relations
    private readonly ArrayList _relations; //An ArrayList of foreign key constraints : [relationName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[Nested]->[extendedProperties]

    //ExtendedProperties
    private readonly Hashtable _extendedProperties;

    //Columns and Rows
    private readonly DataTableSurrogate[] _dataTableSurrogates;

/*
    Constructs a DataSetSurrogate object from a DataSet.
*/

    public DataSetSurrogate(DataSet ds)
    {
      if (ds == null)
      {
        throw new ArgumentNullException("ds");
      }

      //DataSet properties
      _datasetName = ds.DataSetName;
      _namespace = ds.Namespace;
      _prefix = ds.Prefix;
      _caseSensitive = ds.CaseSensitive;
      _locale = ds.Locale;
      _enforceConstraints = ds.EnforceConstraints;

      //Tables, Columns, Rows
      _dataTableSurrogates = new DataTableSurrogate[ds.Tables.Count];
      for (var i = 0; i < ds.Tables.Count; i++)
      {
        _dataTableSurrogates[i] = new DataTableSurrogate(ds.Tables[i]);
      }

      //ForeignKeyConstraints
      _fkConstraints = GetForeignKeyConstraints(ds);

      //Relations
      _relations = GetRelations(ds);

      //ExtendedProperties
      _extendedProperties = new Hashtable();
      if (ds.ExtendedProperties.Keys.Count > 0)
      {
        foreach (var propertyKey in ds.ExtendedProperties.Keys)
        {
          _extendedProperties.Add(propertyKey, ds.ExtendedProperties[propertyKey]);
        }
      }
    }

/*
    Constructs a DataSet from the DataSetSurrogate object. This can be used after the user recieves a Surrogate object over the wire and wished to construct a DataSet from it.
*/

    public DataSet ConvertToDataSet()
    {
      var ds = new DataSet();
      ReadSchemaIntoDataSet(ds);
      ReadDataIntoDataSet(ds);
      return ds;
    }

/*
    Reads the schema into the dataset from the DataSetSurrogate object.
*/

    public void ReadSchemaIntoDataSet(DataSet ds)
    {
      if (ds == null)
      {
        throw new ArgumentNullException("ds");
      }

      //DataSet properties
      ds.DataSetName = _datasetName;
      ds.Namespace = _namespace;
      ds.Prefix = _prefix;
      ds.CaseSensitive = _caseSensitive;
      ds.Locale = _locale;
      ds.EnforceConstraints = _enforceConstraints;

      //Tables, Columns
      Debug.Assert(_dataTableSurrogates != null);
      foreach (var dataTableSurrogate in _dataTableSurrogates)
      {
        var dt = new DataTable();
        dataTableSurrogate.ReadSchemaIntoDataTable(dt);
        ds.Tables.Add(dt);
      }

      //ForeignKeyConstraints
      SetForeignKeyConstraints(ds, _fkConstraints);

      //Relations
      SetRelations(ds, _relations);

      //Set ExpressionColumns        
      Debug.Assert(_dataTableSurrogates != null);
      Debug.Assert(ds.Tables.Count == _dataTableSurrogates.Length);
      for (var i = 0; i < ds.Tables.Count; i++)
      {
        var dt = ds.Tables[i];
        var dataTableSurrogate = _dataTableSurrogates[i];
        dataTableSurrogate.SetColumnExpressions(dt);
      }

      //ExtendedProperties
      Debug.Assert(_extendedProperties != null);
      if (_extendedProperties.Keys.Count > 0)
      {
        foreach (var propertyKey in _extendedProperties.Keys)
        {
          ds.ExtendedProperties.Add(propertyKey, _extendedProperties[propertyKey]);
        }
      }
    }

/*
    Reads the data into the dataset from the DataSetSurrogate object.
*/

    public void ReadDataIntoDataSet(DataSet ds)
    {
      if (ds == null)
      {
        throw new ArgumentNullException("ds");
      }

      //Suppress  read-only columns and constraint rules when loading the data
      var readOnlyList = SuppressReadOnly(ds);
      var constraintRulesList = SuppressConstraintRules(ds);

      //Rows
      Debug.Assert(IsSchemaIdentical(ds));
      Debug.Assert(_dataTableSurrogates != null);
      Debug.Assert(ds.Tables.Count == _dataTableSurrogates.Length);
      var enforceConstraints = ds.EnforceConstraints;
      ds.EnforceConstraints = false;
      for (var i = 0; i < ds.Tables.Count; i++)
      {
        var dataTableSurrogate = _dataTableSurrogates[i];
        dataTableSurrogate.ReadDataIntoDataTable(ds.Tables[i], false);
      }
      ds.EnforceConstraints = enforceConstraints;

      //Reset read-only columns and constraint rules back after loading the data
      ResetReadOnly(ds, readOnlyList);
      ResetConstraintRules(ds, constraintRulesList);
    }

/*
    Gets foreignkey constraints availabe on the tables in the dataset.
    ***Serialized foreign key constraints format : [constraintName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[AcceptRejectRule, UpdateRule, Delete]->[extendedProperties]***
*/

    private static ArrayList GetForeignKeyConstraints(DataSet ds)
    {
      Debug.Assert(ds != null);

      var constraintList = new ArrayList();
      for (var i = 0; i < ds.Tables.Count; i++)
      {
        var dt = ds.Tables[i];
        for (var j = 0; j < dt.Constraints.Count; j++)
        {
          var c = dt.Constraints[j];
          var fk = c as ForeignKeyConstraint;
          if (fk != null)
          {
            var constraintName = c.ConstraintName;
            var parentInfo = new int[fk.RelatedColumns.Length + 1];
            parentInfo[0] = ds.Tables.IndexOf(fk.RelatedTable);
            for (var k = 1; k < parentInfo.Length; k++)
            {
              parentInfo[k] = fk.RelatedColumns[k - 1].Ordinal;
            }

            var childInfo = new int[fk.Columns.Length + 1];
            childInfo[0] = i; //Since the constraint is on the current table, this is the child table.
            for (var k = 1; k < childInfo.Length; k++)
            {
              childInfo[k] = fk.Columns[k - 1].Ordinal;
            }

            var list = new ArrayList {constraintName, parentInfo, childInfo, new[] {(int) fk.AcceptRejectRule, (int) fk.UpdateRule, (int) fk.DeleteRule}};
            var extendedProperties = new Hashtable();
            if (fk.ExtendedProperties.Keys.Count > 0)
            {
              foreach (var propertyKey in fk.ExtendedProperties.Keys)
              {
                extendedProperties.Add(propertyKey, fk.ExtendedProperties[propertyKey]);
              }
            }
            list.Add(extendedProperties);

            constraintList.Add(list);
          }
        }
      }
      return constraintList;
    }

/*
    Adds foreignkey constraints to the tables in the dataset. The arraylist contains the serialized format of the foreignkey constraints.
    ***Deserialize the foreign key constraints format : [constraintName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[AcceptRejectRule, UpdateRule, Delete]->[extendedProperties]***
*/

    private static void SetForeignKeyConstraints(DataSet ds, ArrayList constraintList)
    {
      Debug.Assert(ds != null);
      Debug.Assert(constraintList != null);

      foreach (ArrayList list in constraintList)
      {
        Debug.Assert(list.Count == 5);
        var constraintName = (string) list[0];
        var parentInfo = (int[]) list[1];
        var childInfo = (int[]) list[2];
        var rules = (int[]) list[3];
        var extendedProperties = (Hashtable) list[4];

        //ParentKey Columns.
        Debug.Assert(parentInfo.Length >= 1);
        var parentkeyColumns = new DataColumn[parentInfo.Length - 1];
        for (var i = 0; i < parentkeyColumns.Length; i++)
        {
          Debug.Assert(ds.Tables.Count > parentInfo[0]);
          Debug.Assert(ds.Tables[parentInfo[0]].Columns.Count > parentInfo[i + 1]);
          parentkeyColumns[i] = ds.Tables[parentInfo[0]].Columns[parentInfo[i + 1]];
        }

        //ChildKey Columns.
        Debug.Assert(childInfo.Length >= 1);
        var childkeyColumns = new DataColumn[childInfo.Length - 1];
        for (var i = 0; i < childkeyColumns.Length; i++)
        {
          Debug.Assert(ds.Tables.Count > childInfo[0]);
          Debug.Assert(ds.Tables[childInfo[0]].Columns.Count > childInfo[i + 1]);
          childkeyColumns[i] = ds.Tables[childInfo[0]].Columns[childInfo[i + 1]];
        }

        //Create the Constraint.
        var fk = new ForeignKeyConstraint(constraintName, parentkeyColumns, childkeyColumns);
        Debug.Assert(rules.Length == 3);
        fk.AcceptRejectRule = (AcceptRejectRule) rules[0];
        fk.UpdateRule = (Rule) rules[1];
        fk.DeleteRule = (Rule) rules[2];

        //Extended Properties.
        Debug.Assert(extendedProperties != null);
        if (extendedProperties.Keys.Count > 0)
        {
          foreach (var propertyKey in extendedProperties.Keys)
          {
            fk.ExtendedProperties.Add(propertyKey, extendedProperties[propertyKey]);
          }
        }

        //Add the constraint to the child datatable.
        Debug.Assert(ds.Tables.Count > childInfo[0]);
        ds.Tables[childInfo[0]].Constraints.Add(fk);
      }
    }

/*
    Gets relations from the dataset.
    ***Serialized relations format : [relationName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[Nested]->[extendedProperties]***
*/

    private static ArrayList GetRelations(DataSet ds)
    {
      Debug.Assert(ds != null);

      var relationList = new ArrayList();
      foreach (DataRelation rel in ds.Relations)
      {
        var relationName = rel.RelationName;
        var parentInfo = new int[rel.ParentColumns.Length + 1];
        parentInfo[0] = ds.Tables.IndexOf(rel.ParentTable);
        for (var j = 1; j < parentInfo.Length; j++)
        {
          parentInfo[j] = rel.ParentColumns[j - 1].Ordinal;
        }

        var childInfo = new int[rel.ChildColumns.Length + 1];
        childInfo[0] = ds.Tables.IndexOf(rel.ChildTable);
        for (var j = 1; j < childInfo.Length; j++)
        {
          childInfo[j] = rel.ChildColumns[j - 1].Ordinal;
        }

        var list = new ArrayList {relationName, parentInfo, childInfo, rel.Nested};
        var extendedProperties = new Hashtable();
        if (rel.ExtendedProperties.Keys.Count > 0)
        {
          foreach (var propertyKey in rel.ExtendedProperties.Keys)
          {
            extendedProperties.Add(propertyKey, rel.ExtendedProperties[propertyKey]);
          }
        }
        list.Add(extendedProperties);

        relationList.Add(list);
      }
      return relationList;
    }

/*
    Adds relations to the dataset. The arraylist contains the serialized format of the relations.
    ***Deserialize the relations format : [relationName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[Nested]->[extendedProperties]***
*/

    private static void SetRelations(DataSet ds, ArrayList relationList)
    {
      Debug.Assert(ds != null);
      Debug.Assert(relationList != null);

      foreach (ArrayList list in relationList)
      {
        Debug.Assert(list.Count == 5);
        var relationName = (string) list[0];
        var parentInfo = (int[]) list[1];
        var childInfo = (int[]) list[2];
        var isNested = (bool) list[3];
        var extendedProperties = (Hashtable) list[4];

        //ParentKey Columns.
        Debug.Assert(parentInfo.Length >= 1);
        var parentkeyColumns = new DataColumn[parentInfo.Length - 1];
        for (var i = 0; i < parentkeyColumns.Length; i++)
        {
          Debug.Assert(ds.Tables.Count > parentInfo[0]);
          Debug.Assert(ds.Tables[parentInfo[0]].Columns.Count > parentInfo[i + 1]);
          parentkeyColumns[i] = ds.Tables[parentInfo[0]].Columns[parentInfo[i + 1]];
        }

        //ChildKey Columns.
        Debug.Assert(childInfo.Length >= 1);
        var childkeyColumns = new DataColumn[childInfo.Length - 1];
        for (var i = 0; i < childkeyColumns.Length; i++)
        {
          Debug.Assert(ds.Tables.Count > childInfo[0]);
          Debug.Assert(ds.Tables[childInfo[0]].Columns.Count > childInfo[i + 1]);
          childkeyColumns[i] = ds.Tables[childInfo[0]].Columns[childInfo[i + 1]];
        }

        //Create the Relation, without any constraints[Assumption: The constraints are added earlier than the relations]
        var rel = new DataRelation(relationName, parentkeyColumns, childkeyColumns, false) {Nested = isNested};

        //Extended Properties.
        Debug.Assert(extendedProperties != null);
        if (extendedProperties.Keys.Count > 0)
        {
          foreach (var propertyKey in extendedProperties.Keys)
          {
            rel.ExtendedProperties.Add(propertyKey, extendedProperties[propertyKey]);
          }
        }

        //Add the relations to the dataset.
        ds.Relations.Add(rel);
      }
    }

/*
    Suppress the read-only property and returns an arraylist of read-only columns.
*/

    private static ArrayList SuppressReadOnly(DataSet ds)
    {
      Debug.Assert(ds != null);

      var readOnlyList = new ArrayList();
      for (var i = 0; i < ds.Tables.Count; i++)
      {
        var dt = ds.Tables[i];
        for (var j = 0; j < dt.Columns.Count; j++)
        {
          if (dt.Columns[j].Expression == String.Empty && dt.Columns[j].ReadOnly)
          {
            dt.Columns[j].ReadOnly = false;
            readOnlyList.Add(new[] {i, j});
          }
        }
      }
      return readOnlyList;
    }

/*
    Suppress the foreign key constraint rules and returns an arraylist of the existing foreignkey constraint rules.
*/

    private static ArrayList SuppressConstraintRules(DataSet ds)
    {
      Debug.Assert(ds != null);

      var constraintRulesList = new ArrayList();
      for (var i = 0; i < ds.Tables.Count; i++)
      {
        var dtChild = ds.Tables[i];
        for (var j = 0; j < dtChild.Constraints.Count; j++)
        {
          var c = dtChild.Constraints[j];
          var foreignKeyConstraint = c as ForeignKeyConstraint;
          if (foreignKeyConstraint != null)
          {
            var fk = foreignKeyConstraint;
            var list = new ArrayList {new[] {i, j}, new[] {(int) fk.AcceptRejectRule, (int) fk.UpdateRule, (int) fk.DeleteRule}};
            constraintRulesList.Add(list);

            fk.AcceptRejectRule = AcceptRejectRule.None;
            fk.UpdateRule = Rule.None;
            fk.DeleteRule = Rule.None;
          }
        }
      }
      return constraintRulesList;
    }

/*
    Resets the read-only columns on the datatable based on the input readOnly list.
*/

    private static void ResetReadOnly(DataSet ds, IEnumerable readOnlyList)
    {
      Debug.Assert(ds != null);
      Debug.Assert(readOnlyList != null);

      foreach (var indicesArr in readOnlyList.Cast<int[]>())
      {
        Debug.Assert(indicesArr.Length == 2);
        var tableIndex = indicesArr[0];
        var columnIndex = indicesArr[1];

        Debug.Assert(ds.Tables.Count > tableIndex);
        Debug.Assert(ds.Tables[tableIndex].Columns.Count > columnIndex);

        var dc = ds.Tables[tableIndex].Columns[columnIndex];
        Debug.Assert(dc != null);

        dc.ReadOnly = true;
      }
    }

/*
    Resets the foreignkey constraint rules on the dataset based on the input constraint rules list.
*/

    private static void ResetConstraintRules(DataSet ds, ArrayList constraintRulesList)
    {
      Debug.Assert(ds != null);
      Debug.Assert(constraintRulesList != null);

      foreach (ArrayList list in constraintRulesList)
      {
        Debug.Assert(list.Count == 2);
        var indicesArr = (int[]) list[0];
        var rules = (int[]) list[1];

        Debug.Assert(indicesArr.Length == 2);
        var tableIndex = indicesArr[0];
        var constraintIndex = indicesArr[1];

        Debug.Assert(ds.Tables.Count > tableIndex);
        var dtChild = ds.Tables[tableIndex];

        Debug.Assert(dtChild.Constraints.Count > constraintIndex);
        var fk = (ForeignKeyConstraint) dtChild.Constraints[constraintIndex];

        Debug.Assert(rules.Length == 3);
        fk.AcceptRejectRule = (AcceptRejectRule) rules[0];
        fk.UpdateRule = (Rule) rules[1];
        fk.DeleteRule = (Rule) rules[2];
      }
    }

/*
    Checks whether the dataset name and namespaces are as expected and the tables count is right.
*/

    private bool IsSchemaIdentical(DataSet ds)
    {
      Debug.Assert(ds != null);
      if (ds.DataSetName != _datasetName || ds.Namespace != _namespace)
      {
        return false;
      }
      Debug.Assert(_dataTableSurrogates != null);
      if (ds.Tables.Count != _dataTableSurrogates.Length)
      {
        return false;
      }
      return true;
    }

    #region Implementation of IEnumerable

    /// <summary>
    ///   Returns an enumerator that iterates through a collection.
    /// </summary>
    /// <returns>
    ///   An <see cref="T:System.Collections.IEnumerator" /> object that can be used to iterate through the collection.
    /// </returns>
    /// <filterpriority>2</filterpriority>
    public IEnumerator GetEnumerator()
    {
      return new DataTableSurrogateEnumerator(_dataTableSurrogates);
    }

    #endregion
  }

  public class DataTableSurrogateEnumerator : IEnumerator
  {
    private readonly DataTableSurrogate[] _dataTableSurrogates;
    private int _position = -1;

    public DataTableSurrogateEnumerator(DataTableSurrogate[] dataTableSurrogates)
    {
      _dataTableSurrogates = dataTableSurrogates;
    }

    #region Implementation of IEnumerator

    /// <summary>
    ///   Advances the enumerator to the next element of the collection.
    /// </summary>
    /// <returns>
    ///   true if the enumerator was successfully advanced to the next element; false if the enumerator has passed the end of
    ///   the collection.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">
    ///   The collection was modified after the enumerator was created.
    /// </exception>
    /// <filterpriority>2</filterpriority>
    public bool MoveNext()
    {
      _position++;
      return (_position < _dataTableSurrogates.Length);
    }

    /// <summary>
    ///   Sets the enumerator to its initial position, which is before the first element in the collection.
    /// </summary>
    /// <exception cref="T:System.InvalidOperationException">
    ///   The collection was modified after the enumerator was created.
    /// </exception>
    /// <filterpriority>2</filterpriority>
    public void Reset()
    {
      _position = -1;
    }

    /// <summary>
    ///   Gets the current element in the collection.
    /// </summary>
    /// <returns>
    ///   The current element in the collection.
    /// </returns>
    /// <exception cref="T:System.InvalidOperationException">
    ///   The enumerator is positioned before the first element of the collection or after the last element.
    /// </exception>
    /// <filterpriority>2</filterpriority>
    public object Current
    {
      get
      {
        try
        {
          return _dataTableSurrogates[_position];
        }
        catch (IndexOutOfRangeException)
        {
          throw new InvalidOperationException();
        }
      }
    }

    #endregion
  }


  [Serializable]
  public class DataTableSurrogate
  {
    //DataTable properties
    private readonly string _tableName;
    private readonly string _namespace;
    private readonly string _prefix;
    private readonly bool _caseSensitive;
    private readonly CultureInfo _locale;
    private readonly string _displayExpression;
    private readonly int _minimumCapacity;

    //Columns
    private readonly DataColumnSurrogate[] _dataColumnSurrogates;

    //Constraints
    private readonly ArrayList _uniqueConstraints; //An ArrayList of unique constraints : [constraintName]->[columnIndexes]->[IsPrimaryKey]->[extendedProperties]

    //ExtendedProperties
    private readonly Hashtable _extendedProperties;

    //Rows
    private readonly BitArray _rowStates; //The 4 rowstates[Unchanged, Added, Modified, Deleted] are represented with 2 bits. The length of the BitArray will be twice the size of the number of rows.
    private readonly object[][] _records; //As many object[] as there are number of columns. Always send 2 records for 1 row. TradeOff between memory vs. performance. Time intensive to find which records are modified.
    private readonly Hashtable _rowErrors = new Hashtable(); //Keep a map between the row index and the row error
    private readonly Hashtable _colErrors = new Hashtable(); //Keep a map between the row index and the Arraylist of columns that are in error and the error strings.

/*
    Constructs a DataTableSurrogate from a DataTable.
*/

    public DataTableSurrogate(DataTable dt)
    {
      if (dt == null)
      {
        throw new ArgumentNullException("dt");
      }

      _tableName = dt.TableName;
      _namespace = dt.Namespace;
      _prefix = dt.Prefix;
      _caseSensitive = dt.CaseSensitive;
      _locale = dt.Locale;
      _displayExpression = dt.DisplayExpression;
      _minimumCapacity = dt.MinimumCapacity;

      //Columns
      _dataColumnSurrogates = new DataColumnSurrogate[dt.Columns.Count];
      for (var i = 0; i < dt.Columns.Count; i++)
      {
        _dataColumnSurrogates[i] = new DataColumnSurrogate(dt.Columns[i]);
      }

      //Constraints
      _uniqueConstraints = GetUniqueConstraints(dt);

      //ExtendedProperties
      _extendedProperties = new Hashtable();
      if (dt.ExtendedProperties.Keys.Count > 0)
      {
        foreach (var propertyKey in dt.ExtendedProperties.Keys)
        {
          _extendedProperties.Add(propertyKey, dt.ExtendedProperties[propertyKey]);
        }
      }

      //Rows
      if (dt.Rows.Count > 0)
      {
        _rowStates = new BitArray(dt.Rows.Count << 1);
        _records = new object[dt.Columns.Count][];
        for (var i = 0; i < dt.Columns.Count; i++)
        {
          _records[i] = new object[dt.Rows.Count << 1];
        }
        for (var i = 0; i < dt.Rows.Count; i++)
        {
          GetRecords(dt.Rows[i], i << 1);
        }
      }
    }

/*
    Constructs a DataTable from DataTableSurrogate. 
*/

    public DataTable ConvertToDataTable()
    {
      var dt = new DataTable();
      ReadSchemaIntoDataTable(dt);
      ReadDataIntoDataTable(dt);
      return dt;
    }

/*
    Reads the schema into the datatable from DataTableSurrogate. 
*/

    public void ReadSchemaIntoDataTable(DataTable dt)
    {
      if (dt == null)
      {
        throw new ArgumentNullException("dt");
      }

      dt.TableName = _tableName;
      dt.Namespace = _namespace;
      dt.Prefix = _prefix;
      dt.CaseSensitive = _caseSensitive;
      dt.Locale = _locale;
      dt.DisplayExpression = _displayExpression;
      dt.MinimumCapacity = _minimumCapacity;

      Debug.Assert(_dataColumnSurrogates != null);
      foreach (var dc in _dataColumnSurrogates.Select(dataColumnSurrogate => dataColumnSurrogate.ConvertToDataColumn()))
      {
        dt.Columns.Add(dc);
      }

      //UniqueConstraints
      SetUniqueConstraints(dt, _uniqueConstraints);

      //Extended properties
      Debug.Assert(_extendedProperties != null);
      if (_extendedProperties.Keys.Count > 0)
      {
        foreach (var propertyKey in _extendedProperties.Keys)
        {
          dt.ExtendedProperties.Add(propertyKey, _extendedProperties[propertyKey]);
        }
      }
    }

/*
    Reads the data into a DataTable from DataTableSurrogate. 
*/

    public void ReadDataIntoDataTable(DataTable dt)
    {
      ReadDataIntoDataTable(dt, true);
    }

/*
    Copies the rows into a DataTable from DataTableSurrogate. 
*/

    internal void ReadDataIntoDataTable(DataTable dt, bool suppressSchema)
    {
      if (dt == null)
      {
        throw new ArgumentNullException("dt");
      }
      Debug.Assert(IsSchemaIdentical(dt));

      //Suppress read-only and constraint rules while loading the data.
      ArrayList readOnlyList = null;
      ArrayList constraintRulesList = null;
      if (suppressSchema)
      {
        readOnlyList = SuppressReadOnly(dt);
        constraintRulesList = SuppressConstraintRules(dt);
      }

      //Read the rows
      if (_records != null && dt.Columns.Count > 0)
      {
        Debug.Assert(_records.Length > 0);
        var rowCount = _records[0].Length >> 1;
        for (var i = 0; i < rowCount; i++)
        {
          ConvertToDataRow(dt, i << 1);
        }
      }

      //Reset read-only column and constraint rules back after loading the data.
      if (suppressSchema)
      {
        ResetReadOnly(dt, readOnlyList);
        ResetConstraintRules(dt, constraintRulesList);
      }
    }

/*
    Gets unique constraints availabe on the datatable.
    ***Serialized unique constraints format : [constraintName]->[columnIndexes]->[IsPrimaryKey]->[extendedProperties]***
*/

    private static ArrayList GetUniqueConstraints(DataTable dt)
    {
      Debug.Assert(dt != null);

      var constraintList = new ArrayList();
      for (var i = 0; i < dt.Constraints.Count; i++)
      {
        var c = dt.Constraints[i];
        var uc = c as UniqueConstraint;
        if (uc != null)
        {
          var constraintName = c.ConstraintName;
          var colInfo = new int[uc.Columns.Length];
          for (var j = 0; j < colInfo.Length; j++)
          {
            colInfo[j] = uc.Columns[j].Ordinal;
          }

          var list = new ArrayList {constraintName, colInfo, uc.IsPrimaryKey};
          var extendedProperties = new Hashtable();
          if (uc.ExtendedProperties.Keys.Count > 0)
          {
            foreach (var propertyKey in uc.ExtendedProperties.Keys)
            {
              extendedProperties.Add(propertyKey, uc.ExtendedProperties[propertyKey]);
            }
          }
          list.Add(extendedProperties);

          constraintList.Add(list);
        }
      }
      return constraintList;
    }

/*
    Adds unique constraints to the table. The arraylist contains the serialized format of the unique constraints.
    ***Deserialize the unique constraints format : [constraintName]->[columnIndexes]->[IsPrimaryKey]->[extendedProperties]***
*/

    private static void SetUniqueConstraints(DataTable dt, ArrayList constraintList)
    {
      Debug.Assert(dt != null);
      Debug.Assert(constraintList != null);

      foreach (ArrayList list in constraintList)
      {
        Debug.Assert(list.Count == 4);
        var constraintName = (string) list[0];
        var keyColumnIndexes = (int[]) list[1];
        var isPrimaryKey = (bool) list[2];
        var extendedProperties = (Hashtable) list[3];

        var keyColumns = new DataColumn[keyColumnIndexes.Length];
        for (var i = 0; i < keyColumnIndexes.Length; i++)
        {
          Debug.Assert(dt.Columns.Count > keyColumnIndexes[i]);
          keyColumns[i] = dt.Columns[keyColumnIndexes[i]];
        }
        //Create the constraint.
        var uc = new UniqueConstraint(constraintName, keyColumns, isPrimaryKey);
        //Extended Properties.
        Debug.Assert(extendedProperties != null);
        if (extendedProperties.Keys.Count > 0)
        {
          foreach (var propertyKey in extendedProperties.Keys)
          {
            uc.ExtendedProperties.Add(propertyKey, extendedProperties[propertyKey]);
          }
        }
        dt.Constraints.Add(uc);
      }
    }

/*
    Sets  expression on the columns.
*/

    internal void SetColumnExpressions(DataTable dt)
    {
      Debug.Assert(dt != null);

      Debug.Assert(_dataColumnSurrogates != null);
      Debug.Assert(dt.Columns.Count == _dataColumnSurrogates.Length);
      for (var i = 0; i < dt.Columns.Count; i++)
      {
        var dc = dt.Columns[i];
        var dataColumnSurrogate = _dataColumnSurrogates[i];
        dataColumnSurrogate.SetColumnExpression(dc);
      }
    }

/*
    Gets the records from the rows.
*/

    private void GetRecords(DataRow row, int bitIndex)
    {
      Debug.Assert(row != null);

      ConvertToSurrogateRowState(row.RowState, bitIndex);
      ConvertToSurrogateRecords(row, bitIndex);
      ConvertToSurrogateRowError(row, bitIndex >> 1);
    }

/*
    Constructs the row, rowError and columnErrors.
*/

    public DataRow ConvertToDataRow(DataTable dt, int bitIndex)
    {
      var rowState = ConvertToRowState(bitIndex);
      var row = ConstructRow(dt, rowState, bitIndex);
      ConvertToRowError(row, bitIndex >> 1);
      return row;
    }

/*
    Sets the two bits in the bitArray to represent the DataRowState.
    The 4 rowstates[Unchanged, Added, Modified, Deleted] are represented with 2 bits. The length of the BitArray will be twice the size of the number of rows.
    Serialozed rowstate format : [00]->UnChanged, [01]->Added, [10]->Modified, [11]->Deleted.
*/

    private void ConvertToSurrogateRowState(DataRowState rowState, int bitIndex)
    {
      Debug.Assert(_rowStates != null);
      Debug.Assert(_rowStates.Length > bitIndex);

      switch (rowState)
      {
        case DataRowState.Unchanged:
          _rowStates[bitIndex] = false;
          _rowStates[bitIndex + 1] = false;
          break;
        case DataRowState.Added:
          _rowStates[bitIndex] = false;
          _rowStates[bitIndex + 1] = true;
          break;
        case DataRowState.Modified:
          _rowStates[bitIndex] = true;
          _rowStates[bitIndex + 1] = false;
          break;
        case DataRowState.Deleted:
          _rowStates[bitIndex] = true;
          _rowStates[bitIndex + 1] = true;
          break;
        default:
          throw new InvalidEnumArgumentException(String.Format("Unrecognized row state {0}", rowState));
      }
    }

/*
    Constructs the RowState from the two bits in the bitarray.
    Deserialize rowstate format : [00]->UnChanged, [01]->Added, [10]->Modified, [11]->Deleted.
*/

    private DataRowState ConvertToRowState(int bitIndex)
    {
      Debug.Assert(_rowStates != null);
      Debug.Assert(_rowStates.Length > bitIndex);

      var b1 = _rowStates[bitIndex];
      var b2 = _rowStates[bitIndex + 1];

      if (!b1 && !b2)
        return DataRowState.Unchanged;
      if (!b1)
        return DataRowState.Added;
      return !b2 ? DataRowState.Modified : DataRowState.Deleted;
    }

/*
    Constructs surrogate records from the DataRow.
*/

    private void ConvertToSurrogateRecords(DataRow row, int bitIndex)
    {
      Debug.Assert(row != null);
      Debug.Assert(_records != null);

      var colCount = row.Table.Columns.Count;
      var rowState = row.RowState;

      Debug.Assert(_records.Length == colCount);
      if (rowState != DataRowState.Added)
      {
        //Unchanged, modified, deleted     
        for (var i = 0; i < colCount; i++)
        {
          Debug.Assert(_records[i].Length > bitIndex);
          var originalValue = row[i, DataRowVersion.Original];
          if (originalValue.GetType().IsSerializable)
            _records[i][bitIndex] = originalValue;
          else
          {
            var typeConverter = TypeDescriptor.GetConverter(originalValue);
            _records[i][bitIndex] = typeConverter.ConvertToString(originalValue);
          }
        }
      }

      if (rowState != DataRowState.Unchanged && rowState != DataRowState.Deleted)
      {
        //Added, modified state
        for (var i = 0; i < colCount; i++)
        {
          Debug.Assert(_records[i].Length > bitIndex + 1);
          var currentVlue = row[i, DataRowVersion.Current];
          if (currentVlue.GetType().IsSerializable)
            _records[i][bitIndex + 1] = currentVlue;
        }
      }
    }

/*
    Constructs a DataRow from records[original and current] and adds the row to the DataTable rows collection.
*/

    private DataRow ConstructRow(DataTable dt, DataRowState rowState, int bitIndex)
    {
      Debug.Assert(dt != null);
      Debug.Assert(_records != null);

      var row = dt.NewRow();
      var colCount = dt.Columns.Count;

      Debug.Assert(_records.Length == colCount);
      switch (rowState)
      {
        case DataRowState.Unchanged:
          for (var i = 0; i < colCount; i++)
          {
            Debug.Assert(_records[i].Length > bitIndex);
            row[i] = _records[i][bitIndex]; //Original Record
          }
          dt.Rows.Add(row);
          row.AcceptChanges();
          break;
        case DataRowState.Added:
          for (var i = 0; i < colCount; i++)
          {
            Debug.Assert(_records[i].Length > bitIndex + 1);
            row[i] = _records[i][bitIndex + 1]; //Current Record
          }
          dt.Rows.Add(row);
          break;
        case DataRowState.Modified:
          for (var i = 0; i < colCount; i++)
          {
            Debug.Assert(_records[i].Length > bitIndex);
            row[i] = _records[i][bitIndex]; //Original Record
          }
          dt.Rows.Add(row);
          row.AcceptChanges();
          row.BeginEdit();
          for (var i = 0; i < colCount; i++)
          {
            Debug.Assert(_records[i].Length > bitIndex + 1);
            row[i] = _records[i][bitIndex + 1]; //Current Record
          }
          row.EndEdit();
          break;
        case DataRowState.Deleted:
          for (var i = 0; i < colCount; i++)
          {
            Debug.Assert(_records[i].Length > bitIndex);
            row[i] = _records[i][bitIndex]; //Original Record
          }
          dt.Rows.Add(row);
          row.AcceptChanges();
          row.Delete();
          break;
        default:
          throw new InvalidEnumArgumentException(String.Format("Unrecognized row state {0}", rowState));
      }
      return row;
    }

/*
    Constructs the surrogate rowerror, columnsInError and columnErrors.
*/

    private void ConvertToSurrogateRowError(DataRow row, int rowIndex)
    {
      Debug.Assert(row != null);
      Debug.Assert(_rowErrors != null);
      Debug.Assert(_colErrors != null);

      if (row.HasErrors)
      {
        _rowErrors.Add(rowIndex, row.RowError);
        var dcArr = row.GetColumnsInError();
        if (dcArr.Length > 0)
        {
          var columnsInError = new int[dcArr.Length];
          var columnErrors = new string[dcArr.Length];
          for (var i = 0; i < dcArr.Length; i++)
          {
            columnsInError[i] = dcArr[i].Ordinal;
            columnErrors[i] = row.GetColumnError(dcArr[i]);
          }
          var list = new ArrayList {columnsInError, columnErrors};
          _colErrors.Add(rowIndex, list);
        }
      }
    }

/*
    Set the row and columns in error.
*/

    private void ConvertToRowError(DataRow row, int rowIndex)
    {
      Debug.Assert(row != null);
      Debug.Assert(_rowErrors != null);
      Debug.Assert(_colErrors != null);

      if (_rowErrors.ContainsKey(rowIndex))
      {
        row.RowError = (string) _rowErrors[rowIndex];
      }
      if (_colErrors.ContainsKey(rowIndex))
      {
        var list = (ArrayList) _colErrors[rowIndex];
        var columnsInError = (int[]) list[0];
        var columnErrors = (string[]) list[1];
        Debug.Assert(columnsInError.Length == columnErrors.Length);
        for (var i = 0; i < columnsInError.Length; i++)
        {
          row.SetColumnError(columnsInError[i], columnErrors[i]);
        }
      }
    }

/*
    Suppress the read-only property and returns an arraylist of read-only columns.
*/

    private static ArrayList SuppressReadOnly(DataTable dt)
    {
      Debug.Assert(dt != null);
      var readOnlyList = new ArrayList();
      for (var j = 0; j < dt.Columns.Count; j++)
      {
        if (dt.Columns[j].Expression == String.Empty && dt.Columns[j].ReadOnly)
        {
          readOnlyList.Add(j);
        }
      }
      return readOnlyList;
    }

/*
    Suppress the foreign key constraint rules and returns an arraylist of the existing foreignkey constraint rules.
*/

    private static ArrayList SuppressConstraintRules(DataTable dt)
    {
      Debug.Assert(dt != null);
      var constraintRulesList = new ArrayList();
      var ds = dt.DataSet;
      if (ds != null)
      {
        for (var i = 0; i < ds.Tables.Count; i++)
        {
          var dtChild = ds.Tables[i];
          for (var j = 0; j < dtChild.Constraints.Count; j++)
          {
            var c = dtChild.Constraints[j];
            var foreignKeyConstraint = c as ForeignKeyConstraint;
            if (foreignKeyConstraint != null)
            {
              var fk = foreignKeyConstraint;
              if (fk.RelatedTable == dt)
              {
                var list = new ArrayList {new[] {i, j}, new[] {(int) fk.AcceptRejectRule, (int) fk.UpdateRule, (int) fk.DeleteRule}};
                constraintRulesList.Add(list);

                fk.AcceptRejectRule = AcceptRejectRule.None;
                fk.UpdateRule = Rule.None;
                fk.DeleteRule = Rule.None;
              }
            }
          }
        }
      }
      return constraintRulesList;
    }

/*
    Resets the read-only columns on the datatable based on the input readOnly list.
*/

    private static void ResetReadOnly(DataTable dt, ArrayList readOnlyList)
    {
      Debug.Assert(dt != null);
      Debug.Assert(readOnlyList != null);

      foreach (var columnIndex in readOnlyList.Cast<int>())
      {
        Debug.Assert(dt.Columns.Count > columnIndex);
        dt.Columns[columnIndex].ReadOnly = true;
      }
    }

/*
    Reset the foreignkey constraint rules on the datatable based on the input constraintRules list.
*/

    private static void ResetConstraintRules(DataTable dt, ArrayList constraintRulesList)
    {
      Debug.Assert(dt != null);
      Debug.Assert(constraintRulesList != null);

      var ds = dt.DataSet;
      foreach (ArrayList list in constraintRulesList)
      {
        Debug.Assert(list.Count == 2);
        var indicesArr = (int[]) list[0];
        var rules = (int[]) list[1];

        Debug.Assert(indicesArr.Length == 2);
        var tableIndex = indicesArr[0];
        var constraintIndex = indicesArr[1];

        Debug.Assert(ds.Tables.Count > tableIndex);
        var dtChild = ds.Tables[tableIndex];

        Debug.Assert(dtChild.Constraints.Count > constraintIndex);
        var fk = (ForeignKeyConstraint) dtChild.Constraints[constraintIndex];

        Debug.Assert(rules.Length == 3);
        fk.AcceptRejectRule = (AcceptRejectRule) rules[0];
        fk.UpdateRule = (Rule) rules[1];
        fk.DeleteRule = (Rule) rules[2];
      }
    }

/*
    Checks whether the datatable schema matches with the surrogate schema.
*/

    private bool IsSchemaIdentical(DataTable dt)
    {
      Debug.Assert(dt != null);

      if (dt.TableName != _tableName || dt.Namespace != _namespace)
      {
        return false;
      }

      Debug.Assert(_dataColumnSurrogates != null);
      if (dt.Columns.Count != _dataColumnSurrogates.Length)
      {
        return false;
      }
      for (var i = 0; i < dt.Columns.Count; i++)
      {
        var dc = dt.Columns[i];
        var dataColumnSurrogate = _dataColumnSurrogates[i];
        if (!dataColumnSurrogate.IsSchemaIdentical(dc))
        {
          return false;
        }
      }
      return true;
    }
  }

  [Serializable]
  internal class DataColumnSurrogate
  {
    private readonly string _columnName;
    private readonly string _namespace;
    private readonly string _prefix;
    private readonly MappingType _columnMapping;
    private readonly bool _allowNull;
    private readonly bool _autoIncrement;
    private readonly long _autoIncrementStep;
    private readonly long _autoIncrementSeed;
    private readonly string _caption;
    private readonly object _defaultValue;
    private readonly bool _readOnly;
    private readonly int _maxLength;
    private readonly Type _dataType;
    private readonly string _expression;

    //ExtendedProperties
    private readonly Hashtable _extendedProperties;

/*
    Constructs a DataColumnSurrogate from a DataColumn.
*/

    public DataColumnSurrogate(DataColumn dc)
    {
      if (dc == null)
      {
        throw new ArgumentNullException("dc");
      }
      _columnName = dc.ColumnName;
      _namespace = dc.Namespace;
      _dataType = dc.DataType;
      _prefix = dc.Prefix;
      _columnMapping = dc.ColumnMapping;
      _allowNull = dc.AllowDBNull;
      _autoIncrement = dc.AutoIncrement;
      _autoIncrementStep = dc.AutoIncrementStep;
      _autoIncrementSeed = dc.AutoIncrementSeed;
      _caption = dc.Caption;
      _defaultValue = dc.DefaultValue;
      _readOnly = dc.ReadOnly;
      _maxLength = dc.MaxLength;
      _expression = dc.Expression;

      //ExtendedProperties
      _extendedProperties = new Hashtable();
      if (dc.ExtendedProperties.Keys.Count > 0)
      {
        foreach (var propertyKey in dc.ExtendedProperties.Keys)
        {
          _extendedProperties.Add(propertyKey, dc.ExtendedProperties[propertyKey]);
        }
      }
    }

/*
    Constructs a DataColumn from DataColumnSurrogate.
*/

    public DataColumn ConvertToDataColumn()
    {
      var dc = new DataColumn
      {
        ColumnName = _columnName,
        Namespace = _namespace,
        DataType = _dataType,
        Prefix = _prefix,
        ColumnMapping = _columnMapping,
        AllowDBNull = _allowNull,
        AutoIncrement = _autoIncrement,
        AutoIncrementStep = _autoIncrementStep,
        AutoIncrementSeed = _autoIncrementSeed,
        Caption = _caption,
        DefaultValue = _defaultValue,
        ReadOnly = _readOnly,
        MaxLength = _maxLength
      };
      //dc.Expression = _expression;

      //Extended properties
      Debug.Assert(_extendedProperties != null);
      if (_extendedProperties.Keys.Count > 0)
      {
        foreach (var propertyKey in _extendedProperties.Keys)
        {
          dc.ExtendedProperties.Add(propertyKey, _extendedProperties[propertyKey]);
        }
      }
      return dc;
    }

/*
    Set expression on the DataColumn.
*/

    internal void SetColumnExpression(DataColumn dc)
    {
      Debug.Assert(dc != null);

      if (_expression != null && !_expression.Equals(String.Empty))
      {
        dc.Expression = _expression;
      }
    }

/*
    Checks whether the column schema is identical. Marked internal as the DataTableSurrogate objects needs to have access to this object.
    Note: ReadOnly is not checked here as we suppress readonly when reading data.
*/

    internal bool IsSchemaIdentical(DataColumn dc)
    {
      Debug.Assert(dc != null);
      if ((dc.ColumnName != _columnName) || (dc.Namespace != _namespace) || (dc.DataType != _dataType) ||
          (dc.Prefix != _prefix) || (dc.ColumnMapping != _columnMapping) ||
          (dc.ColumnMapping != _columnMapping) || (dc.AllowDBNull != _allowNull) ||
          (dc.AutoIncrement != _autoIncrement) || (dc.AutoIncrementStep != _autoIncrementStep) ||
          (dc.AutoIncrementSeed != _autoIncrementSeed) || (dc.Caption != _caption) ||
          (!(AreDefaultValuesEqual(dc.DefaultValue, _defaultValue))) || (dc.MaxLength != _maxLength) ||
          (dc.Expression != _expression))
      {
        return false;
      }
      return true;
    }

/*
    Checks whether the default boxed objects are equal.
*/

    internal static bool AreDefaultValuesEqual(object o1, object o2)
    {
      if (o1 == null && o2 == null)
      {
        return true;
      }
      return o1 != null && o2 != null && o1.Equals(o2);
    }
  }
}