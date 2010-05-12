using System;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace DynamicTable

{  /// <summary>
  /// Based on http://www.gotreportviewer.com/DynamicTable.zip
  /// </summary>
    class RdlGenerator
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

        private Rdl.Report CreateReport()
        {
            Rdl.Report report = new Rdl.Report();
            report.Items = new object[] 
                {
                    CreateDataSources(),
                    CreateBody(),
                    CreateDataSets(),
                    "6.5in",
                };
            report.ItemsElementName = new Rdl.ItemsChoiceType37[]
                { 
                    Rdl.ItemsChoiceType37.DataSources, 
                    Rdl.ItemsChoiceType37.Body,
                    Rdl.ItemsChoiceType37.DataSets,
                    Rdl.ItemsChoiceType37.Width,
                };
            return report;
        }

        private Rdl.DataSourcesType CreateDataSources()
        {
            Rdl.DataSourcesType dataSources = new Rdl.DataSourcesType();
            dataSources.DataSource = new Rdl.DataSourceType[] { CreateDataSource() };
            return dataSources;
        }

        private Rdl.DataSourceType CreateDataSource()
        {
            Rdl.DataSourceType dataSource = new Rdl.DataSourceType();
            dataSource.Name = "DummyDataSource";
            dataSource.Items = new object[] { CreateConnectionProperties() };
            return dataSource;
        }

        private Rdl.ConnectionPropertiesType CreateConnectionProperties()
        {
            Rdl.ConnectionPropertiesType connectionProperties = new Rdl.ConnectionPropertiesType();
            connectionProperties.Items = new object[]
                {
                    "",
                    "SQL",
                };
            connectionProperties.ItemsElementName = new Rdl.ItemsChoiceType[]
                {
                    Rdl.ItemsChoiceType.ConnectString,
                    Rdl.ItemsChoiceType.DataProvider,
                };
            return connectionProperties;
        }

        private Rdl.BodyType CreateBody()
        {
            Rdl.BodyType body = new Rdl.BodyType();
            body.Items = new object[]
                {
                    CreateReportItems(),
                    "1in",
                };
            body.ItemsElementName = new Rdl.ItemsChoiceType30[]
                {
                    Rdl.ItemsChoiceType30.ReportItems,
                    Rdl.ItemsChoiceType30.Height,
                };
            return body;
        }

        private Rdl.ReportItemsType CreateReportItems()
        {
            Rdl.ReportItemsType reportItems = new Rdl.ReportItemsType();
            TableRdlGenerator tableGen = new TableRdlGenerator();
            tableGen.Fields = m_selectedFields;
            reportItems.Items = new object[] { tableGen.CreateTable() };
            return reportItems;
        }

        private Rdl.DataSetsType CreateDataSets()
        {
            Rdl.DataSetsType dataSets = new Rdl.DataSetsType();
            dataSets.DataSet = new Rdl.DataSetType[] { CreateDataSet() };
            return dataSets;
        }

        private Rdl.DataSetType CreateDataSet()
        {
            Rdl.DataSetType dataSet = new Rdl.DataSetType();
            dataSet.Name = "MyData";
            dataSet.Items = new object[] { CreateQuery(), CreateFields() };
            return dataSet;
        }

        private Rdl.QueryType CreateQuery()
        {
            Rdl.QueryType query = new Rdl.QueryType();
            query.Items = new object[] 
                {
                    "DummyDataSource",
                    "",
                };
            query.ItemsElementName = new Rdl.ItemsChoiceType2[]
                {
                    Rdl.ItemsChoiceType2.DataSourceName,
                    Rdl.ItemsChoiceType2.CommandText,
                };
            return query;
        }

        private Rdl.FieldsType CreateFields()
        {
            Rdl.FieldsType fields = new Rdl.FieldsType();

            fields.Field = new Rdl.FieldType[m_allFields.Count];
            for (int i = 0; i < m_allFields.Count; i++)
            {
                fields.Field[i] = CreateField(m_allFields[i]);
            }

            return fields;
        }

        private Rdl.FieldType CreateField(String fieldName)
        {
            Rdl.FieldType field = new Rdl.FieldType();
            field.Name = fieldName;
            field.Items = new object[] { fieldName };
            field.ItemsElementName = new Rdl.ItemsChoiceType1[] { Rdl.ItemsChoiceType1.DataField };
            return field;
        }

        public void WriteXml(Stream stream)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(Rdl.Report));
            serializer.Serialize(stream, CreateReport());
        }
    }
}
