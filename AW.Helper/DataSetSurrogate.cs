using System;
using System.IO;
using System.ComponentModel;
using System.Collections;
using System.Globalization;
using System.Xml;
using System.Data;
using System.Runtime.Serialization;
using System.Diagnostics;

/// <summary>
///     Author : Ravinder Vuppula.
///    Purpose : To implement binary serialization of the DataSet through a Surrogate object./
///Notes:  
///    1. All the surrogate objects DataSetSurrogate, DataTableSurrogate, DataColumnSurrogate are marked [Serializable] and hence will get automatically serialized by the remoting framework.
///    2. The data is serialized in binary "column" wise.
///    3. This class can be used as a wrapper around DataSet. A DataSetSurrogate object can be constructed from DataSet and vice-versa. This helps if the user wants to wrap the DataSet in DataSetSurrogate and serialize and deserialize DataSetSurrogate instead.
///History:
///05/10/04 - Fix for the  issue of serializing default values.
/// </summary>
/// <see cref="http://support.microsoft.com/default.aspx?scid=kb;en-us;829740"/>
[Serializable]
public class DataSetSurrogate {
    //DataSet properties
    private string _datasetName;
    private string _namespace;
    private string _prefix;        
    private bool _caseSensitive;
    private CultureInfo _locale;
    private bool _enforceConstraints;
    
    //ForeignKeyConstraints
    private ArrayList _fkConstraints;//An ArrayList of foreign key constraints :  [constraintName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[AcceptRejectRule, UpdateRule, Delete]->[extendedProperties]
    
    //Relations
    private ArrayList _relations;//An ArrayList of foreign key constraints : [relationName]->[parentTableIndex, parentcolumnIndexes]->[childTableIndex, childColumnIndexes]->[Nested]->[extendedProperties]
    
    //ExtendedProperties
    private Hashtable _extendedProperties;
    
    //Columns and Rows
    private DataTableSurrogate[] _dataTableSurrogates;
            
/*
    Constructs a DataSetSurrogate object from a DataSet.
*/
    public DataSetSurrogate(DataSet ds) {
        if (ds == null) {
            throw new ArgumentNullException("The parameter dataset is null");
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
        for (int i = 0; i < ds.Tables.Count; i++) { 
            _dataTableSurrogates[i] = new DataTableSurrogate(ds.Tables[i]);
        }
        
        //ForeignKeyConstraints
        _fkConstraints = GetForeignKeyConstraints(ds);
        
        //Relations
        _relations = GetRelations(ds);
        
        //ExtendedProperties
        _extendedProperties = new Hashtable();
        if (ds.ExtendedProperties.Keys.Count > 0) {            
            foreach (object propertyKey in ds.ExtendedProperties.Keys) {
                _extendedProperties.Add(propertyKey, ds.ExtendedProperties[propertyKey]);
            }
        }
    }    
    
/*
    Constructs a DataSet from the DataSetSurrogate object. This can be used after the user recieves a Surrogate object over the wire and wished to construct a DataSet from it.
*/
    public DataSet ConvertToDataSet() {
        DataSet ds = new DataSet();
        ReadSchemaIntoDataSet(ds);
        ReadDataIntoDataSet(ds);
        return ds;        
    }    
        
/*
    Reads the schema into the dataset from the DataSetSurrogate object.
*/
    public void ReadSchemaIntoDataSet(DataSet ds) {
        if (ds == null) {
            throw new ArgumentNullException("The dataset parameter cannot be null");
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
        foreach (DataTableSurrogate dataTableSurrogate in _dataTableSurrogates) {
            DataTable dt = new DataTable();
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
        for (int i = 0; i < ds.Tables.Count; i++) {
            DataTable dt = ds.Tables[i];
            DataTableSurrogate dataTableSurrogate = _dataTableSurrogates[i];
            dataTableSurrogate.SetColumnExpressions(dt);
        }
        
        //ExtendedProperties
        Debug.Assert(_extendedProperties != null);
        if (_extendedProperties.Keys.Count > 0) {
            foreach (object propertyKey in _extendedProperties.Keys) {
                ds.ExtendedProperties.Add(propertyKey, _extendedProperties[propertyKey]);
            }
        }
    }

/*
    Reads the data into the dataset from the DataSetSurrogate object.
*/
    public void ReadDataIntoDataSet(DataSet ds) {
        if (ds == null) {
            throw new ArgumentNullException("The dataset parameter cannot be null");
        }
        
        //Suppress  read-only columns and constraint rules when loading the data
        ArrayList readOnlyList = SuppressReadOnly(ds);
        ArrayList constraintRulesList = SuppressConstraintRules(ds);        
        
        //Rows
        Debug.Assert(IsSchemaIdentical(ds));
        Debug.Assert(_dataTableSurrogates != null);
        Debug.Assert(ds.Tables.Count == _dataTableSurrogates.Length);            
        bool enforceConstraints = ds.EnforceConstraints;
        ds.EnforceConstraints = false;
        for (int i = 0; i < ds.Tables.Count; i++) {
            DataTable dt = ds.Tables[i];
            DataTableSurrogate dataTableSurrogate = _dataTableSurrogates[i];
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
    private ArrayList GetForeignKeyConstraints(DataSet ds) {
        Debug.Assert(ds != null);
        
        ArrayList constraintList = new ArrayList();        
        for (int i = 0; i < ds.Tables.Count; i++) {
            DataTable dt = ds.Tables[i];
            for (int j = 0; j < dt.Constraints.Count; j++) {
                Constraint c = dt.Constraints[j];
                ForeignKeyConstraint fk = c as ForeignKeyConstraint;
                if (fk != null) {
                    string constraintName = c.ConstraintName;
                    int[] parentInfo = new int[fk.RelatedColumns.Length + 1];
                    parentInfo[0] = ds.Tables.IndexOf(fk.RelatedTable);
                    for (int k = 1; k < parentInfo.Length; k++) {
                        parentInfo[k] = fk.RelatedColumns[k - 1].Ordinal;
                    }
                    
                    int[] childInfo = new int[fk.Columns.Length + 1];
                    childInfo[0] = i;//Since the constraint is on the current table, this is the child table.
                    for (int k = 1; k < childInfo.Length; k++) {
                        childInfo[k] = fk.Columns[k - 1].Ordinal;
                    }
                    
                    ArrayList list = new ArrayList();
                    list.Add(constraintName);
                    list.Add(parentInfo);
                    list.Add(childInfo);                    
                    list.Add(new int[] { (int) fk.AcceptRejectRule, (int) fk.UpdateRule, (int) fk.DeleteRule });
                    Hashtable extendedProperties = new Hashtable();
                    if (fk.ExtendedProperties.Keys.Count > 0) {
                        foreach (object propertyKey in fk.ExtendedProperties.Keys) {
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
    private void SetForeignKeyConstraints(DataSet ds, ArrayList constraintList) {
        Debug.Assert(ds != null);
        Debug.Assert(constraintList != null);
        
        foreach (ArrayList list in constraintList) {
            Debug.Assert(list.Count == 5);
            string constraintName = (string) list[0];            
            int[] parentInfo = (int[]) list[1];
            int[] childInfo = (int[]) list[2];
            int[] rules = (int[]) list[3];            
            Hashtable extendedProperties = (Hashtable) list[4];
            
            //ParentKey Columns.
            Debug.Assert(parentInfo.Length >= 1);
            DataColumn[] parentkeyColumns = new DataColumn[parentInfo.Length - 1];
            for (int i = 0; i < parentkeyColumns.Length; i++) {
                Debug.Assert(ds.Tables.Count > parentInfo[0]);
                Debug.Assert(ds.Tables[parentInfo[0]].Columns.Count > parentInfo[i + 1]);
                parentkeyColumns[i] = ds.Tables[parentInfo[0]].Columns[parentInfo[i + 1]];
            }
            
            //ChildKey Columns.
            Debug.Assert(childInfo.Length >= 1);
            DataColumn[] childkeyColumns = new DataColumn[childInfo.Length - 1];
            for (int i = 0; i < childkeyColumns.Length; i++) {
                Debug.Assert(ds.Tables.Count > childInfo[0]);
                Debug.Assert(ds.Tables[childInfo[0]].Columns.Count > childInfo[i + 1]);                
                childkeyColumns[i] = ds.Tables[childInfo[0]].Columns[childInfo[i + 1]];
            }
            
            //Create the Constraint.
            ForeignKeyConstraint fk = new ForeignKeyConstraint(constraintName, parentkeyColumns, childkeyColumns);
            Debug.Assert(rules.Length == 3);
            fk.AcceptRejectRule = (AcceptRejectRule) rules[0];
            fk.UpdateRule = (Rule) rules[1];
            fk.DeleteRule = (Rule) rules[2];
            
            //Extended Properties.
            Debug.Assert(extendedProperties != null);
            if (extendedProperties.Keys.Count > 0) {                
                foreach (object propertyKey in extendedProperties.Keys) {
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
    private ArrayList GetRelations(DataSet ds) {
        Debug.Assert(ds != null);
        
        ArrayList relationList = new ArrayList();
        foreach (DataRelation rel in ds.Relations) {
            string relationName = rel.RelationName;
            int[] parentInfo = new int[rel.ParentColumns.Length + 1];
            parentInfo[0] = ds.Tables.IndexOf(rel.ParentTable);
            for (int j = 1; j < parentInfo.Length; j++) {
                parentInfo[j] = rel.ParentColumns[j - 1].Ordinal;
            }
                
            int[] childInfo = new int[rel.ChildColumns.Length + 1];
            childInfo[0] = ds.Tables.IndexOf(rel.ChildTable);
            for (int j = 1; j < childInfo.Length; j++) {
                childInfo[j] = rel.ChildColumns[j - 1].Ordinal;
            }
                
            ArrayList list = new ArrayList();
            list.Add(relationName);
            list.Add(parentInfo);
            list.Add(childInfo);
            list.Add(rel.Nested);
            Hashtable extendedProperties = new Hashtable();
            if (rel.ExtendedProperties.Keys.Count > 0) {
                foreach (object propertyKey in rel.ExtendedProperties.Keys) {
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
    private void SetRelations(DataSet ds, ArrayList relationList) {
        Debug.Assert(ds != null);
        Debug.Assert(relationList != null);
        
        foreach (ArrayList list in relationList) {
            Debug.Assert(list.Count == 5);
            string relationName = (string) list[0];
            int[] parentInfo = (int[]) list[1];
            int[] childInfo = (int[]) list[2];
            bool isNested = (bool) list[3];                
            Hashtable extendedProperties = (Hashtable) list[4];
            
            //ParentKey Columns.
            Debug.Assert(parentInfo.Length >= 1);
            DataColumn[] parentkeyColumns = new DataColumn[parentInfo.Length - 1];
            for (int i = 0; i < parentkeyColumns.Length; i++) {
                Debug.Assert(ds.Tables.Count > parentInfo[0]);
                Debug.Assert(ds.Tables[parentInfo[0]].Columns.Count > parentInfo[i + 1]);                
                parentkeyColumns[i] = ds.Tables[parentInfo[0]].Columns[parentInfo[i + 1]];
            }
            
            //ChildKey Columns.
            Debug.Assert(childInfo.Length >= 1);
            DataColumn[] childkeyColumns = new DataColumn[childInfo.Length - 1];
            for (int i = 0; i < childkeyColumns.Length; i++) {
                Debug.Assert(ds.Tables.Count > childInfo[0]);
                Debug.Assert(ds.Tables[childInfo[0]].Columns.Count > childInfo[i + 1]);                                
                childkeyColumns[i] = ds.Tables[childInfo[0]].Columns[childInfo[i + 1]];
            }
            
            //Create the Relation, without any constraints[Assumption: The constraints are added earlier than the relations]
            DataRelation rel = new DataRelation(relationName, parentkeyColumns, childkeyColumns, false);
            rel.Nested = isNested;
            
            //Extended Properties.
            Debug.Assert(extendedProperties != null);
            if (extendedProperties.Keys.Count > 0) {
                foreach (object propertyKey in extendedProperties.Keys) {
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
    private ArrayList SuppressReadOnly(DataSet ds) {
        Debug.Assert(ds != null);
        
        ArrayList readOnlyList = new ArrayList();
        for (int i = 0; i < ds.Tables.Count; i++) {
            DataTable dt = ds.Tables[i];
            for (int j = 0; j < dt.Columns.Count; j++) {
                if (dt.Columns[j].Expression == String.Empty && dt.Columns[j].ReadOnly == true) {
                    dt.Columns[j].ReadOnly = false;
                    readOnlyList.Add(new int[] { i, j });
                }
            }
        }
        return readOnlyList;
    }    

/*
    Suppress the foreign key constraint rules and returns an arraylist of the existing foreignkey constraint rules.
*/    
    private ArrayList SuppressConstraintRules(DataSet ds) {
        Debug.Assert(ds != null);
        
        ArrayList constraintRulesList = new ArrayList();
        for (int i = 0; i < ds.Tables.Count; i++) {
            DataTable dtChild = ds.Tables[i];
            for (int j = 0; j < dtChild.Constraints.Count; j++) {
                Constraint c = dtChild.Constraints[j];
                if (c is ForeignKeyConstraint) {
                    ForeignKeyConstraint fk = (ForeignKeyConstraint) c;
                    ArrayList list = new ArrayList();
                    list.Add(new int[] { i, j });
                    list.Add(new int[] { (int) fk.AcceptRejectRule, (int) fk.UpdateRule, (int) fk.DeleteRule });
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
    private void ResetReadOnly(DataSet ds, ArrayList readOnlyList) {
        Debug.Assert(ds != null);
        Debug.Assert(readOnlyList != null);
        
        foreach (object o in readOnlyList) {
            int[] indicesArr = (int[]) o;
            
            Debug.Assert(indicesArr.Length == 2);
            int tableIndex = indicesArr[0];
            int columnIndex = indicesArr[1];
            
            Debug.Assert(ds.Tables.Count > tableIndex);
            Debug.Assert(ds.Tables[tableIndex].Columns.Count > columnIndex);
            
            DataColumn dc = ds.Tables[tableIndex].Columns[columnIndex];            
            Debug.Assert(dc != null);
            
            dc.ReadOnly = true;
        }
    }
    
/*
    Resets the foreignkey constraint rules on the dataset based on the input constraint rules list.
*/     
    private void ResetConstraintRules(DataSet ds, ArrayList constraintRulesList) {
        Debug.Assert(ds != null);
        Debug.Assert(constraintRulesList != null);
        
        foreach (ArrayList list in constraintRulesList) {
            Debug.Assert(list.Count == 2);            
            int[] indicesArr = (int[]) list[0];
            int[] rules = (int[]) list[1];
            
            Debug.Assert(indicesArr.Length == 2);            
            int tableIndex = indicesArr[0];
            int constraintIndex = indicesArr[1];
            
            Debug.Assert(ds.Tables.Count > tableIndex);
            DataTable dtChild = ds.Tables[tableIndex];
            
            Debug.Assert(dtChild.Constraints.Count > constraintIndex);
            ForeignKeyConstraint fk = (ForeignKeyConstraint) dtChild.Constraints[constraintIndex];
            
            Debug.Assert(rules.Length == 3);
            fk.AcceptRejectRule = (AcceptRejectRule) rules[0];
            fk.UpdateRule = (Rule) rules[1];
            fk.DeleteRule = (Rule) rules[2];
        }
    }
        
/*
    Checks whether the dataset name and namespaces are as expected and the tables count is right.
*/    
    private bool IsSchemaIdentical(DataSet ds) {
        Debug.Assert(ds != null);
        if (ds.DataSetName != _datasetName || ds.Namespace != _namespace) {
            return false;
        }
        Debug.Assert(_dataTableSurrogates != null);
        if (ds.Tables.Count != _dataTableSurrogates.Length) {
            return false;
        }
        return true;
    }    
} 

[Serializable]
public class DataTableSurrogate {
    //DataTable properties
    private string _tableName;
    private string _namespace;
    private string _prefix;
    private bool _caseSensitive;
    private CultureInfo _locale;
    private string _displayExpression;
    private int _minimumCapacity;
    
    //Columns
    private DataColumnSurrogate[] _dataColumnSurrogates;
    
    //Constraints
    private ArrayList _uniqueConstraints; //An ArrayList of unique constraints : [constraintName]->[columnIndexes]->[IsPrimaryKey]->[extendedProperties]
        
    //ExtendedProperties
    private Hashtable _extendedProperties;

    //Rows
    private BitArray _rowStates;  //The 4 rowstates[Unchanged, Added, Modified, Deleted] are represented with 2 bits. The length of the BitArray will be twice the size of the number of rows.
    private object[][] _records;  //As many object[] as there are number of columns. Always send 2 records for 1 row. TradeOff between memory vs. performance. Time intensive to find which records are modified.
    private Hashtable _rowErrors = new Hashtable(); //Keep a map between the row index and the row error
    private Hashtable _colErrors = new Hashtable(); //Keep a map between the row index and the Arraylist of columns that are in error and the error strings.

/*
    Constructs a DataTableSurrogate from a DataTable.
*/
    public DataTableSurrogate(DataTable dt) {
        if (dt == null) {
            throw new ArgumentNullException("The parameter dt is null");
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
        for (int i = 0; i < dt.Columns.Count; i++) {
            _dataColumnSurrogates[i] = new DataColumnSurrogate(dt.Columns[i]);
        }                        
        
        //Constraints
        _uniqueConstraints = GetUniqueConstraints(dt);
        
        //ExtendedProperties
        _extendedProperties = new Hashtable();
        if (dt.ExtendedProperties.Keys.Count > 0) {           
            foreach (object propertyKey in dt.ExtendedProperties.Keys) {
                _extendedProperties.Add(propertyKey, dt.ExtendedProperties[propertyKey]);
            }
        }
        
        //Rows
        if (dt.Rows.Count > 0) {
            _rowStates = new BitArray(dt.Rows.Count << 1);
            _records = new object[dt.Columns.Count] [];
            for (int i = 0; i < dt.Columns.Count; i++) {
                _records[i] = new object[dt.Rows.Count << 1];
            }
            for (int i = 0; i < dt.Rows.Count; i++) {
                GetRecords(dt.Rows[i], i << 1);
            }
        }        
    }    
    
/*
    Constructs a DataTable from DataTableSurrogate. 
*/        
    public DataTable ConvertToDataTable() {
        DataTable dt = new DataTable();
        ReadSchemaIntoDataTable(dt);
        ReadDataIntoDataTable(dt);
        return dt;
    }

/*
    Reads the schema into the datatable from DataTableSurrogate. 
*/        
    public void ReadSchemaIntoDataTable(DataTable dt) {
        if (dt == null) {
            throw new ArgumentNullException("The datatable parameter cannot be null");
        }
        
        dt.TableName = _tableName;
        dt.Namespace = _namespace;
        dt.Prefix = _prefix;
        dt.CaseSensitive = _caseSensitive;
        dt.Locale = _locale;
        dt.DisplayExpression = _displayExpression;
        dt.MinimumCapacity = _minimumCapacity;
        
        Debug.Assert(_dataColumnSurrogates != null);
        for (int i = 0; i < _dataColumnSurrogates.Length; i++) {
            DataColumnSurrogate dataColumnSurrogate = _dataColumnSurrogates[i];
            DataColumn dc = dataColumnSurrogate.ConvertToDataColumn();
            dt.Columns.Add(dc);
        }
        
        //UniqueConstraints
        SetUniqueConstraints(dt, _uniqueConstraints);
        
        //Extended properties
        Debug.Assert(_extendedProperties != null);
        if (_extendedProperties.Keys.Count > 0) {
            foreach (object propertyKey in _extendedProperties.Keys) {
                dt.ExtendedProperties.Add(propertyKey, _extendedProperties[propertyKey]);
            }
        }
    }
    
/*
    Reads the data into a DataTable from DataTableSurrogate. 
*/        
    public void ReadDataIntoDataTable(DataTable dt) {
        ReadDataIntoDataTable(dt, true);
    }    

/*
    Copies the rows into a DataTable from DataTableSurrogate. 
*/        
    internal void ReadDataIntoDataTable(DataTable dt, bool suppressSchema) {
        if (dt == null) {
            throw new ArgumentNullException("The datatable parameter cannot be null");
        }
        Debug.Assert(IsSchemaIdentical(dt));        
        
        //Suppress read-only and constraint rules while loading the data.
        ArrayList readOnlyList = null;
        ArrayList constraintRulesList = null;
        if (suppressSchema) {
            readOnlyList = SuppressReadOnly(dt);
            constraintRulesList = SuppressConstraintRules(dt);
        }
        
        //Read the rows
        if (_records != null && dt.Columns.Count > 0) {
            Debug.Assert(_records.Length > 0);
            int rowCount = _records[0].Length >> 1;
            for (int i = 0; i < rowCount; i++) {
                ConvertToDataRow(dt, i << 1);
            }
        }
        
        //Reset read-only column and constraint rules back after loading the data.
        if (suppressSchema) {
            ResetReadOnly(dt, readOnlyList);
            ResetConstraintRules(dt, constraintRulesList);
        }
    }    
   
/*
    Gets unique constraints availabe on the datatable.
    ***Serialized unique constraints format : [constraintName]->[columnIndexes]->[IsPrimaryKey]->[extendedProperties]***
*/     
    private ArrayList GetUniqueConstraints(DataTable dt) {
        Debug.Assert(dt != null);
        
        ArrayList constraintList = new ArrayList();        
        for (int i = 0; i < dt.Constraints.Count; i++) {
            Constraint c = dt.Constraints[i];
            UniqueConstraint uc = c as UniqueConstraint;
            if (uc != null) {
                string constraintName = c.ConstraintName;
                int[] colInfo = new int[uc.Columns.Length];
                for (int j = 0; j < colInfo.Length; j++) {
                    colInfo[j] = uc.Columns[j].Ordinal;
                }
                
                ArrayList list = new ArrayList();
                list.Add(constraintName);
                list.Add(colInfo);
                list.Add(uc.IsPrimaryKey);
                Hashtable extendedProperties = new Hashtable();
                if (uc.ExtendedProperties.Keys.Count > 0) {
                    foreach (object propertyKey in uc.ExtendedProperties.Keys) {
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
    private void SetUniqueConstraints(DataTable dt, ArrayList constraintList) {
        Debug.Assert(dt != null);
        Debug.Assert(constraintList != null);
        
        foreach (ArrayList list in constraintList) {
            Debug.Assert(list.Count == 4);
            string constraintName = (string) list[0];            
            int[] keyColumnIndexes = (int[]) list[1];
            bool isPrimaryKey = (bool) list[2];
            Hashtable extendedProperties = (Hashtable) list[3];
            
            DataColumn[] keyColumns = new DataColumn[keyColumnIndexes.Length];
            for (int i = 0; i < keyColumnIndexes.Length; i++) {
                Debug.Assert(dt.Columns.Count > keyColumnIndexes[i]);
                keyColumns[i] = dt.Columns[keyColumnIndexes[i]];
            }
            //Create the constraint.
            UniqueConstraint uc = new UniqueConstraint(constraintName, keyColumns, isPrimaryKey);
            //Extended Properties.
            Debug.Assert(extendedProperties != null);
            if (extendedProperties.Keys.Count > 0) {
                foreach (object propertyKey in extendedProperties.Keys) {
                    uc.ExtendedProperties.Add(propertyKey, extendedProperties[propertyKey]);
                }
            }
            dt.Constraints.Add(uc);
        }
    }
    
/*
    Sets  expression on the columns.
*/    
    internal void SetColumnExpressions(DataTable dt) {
        Debug.Assert(dt != null);
        
        Debug.Assert(_dataColumnSurrogates != null);
        Debug.Assert(dt.Columns.Count == _dataColumnSurrogates.Length);
        for (int i = 0; i < dt.Columns.Count; i++) {
            DataColumn dc = dt.Columns[i];
            DataColumnSurrogate dataColumnSurrogate = _dataColumnSurrogates[i];
            dataColumnSurrogate.SetColumnExpression(dc);
        }
    }

/*
    Gets the records from the rows.
*/    
    private void GetRecords(DataRow row, int bitIndex) {
        Debug.Assert(row != null);
        
        ConvertToSurrogateRowState(row.RowState, bitIndex);
        ConvertToSurrogateRecords(row, bitIndex);
        ConvertToSurrogateRowError(row, bitIndex >> 1);
    }
    
/*
    Constructs the row, rowError and columnErrors.
*/
    public DataRow ConvertToDataRow(DataTable dt, int bitIndex) {        
        DataRowState rowState = ConvertToRowState(bitIndex);
        DataRow row = ConstructRow(dt, rowState, bitIndex);
        ConvertToRowError(row, bitIndex >> 1);
        return row;
    }   

/*
    Sets the two bits in the bitArray to represent the DataRowState.
    The 4 rowstates[Unchanged, Added, Modified, Deleted] are represented with 2 bits. The length of the BitArray will be twice the size of the number of rows.
    Serialozed rowstate format : [00]->UnChanged, [01]->Added, [10]->Modified, [11]->Deleted.
*/        
    private void ConvertToSurrogateRowState(DataRowState rowState, int bitIndex) {
        Debug.Assert(_rowStates != null);
        Debug.Assert(_rowStates.Length > bitIndex);
        
        switch (rowState) {
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
    private DataRowState ConvertToRowState(int bitIndex) {
        Debug.Assert(_rowStates != null);
        Debug.Assert(_rowStates.Length > bitIndex);
        
        bool b1 = _rowStates[bitIndex];
        bool b2 = _rowStates[bitIndex + 1];
        
        if (!b1 && !b2) {
            return DataRowState.Unchanged;
        } else if (!b1 && b2) {
            return DataRowState.Added;
        } else if (b1 && !b2) {
            return DataRowState.Modified;
        } else if (b1 && b2) {
            return DataRowState.Deleted;
        } else {
            throw new ArgumentException("Unrecognized bitpattern");
        }
    }    

/*
    Constructs surrogate records from the DataRow.
*/     
    private void ConvertToSurrogateRecords(DataRow row, int bitIndex) {
        Debug.Assert(row != null);
        Debug.Assert(_records != null);          
        
        int colCount = row.Table.Columns.Count;
        DataRowState rowState = row.RowState;
        
        Debug.Assert(_records.Length == colCount);        
        if (rowState != DataRowState.Added) {//Unchanged, modified, deleted     
            for (int i = 0; i < colCount; i++) {
                Debug.Assert(_records[i].Length > bitIndex);
                _records[i][bitIndex] = row[i, DataRowVersion.Original];
            }
        }
        
        if (rowState != DataRowState.Unchanged && rowState != DataRowState.Deleted) {//Added, modified state
            for (int i = 0; i < colCount; i++) {
                Debug.Assert(_records[i].Length > bitIndex + 1);
                _records[i][bitIndex + 1] = row[i, DataRowVersion.Current];
            }
        }
    }
    
/*
    Constructs a DataRow from records[original and current] and adds the row to the DataTable rows collection.
*/                        
    private DataRow ConstructRow(DataTable dt, DataRowState rowState, int bitIndex) {        
        Debug.Assert(dt != null);
        Debug.Assert(_records != null);
                
        DataRow row = dt.NewRow();
        int colCount = dt.Columns.Count;
        
        Debug.Assert(_records.Length == colCount);
        switch (rowState) {
            case DataRowState.Unchanged:
                for (int i = 0; i < colCount; i++) {
                    Debug.Assert(_records[i].Length > bitIndex);
                    row[i] = _records[i][bitIndex]; //Original Record
                }
                dt.Rows.Add(row);
                row.AcceptChanges();
                break;
            case DataRowState.Added:
                for (int i = 0; i < colCount; i++) {
                    Debug.Assert(_records[i].Length > bitIndex + 1);
                    row[i] = _records[i][bitIndex + 1]; //Current Record
                }
                dt.Rows.Add(row);
                break;
            case DataRowState.Modified:
                for (int i = 0; i < colCount; i++) {
                    Debug.Assert(_records[i].Length > bitIndex);
                    row[i] = _records[i][bitIndex]; //Original Record
                }                
                dt.Rows.Add(row);
                row.AcceptChanges();
                row.BeginEdit();
                for (int i = 0; i < colCount; i++) {
                    Debug.Assert(_records[i].Length > bitIndex + 1);
                    row[i] = _records[i][bitIndex + 1]; //Current Record
                }
                row.EndEdit();
                break;
            case DataRowState.Deleted:
                for (int i = 0; i < colCount; i++) {
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
    private void ConvertToSurrogateRowError(DataRow row, int rowIndex) {
        Debug.Assert(row != null);
        Debug.Assert(_rowErrors != null);
        Debug.Assert(_colErrors != null);
        
        if (row.HasErrors) {
            _rowErrors.Add(rowIndex, row.RowError);
            DataColumn[] dcArr = row.GetColumnsInError();
            if (dcArr.Length > 0) {            
                int[] columnsInError = new int[dcArr.Length];
                string[] columnErrors = new string[dcArr.Length];
                for (int i = 0; i < dcArr.Length; i++) {
                    columnsInError[i] = dcArr[i].Ordinal;
                    columnErrors[i] = row.GetColumnError(dcArr[i]);
                }
                ArrayList list = new ArrayList();
                list.Add(columnsInError);
                list.Add(columnErrors);            
                _colErrors.Add(rowIndex, list);
            }
        }
    }

/*
    Set the row and columns in error.
*/
    private void ConvertToRowError(DataRow row, int rowIndex) {
        Debug.Assert(row != null);
        Debug.Assert(_rowErrors != null);
        Debug.Assert(_colErrors != null);
        
        if (_rowErrors.ContainsKey(rowIndex)) {
            row.RowError = (string) _rowErrors[rowIndex];
        }
        if (_colErrors.ContainsKey(rowIndex)) {
            ArrayList list = (ArrayList) _colErrors[rowIndex];
            int[] columnsInError = (int[]) list[0];
            string[] columnErrors = (string[]) list[1]; 
            Debug.Assert(columnsInError.Length == columnErrors.Length);
            for (int i = 0; i < columnsInError.Length; i++) {
                row.SetColumnError(columnsInError[i], columnErrors[i]);
            }
        }
    }
    
/*
    Suppress the read-only property and returns an arraylist of read-only columns.
*/    
    private ArrayList SuppressReadOnly(DataTable dt) {
        Debug.Assert(dt != null);
        ArrayList readOnlyList = new ArrayList();
        for (int j = 0; j < dt.Columns.Count; j++) {
            if (dt.Columns[j].Expression == String.Empty && dt.Columns[j].ReadOnly == true) {            
                readOnlyList.Add(j);
            }
        }
        return readOnlyList;
    }    
    
/*
    Suppress the foreign key constraint rules and returns an arraylist of the existing foreignkey constraint rules.
*/    
    private ArrayList SuppressConstraintRules(DataTable dt) {
        Debug.Assert(dt != null);
        ArrayList constraintRulesList = new ArrayList();
        DataSet ds = dt.DataSet;        
        if (ds != null) {
            for (int i = 0; i < ds.Tables.Count; i++) {
                DataTable dtChild = ds.Tables[i];
                for (int j = 0; j < dtChild.Constraints.Count; j++) {
                    Constraint c = dtChild.Constraints[j];
                    if (c is ForeignKeyConstraint) {
                        ForeignKeyConstraint fk = (ForeignKeyConstraint) c;
                        if (fk.RelatedTable == dt) {                            
                            ArrayList list = new ArrayList();
                            list.Add(new int[] { i, j });
                            list.Add(new int[] { (int) fk.AcceptRejectRule, (int) fk.UpdateRule, (int) fk.DeleteRule });
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
    private void ResetReadOnly(DataTable dt, ArrayList readOnlyList) {
        Debug.Assert(dt != null);
        Debug.Assert(readOnlyList != null);
        
        DataSet ds = dt.DataSet;
        foreach (object o in readOnlyList) {
            int columnIndex = (int) o;
            Debug.Assert(dt.Columns.Count > columnIndex);
            dt.Columns[columnIndex].ReadOnly = true;
        }
    }    
    
/*
    Reset the foreignkey constraint rules on the datatable based on the input constraintRules list.
*/     
    private void ResetConstraintRules(DataTable dt, ArrayList constraintRulesList) {
        Debug.Assert(dt != null);
        Debug.Assert(constraintRulesList != null);
        
        DataSet ds = dt.DataSet;
        foreach (ArrayList list in constraintRulesList) {
            Debug.Assert(list.Count == 2);
            int[] indicesArr = (int[]) list[0];
            int[] rules = (int[]) list[1];
            
            Debug.Assert(indicesArr.Length == 2);
            int tableIndex = indicesArr[0];
            int constraintIndex = indicesArr[1];
            
            Debug.Assert(ds.Tables.Count > tableIndex);
            DataTable dtChild = ds.Tables[tableIndex];
            
            Debug.Assert(dtChild.Constraints.Count > constraintIndex);
            ForeignKeyConstraint fk = (ForeignKeyConstraint) dtChild.Constraints[constraintIndex];
            
            Debug.Assert(rules.Length == 3);
            fk.AcceptRejectRule = (AcceptRejectRule) rules[0];
            fk.UpdateRule = (Rule) rules[1];
            fk.DeleteRule = (Rule) rules[2];
        }
    }

/*
    Checks whether the datatable schema matches with the surrogate schema.
*/        
    private bool IsSchemaIdentical(DataTable dt) {
        Debug.Assert(dt != null);
        
        if (dt.TableName != _tableName || dt.Namespace != _namespace) {
            return false;
        }
        
        Debug.Assert(_dataColumnSurrogates != null);
        if (dt.Columns.Count != _dataColumnSurrogates.Length) {
            return false;
        }            
        for (int i = 0; i < dt.Columns.Count; i++) {
            DataColumn dc = dt.Columns[i];
            DataColumnSurrogate dataColumnSurrogate = _dataColumnSurrogates[i];
            if (!dataColumnSurrogate.IsSchemaIdentical(dc)) {
                return false;
            }
        }
        return true;
    }    
}

[Serializable]
class DataColumnSurrogate {
    private string _columnName;
    private string _namespace;
    private string _prefix;            
    private MappingType _columnMapping;
    private bool _allowNull;
    private bool _autoIncrement;
    private long _autoIncrementStep;
    private long _autoIncrementSeed;
    private string _caption;
    private object _defaultValue;
    private bool _readOnly;
    private int _maxLength;
    private Type _dataType;
    private string _expression;
    
    //ExtendedProperties
    private Hashtable _extendedProperties;
    
/*
    Constructs a DataColumnSurrogate from a DataColumn.
*/    
    public DataColumnSurrogate(DataColumn dc) {
        if (dc == null) {
            throw new ArgumentNullException("The datacolumn parameter is null");
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
        if (dc.ExtendedProperties.Keys.Count > 0) {            
            foreach (object propertyKey in dc.ExtendedProperties.Keys) {
                _extendedProperties.Add(propertyKey, dc.ExtendedProperties[propertyKey]);
            }
        }         
    }
    
/*
    Constructs a DataColumn from DataColumnSurrogate.
*/    
    public DataColumn ConvertToDataColumn() {
        DataColumn dc = new DataColumn();
        dc.ColumnName = _columnName;
        dc.Namespace = _namespace;
        dc.DataType = _dataType;
        dc.Prefix = _prefix;
        dc.ColumnMapping = _columnMapping;
        dc.AllowDBNull = _allowNull;
        dc.AutoIncrement = _autoIncrement;
        dc.AutoIncrementStep = _autoIncrementStep;
        dc.AutoIncrementSeed = _autoIncrementSeed;
        dc.Caption = _caption;
        dc.DefaultValue = _defaultValue;
        dc.ReadOnly = _readOnly;
        dc.MaxLength = _maxLength;        
        //dc.Expression = _expression;
        
        //Extended properties
        Debug.Assert(_extendedProperties != null);
        if (_extendedProperties.Keys.Count > 0) {
            foreach (object propertyKey in _extendedProperties.Keys) {
                dc.ExtendedProperties.Add(propertyKey, _extendedProperties[propertyKey]);
            }
        }
        return dc;
    }
    
/*
    Set expression on the DataColumn.
*/
    internal void SetColumnExpression(DataColumn dc) {
        Debug.Assert(dc != null);
        
        if (_expression != null && !_expression.Equals(String.Empty)) {
            dc.Expression = _expression;
        }
    }
    
/*
    Checks whether the column schema is identical. Marked internal as the DataTableSurrogate objects needs to have access to this object.
    Note: ReadOnly is not checked here as we suppress readonly when reading data.
*/
    internal bool IsSchemaIdentical(DataColumn dc) {
        Debug.Assert(dc != null);
        if ((dc.ColumnName != _columnName) || (dc.Namespace != _namespace) || (dc.DataType != _dataType) ||  
            (dc.Prefix !=  _prefix) || (dc.ColumnMapping != _columnMapping) || 
            (dc.ColumnMapping !=  _columnMapping) || (dc.AllowDBNull != _allowNull) ||
            (dc.AutoIncrement !=  _autoIncrement) || (dc.AutoIncrementStep != _autoIncrementStep) ||
            (dc.AutoIncrementSeed !=  _autoIncrementSeed) || (dc.Caption !=  _caption) ||
            (!(AreDefaultValuesEqual(dc.DefaultValue, _defaultValue))) || (dc.MaxLength != _maxLength) ||
            (dc.Expression != _expression)) {
            return false;
        }
        return true;
    }

/*
    Checks whether the default boxed objects are equal.
*/    
    internal static bool AreDefaultValuesEqual(object o1, object o2) {
        if (o1 == null && o2 == null) {
            return true;
        } else if (o1 == null || o2 == null) {
            return false;
        } else {
            return o1.Equals(o2);
        }
    }    
}