using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using Rdl;

namespace DynamicTable

{
	/// <summary>
	/// Based on http://www.gotreportviewer.com/DynamicTable.zip
	/// </summary>
	internal class RdlGenerator
	{
		private List<string> m_allFields;
		private List<string> m_selectedFields;

		public List<string> AllFields
		{
			get { return m_allFields; }
			set { m_allFields = value; }
		}

		public List<string> SelectedFields
		{
			get { return m_selectedFields; }
			set { m_selectedFields = value; }
		}

		private Report CreateReport()
		{
			var report = new Report();
			report.Items = new object[]
			               	{
			               		CreateDataSources(),
			               		CreateBody(),
			               		CreateDataSets(),
			               		"6.5in",
			               	};
			report.ItemsElementName = new[]
			                          	{
			                          		ItemsChoiceType37.DataSources,
			                          		ItemsChoiceType37.Body,
			                          		ItemsChoiceType37.DataSets,
			                          		ItemsChoiceType37.Width,
			                          	};
			return report;
		}

		private DataSourcesType CreateDataSources()
		{
			var dataSources = new DataSourcesType();
			dataSources.DataSource = new[] {CreateDataSource()};
			return dataSources;
		}

		private DataSourceType CreateDataSource()
		{
			var dataSource = new DataSourceType();
			dataSource.Name = "DummyDataSource";
			dataSource.Items = new object[] {CreateConnectionProperties()};
			return dataSource;
		}

		private ConnectionPropertiesType CreateConnectionProperties()
		{
			var connectionProperties = new ConnectionPropertiesType();
			connectionProperties.Items = new object[]
			                             	{
			                             		"",
			                             		"SQL",
			                             	};
			connectionProperties.ItemsElementName = new[]
			                                        	{
			                                        		ItemsChoiceType.ConnectString,
			                                        		ItemsChoiceType.DataProvider,
			                                        	};
			return connectionProperties;
		}

		private BodyType CreateBody()
		{
			var body = new BodyType();
			body.Items = new object[]
			             	{
			             		CreateReportItems(),
			             		"1in",
			             	};
			body.ItemsElementName = new[]
			                        	{
			                        		ItemsChoiceType30.ReportItems,
			                        		ItemsChoiceType30.Height,
			                        	};
			return body;
		}

		private ReportItemsType CreateReportItems()
		{
			var reportItems = new ReportItemsType();
			var tableGen = new TableRdlGenerator();
			tableGen.Fields = m_selectedFields;
			reportItems.Items = new object[] {tableGen.CreateTable()};
			return reportItems;
		}

		private DataSetsType CreateDataSets()
		{
			var dataSets = new DataSetsType();
			dataSets.DataSet = new[] {CreateDataSet()};
			return dataSets;
		}

		private DataSetType CreateDataSet()
		{
			var dataSet = new DataSetType();
			dataSet.Name = "MyData";
			dataSet.Items = new object[] {CreateQuery(), CreateFields()};
			return dataSet;
		}

		private QueryType CreateQuery()
		{
			var query = new QueryType();
			query.Items = new object[]
			              	{
			              		"DummyDataSource",
			              		"",
			              	};
			query.ItemsElementName = new[]
			                         	{
			                         		ItemsChoiceType2.DataSourceName,
			                         		ItemsChoiceType2.CommandText,
			                         	};
			return query;
		}

		private FieldsType CreateFields()
		{
			var fields = new FieldsType();

			fields.Field = new FieldType[m_allFields.Count];
			for (var i = 0; i < m_allFields.Count; i++)
			{
				fields.Field[i] = CreateField(m_allFields[i]);
			}

			return fields;
		}

		private FieldType CreateField(String fieldName)
		{
			var field = new FieldType();
			field.Name = fieldName;
			field.Items = new object[] {fieldName};
			field.ItemsElementName = new[] {ItemsChoiceType1.DataField};
			return field;
		}

		public void WriteXml(Stream stream)
		{
			var serializer = new XmlSerializer(typeof (Report));
			serializer.Serialize(stream, CreateReport());
		}
	}
}