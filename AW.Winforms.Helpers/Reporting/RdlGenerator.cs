using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Rdl;

namespace AW.Winforms.Helpers.Reporting

{
  /// <summary>
  ///   Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
  internal class RdlGenerator
  {
    public List<string> AllFields { get; set; }

    public List<string> SelectedFields { get; set; }

    private Report CreateReport()
    {
      var report = new Report
      {
        Items = new object[]
        {
          CreateDataSources(),
          CreateBody(),
          CreateDataSets(),
          "6.5in"
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType37.DataSources,
          ItemsChoiceType37.Body,
          ItemsChoiceType37.DataSets,
          ItemsChoiceType37.Width
        }
      };
      return report;
    }

    private DataSourcesType CreateDataSources()
    {
      var dataSources = new DataSourcesType {DataSource = new[] {CreateDataSource()}};
      return dataSources;
    }

    private DataSourceType CreateDataSource()
    {
      var dataSource = new DataSourceType
      {
        Name = "DummyDataSource",
        Items = new object[] {CreateConnectionProperties()}
      };
      return dataSource;
    }

    private static ConnectionPropertiesType CreateConnectionProperties()
    {
      var connectionProperties = new ConnectionPropertiesType
      {
        Items = new object[]
        {
          "",
          "SQL"
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType.ConnectString,
          ItemsChoiceType.DataProvider
        }
      };
      return connectionProperties;
    }

    private BodyType CreateBody()
    {
      var body = new BodyType
      {
        Items = new object[]
        {
          CreateReportItems(),
          "1in"
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType30.ReportItems,
          ItemsChoiceType30.Height
        }
      };
      return body;
    }

    private ReportItemsType CreateReportItems()
    {
      var reportItems = new ReportItemsType();
      var tableGen = new TableRdlGenerator {Fields = SelectedFields};
      reportItems.Items = new object[] {tableGen.CreateTable()};
      return reportItems;
    }

    private DataSetsType CreateDataSets()
    {
      var dataSets = new DataSetsType {DataSet = new[] {CreateDataSet()}};
      return dataSets;
    }

    private DataSetType CreateDataSet()
    {
      var dataSet = new DataSetType
      {
        Name = "MyData",
        Items = new object[] {CreateQuery(), CreateFields()}
      };
      return dataSet;
    }

    private static QueryType CreateQuery()
    {
      var query = new QueryType
      {
        Items = new object[]
        {
          "DummyDataSource",
          ""
        },
        ItemsElementName = new[]
        {
          ItemsChoiceType2.DataSourceName,
          ItemsChoiceType2.CommandText
        }
      };
      return query;
    }

    private FieldsType CreateFields()
    {
      var fields = new FieldsType {Field = new FieldType[AllFields.Count]};
      for (var i = 0; i < AllFields.Count; i++)
      {
        fields.Field[i] = CreateField(AllFields[i]);
      }
      return fields;
    }

    private static FieldType CreateField(String fieldName)
    {
      var field = new FieldType
      {
        Name = fieldName,
        Items = new object[] {fieldName},
        ItemsElementName = new[] {ItemsChoiceType1.DataField}
      };
      return field;
    }

    public void WriteXml(Stream stream)
    {
      var serializer = new XmlSerializer(typeof (Report));
      serializer.Serialize(stream, CreateReport());
    }
  }
}