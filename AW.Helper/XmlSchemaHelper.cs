using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace AW.Helper
{
  public static class XmlSchemaHelper
  {
    #region Validation

    public static void ValidateXml(MemoryStream xmlStream, XmlSchema xmlSchema, ValidationEventHandler xmlReaderSettingsOnValidationEventHandler)
    {
      var xmlReaderSettings = CreateValidatingXmlReaderSettings(xmlSchema, xmlReaderSettingsOnValidationEventHandler);
      ValidateXml(xmlStream, xmlReaderSettings);
    }

    public static XmlSchemaSet CreateXmlSchemaSet(string path, string targetNamespace = null)
    {
      var schemas = new XmlSchemaSet();
      schemas.Add(targetNamespace, XmlReader.Create(new FileStream(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite), null, path));
      schemas.Compile();
      return schemas;
    }

    public static XmlReaderSettings CreateValidatingXmlReaderSettings(XmlSchema xmlSchema, ValidationEventHandler xmlReaderSettingsOnValidationEventHandler)
    {
      var xmlReaderSettings = new XmlReaderSettings {ValidationType = ValidationType.Schema};
      xmlReaderSettings.Schemas.Add(xmlSchema);
      xmlReaderSettings.ValidationEventHandler += xmlReaderSettingsOnValidationEventHandler;
      return xmlReaderSettings;
    }

    public static XmlReaderSettings CreateValidatingXmlReaderSettings(XmlSchemaSet xmlSchemaSet, ValidationEventHandler xmlReaderSettingsOnValidationEventHandler)
    {
      var xmlReaderSettings = new XmlReaderSettings
      {
        ValidationType = ValidationType.Schema,
        Schemas = xmlSchemaSet
      };
      xmlReaderSettings.ValidationEventHandler += xmlReaderSettingsOnValidationEventHandler;
      return xmlReaderSettings;
    }

    public static void ValidateXml(MemoryStream xmlStream, string path, string targetNamespace, ValidationEventHandler xmlReaderSettingsOnValidationEventHandler)
    {
      ValidateXml(xmlStream, CreateValidatingXmlReaderSettings(path, xmlReaderSettingsOnValidationEventHandler, targetNamespace));
    }

    /// <summary>
    ///   Creates the validating XML reader settings. If there is a UnauthorizedAccessException to the XSD path just swallow
    ///   and log.
    /// </summary>
    /// <param name="path">The path.</param>
    /// <param name="xmlReaderSettingsOnValidationEventHandler">The XML reader settings on validation event handler.</param>
    /// <param name="targetNamespace">The target namespace.</param>
    /// <returns></returns>
    public static XmlReaderSettings CreateValidatingXmlReaderSettings(string path, ValidationEventHandler xmlReaderSettingsOnValidationEventHandler, string targetNamespace = null)
    {
      try
      {
        return CreateValidatingXmlReaderSettings(CreateXmlSchemaSet(path, targetNamespace), xmlReaderSettingsOnValidationEventHandler);
      }
      catch (UnauthorizedAccessException e)
      {
        e.TraceOut();
        GeneralHelper.TraceOut(e.Message);
      }
      return null;
    }

    public static void ValidateXml(MemoryStream xmlStream, XmlSchemaSet xmlSchemaSet, ValidationEventHandler xmlReaderSettingsOnValidationEventHandler)
    {
      ValidateXml(xmlStream, CreateValidatingXmlReaderSettings(xmlSchemaSet, xmlReaderSettingsOnValidationEventHandler));
    }

    public static void ValidateXml(Stream xmlStream, XmlReaderSettings validatingXmlReaderSettings)
    {
      var position = xmlStream.Position;
      xmlStream.Position = 0;
      try
      {
        using (var reader = XmlReader.Create(xmlStream, validatingXmlReaderSettings))
          while (reader.Read())
          {
          }
      }
      finally
      {
        xmlStream.Position = position;
      }
    }

    #endregion

    #region Serialize/Deserialize

    /// <summary>
    ///   Serializes object into an XML string
    /// </summary>
    /// <returns>string XML value</returns>
    public static string Serialize(object o, XmlReaderSettings validatingXmlReaderSettings = null)
    {
      var xmlSerializer = new XmlSerializerFactory().CreateSerializer(0.GetType());
      if (xmlSerializer != null)
        using (var memoryStream = new MemoryStream())
        {
          xmlSerializer.Serialize(memoryStream, 0);
          memoryStream.Seek(0, SeekOrigin.Begin);
          if (validatingXmlReaderSettings != null)
            ValidateXml(memoryStream, validatingXmlReaderSettings);
          using (var streamReader = new StreamReader(memoryStream))
            return streamReader.ReadToEnd();
        }
      return null;
    }

    #endregion

    #region GetElements

    public static List<XmlSchemaElement> FilterXmlSchemaElementsByName(List<XmlSchemaElement> schemaElements, string nameToFilterBy)
    {
      if (!String.IsNullOrEmpty(nameToFilterBy))
        schemaElements = schemaElements.Where(se => se.Name.Contains(nameToFilterBy)).ToList();
      return schemaElements;
    }

    /// <summary>
    ///   Gets the elements with simple types.
    ///   http://blogs.msdn.com/b/stan_kitsis/archive/2005/08/06/448572.aspx
    /// </summary>
    /// <param name="particle">The particle.</param>
    /// <param name="schemaElements">The schema elements.</param>
    /// <param name="parentToFilterBy">The parent to filter by.</param>
    public static void GetElementsWithSimpleTypes(XmlSchemaParticle particle, ICollection<XmlSchemaElement> schemaElements, XmlSchemaElement parentToFilterBy)
    {
      var element = particle as XmlSchemaElement;
      if (element != null)
      {
        var elem = element;

        if (elem.RefName.IsEmpty)
        {
          var type = elem.ElementSchemaType;
          if (type is XmlSchemaComplexType)
          {
            var ct = type as XmlSchemaComplexType;
            //if (ct.QualifiedName.IsEmpty)
            {
              GetElementsWithSimpleTypes(ct.ContentTypeParticle, schemaElements, parentToFilterBy);
            }
          }
          else if (type is XmlSchemaSimpleType)
            if (!schemaElements.Contains(elem))
            {
              if (parentToFilterBy == null)
                schemaElements.Add(elem);
              else
              {
                var parentSchemaType = GetParentSchemaType(elem);
                var parentSchemaTypeName = String.Empty;
                if (parentSchemaType != null)
                  parentSchemaTypeName = parentSchemaType.Name;

                if (parentSchemaType != null && parentSchemaTypeName != null && parentSchemaTypeName.Contains(parentToFilterBy.Name) || elem.Name.Contains(parentToFilterBy.Name))
                  schemaElements.Add(elem);
                else
                {
                  var xmlSchemaComplexType = (XmlSchemaComplexType) parentToFilterBy.ElementSchemaType;
                  var contentTypeParticle = xmlSchemaComplexType.ContentTypeParticle as XmlSchemaGroupBase;
                  if (contentTypeParticle != null)
                    if (contentTypeParticle.Items.OfType<XmlSchemaElement>().Any(se => elem.Name.Contains(se.Name))
                        || contentTypeParticle.Items.OfType<XmlSchemaElement>().Any(se => parentSchemaTypeName != null && se.SchemaTypeName.Name.Contains(parentSchemaTypeName)))
                      schemaElements.Add(elem);
                }
              }
            }
        }
      }
      else
      {
        var groupBase = particle as XmlSchemaGroupBase;
        if (groupBase != null)
          //xs:all, xs:choice, xs:sequence
        {
          var baseParticle = groupBase;
          var addItems = parentToFilterBy == null;
          if (!addItems)
          {
            var parentSchemaElement = GetParentSchemaElement(baseParticle);
            addItems = parentSchemaElement == null || parentSchemaElement.Name.Contains(parentToFilterBy.Name);
          }
          if (addItems)
            foreach (var subParticle in baseParticle.Items.OfType<XmlSchemaParticle>())
            {
              GetElementsWithSimpleTypes(subParticle, schemaElements, parentToFilterBy);
            }
        }
      }
    }

    /// <summary>
    ///   Gets the elements with simple types.
    ///   http://blogs.msdn.com/b/stan_kitsis/archive/2005/08/06/448572.aspx
    /// </summary>
    /// <param name="particle">The particle.</param>
    /// <param name="schemaElements">The schema elements.</param>
    public static void GetAllElements(XmlSchemaParticle particle, ICollection<XmlSchemaElement> schemaElements)
    {
      var elem = particle as XmlSchemaElement;
      if (elem == null)
      {
        //xs:all, xs:choice, xs:sequence
        var baseParticle = particle as XmlSchemaGroupBase;
        if (baseParticle != null)
          foreach (var subParticle in baseParticle.Items.OfType<XmlSchemaParticle>())
            GetAllElements(subParticle, schemaElements);
      }
      else
      {
        if (elem.RefName.IsEmpty)
        {
          if (!schemaElements.Contains(elem))
            schemaElements.Add(elem);
          var ct = elem.ElementSchemaType as XmlSchemaComplexType;
          if (ct != null)
            GetAllElements(ct.ContentTypeParticle, schemaElements);
        }
      }
    }

    public static List<XmlSchemaElement> GetAllElements(XmlSchema schema)
    {
      var schemaElements = new List<XmlSchemaElement>();
      foreach (var xmlSchemaElement in schema.Elements.Values.Cast<XmlSchemaElement>())
        GetAllElements(xmlSchemaElement, schemaElements);
      return schemaElements;
    }

    public static IEnumerable<XmlSchemaElement> GetElementsThatCanOccurMultipleTimes(IEnumerable<XmlSchemaElement> schemaElements)
    {
      return from xmlSchemaElement in schemaElements
        where xmlSchemaElement.ElementSchemaType is XmlSchemaComplexType
        let contentTypeSequence = ((XmlSchemaComplexType) xmlSchemaElement.ElementSchemaType).ContentTypeParticle as XmlSchemaSequence
        where contentTypeSequence != null && contentTypeSequence.MaxOccurs > 1
        select xmlSchemaElement;
    }

    public static void GetAllParticles(XmlSchemaParticle particle, ICollection<XmlSchemaParticle> schemaParticles)
    {
      var elem = particle as XmlSchemaElement;
      if (elem == null)
      {
        //xs:all, xs:choice, xs:sequence
        var baseParticle = particle as XmlSchemaGroupBase;
        if (baseParticle != null)
        {
          if (!schemaParticles.Contains(baseParticle))
            schemaParticles.Add(baseParticle);
          foreach (var subParticle in baseParticle.Items.OfType<XmlSchemaParticle>())
            GetAllParticles(subParticle, schemaParticles);
        }
      }
      else
      {
        if (elem.RefName.IsEmpty)
        {
          if (!schemaParticles.Contains(elem))
            schemaParticles.Add(elem);
          var ct = elem.ElementSchemaType as XmlSchemaComplexType;
          if (ct != null)
            GetAllParticles(ct.ContentTypeParticle, schemaParticles);
        }
      }
    }

    public static List<XmlSchemaParticle> GetAllParticles(XmlSchema schema)
    {
      var schemaParticles = new List<XmlSchemaParticle>();
      foreach (var xmlSchemaElement in schema.Elements.Values.Cast<XmlSchemaParticle>())
        GetAllParticles(xmlSchemaElement, schemaParticles);
      return schemaParticles;
    }

    /// <summary>
    ///   Gets the type of the parent schema.
    /// </summary>
    /// <param name="xmlSchemaObject">The XML schema object.</param>
    /// <returns></returns>
    public static XmlSchemaType GetParentSchemaType(XmlSchemaObject xmlSchemaObject)
    {
      if (xmlSchemaObject.Parent == null)
        return null;
      var parentSchemaType = xmlSchemaObject.Parent as XmlSchemaType;
      return parentSchemaType ?? GetParentSchemaType(xmlSchemaObject.Parent);
    }

    public static XmlSchemaElement GetParentSchemaElement(XmlSchemaObject particle)
    {
      if (particle.Parent == null)
        return null;
      var parentSchemaElement = particle.Parent as XmlSchemaElement;
      return parentSchemaElement ?? GetParentSchemaElement(particle.Parent);
    }

    public static IEnumerable<XmlSchemaSimpleType> GetSimpleTypesThatHaveFacets(XmlSchema xsd)
    {
      var simpleTypes = xsd.SchemaTypes.Values.OfType<XmlSchemaSimpleType>()
        .Where(t => t.Content is XmlSchemaSimpleTypeRestriction && GetFacets(t).Count > 0);
      return simpleTypes;
    }

    public static IEnumerable<XmlSchemaEnumerationFacet> AsEnumerationFacetEnumerable(this XmlSchemaObjectCollection xmlSchemaObjectCollection)
    {
      return xmlSchemaObjectCollection.OfType<XmlSchemaEnumerationFacet>();
    }

    public static IEnumerable<XmlSchemaSimpleType> GetSimpleTypesThatHaveEnumFacets(XmlSchema xsd)
    {
      var simpleTypes = xsd.SchemaTypes.Values.OfType<XmlSchemaSimpleType>()
        .Where(t => t.Content is XmlSchemaSimpleTypeRestriction && GetFacets(t).AsEnumerationFacetEnumerable().Any());
      return simpleTypes;
    }

    #endregion

    #region XmlSchemaFacet

    public static T GetXmlSchemaFacet<T>(XmlSchemaType xmlSchemaType) where T : XmlSchemaFacet
    {
      if (HasRestriction(xmlSchemaType))
        return GetFacets(xmlSchemaType).OfType<T>().FirstOrDefault();
      return null;
    }

    private static IEnumerable<T> GetFacets<T>(XmlSchemaType xmlSchemaType) where T : XmlSchemaFacet
    {
      return GetFacets(xmlSchemaType).OfType<T>();
    }

    private static XmlSchemaObjectCollection GetFacets(XmlSchemaType xmlSchemaType)
    {
      var simpleType = GetSimpleType(xmlSchemaType);
      return simpleType == null ? new XmlSchemaObjectCollection() : GetFacets(simpleType);
    }

    private static XmlSchemaSimpleType GetSimpleType(XmlSchemaType xmlSchemaType)
    {
      var simpleType = xmlSchemaType as XmlSchemaSimpleType;
      if (simpleType == null)
      {
        var complexType = xmlSchemaType as XmlSchemaComplexType;
        if (complexType != null)
          simpleType = complexType.BaseXmlSchemaType as XmlSchemaSimpleType;
      }
      return simpleType;
    }

    private static IEnumerable<T> GetFacets<T>(XmlSchemaSimpleType xmlSchemaSimpleType) where T : XmlSchemaFacet
    {
      return GetFacets(xmlSchemaSimpleType).OfType<T>();
    }

    private static XmlSchemaObjectCollection GetFacets(XmlSchemaSimpleType xmlSchemaSimpleType)
    {
      var xmlSchemaSimpleTypeRestriction = xmlSchemaSimpleType.Content as XmlSchemaSimpleTypeRestriction;
      return xmlSchemaSimpleTypeRestriction == null ? new XmlSchemaObjectCollection() : xmlSchemaSimpleTypeRestriction.Facets;
    }

    private static string GetFacet(XmlSchemaType xmlSchemaType, params Type[] facetTypes)
    {
      return (from XmlSchemaFacet facet in GetFacets(xmlSchemaType) where facetTypes.Contains(facet.GetType()) select facet.Value).FirstOrDefault();
    }

    private static bool HasRestriction(XmlSchemaType xmlSchemaType)
    {
      return xmlSchemaType is XmlSchemaSimpleType && ((XmlSchemaSimpleType) xmlSchemaType).Content is XmlSchemaSimpleTypeRestriction;
    }

    public static T GetXmlSchemaFacet<T>(XmlSchemaElement xmlSchemaElement) where T : XmlSchemaFacet
    {
      return GetXmlSchemaFacet<T>(xmlSchemaElement.SchemaType);
    }

    public static string GetXmlSchemaFacetValue<T>(XmlSchemaElement xmlSchemaElement) where T : XmlSchemaFacet
    {
      var xmlSchemaFacet = GetXmlSchemaFacet<T>(xmlSchemaElement);
      return xmlSchemaFacet == null ? null : xmlSchemaFacet.Value;
    }

    public static string GetXmlSchemaFacetMinValue(XmlSchemaElement xmlSchemaElement)
    {
      return HasRestriction(xmlSchemaElement.SchemaType)
        ? GetFacet(xmlSchemaElement.SchemaType, typeof (XmlSchemaMinExclusiveFacet), typeof (XmlSchemaMinInclusiveFacet), typeof (XmlSchemaMinLengthFacet))
        : null;
    }

    public static string GetXmlSchemaFacetMaxValue(XmlSchemaElement xmlSchemaElement)
    {
      return HasRestriction(xmlSchemaElement.SchemaType)
        ? GetFacet(xmlSchemaElement.SchemaType, typeof (XmlSchemaMaxExclusiveFacet), typeof (XmlSchemaMaxInclusiveFacet), typeof (XmlSchemaMaxLengthFacet))
        : null;
    }

    #endregion

    #region DataTable

    /// <summary>
    ///   Copies Schema enumerations to data table, with a column per Annotation.
    /// </summary>
    /// <param name="facets">The facets.</param>
    /// <param name="table">The table.</param>
    /// <returns></returns>
    public static DataTable CopyToDataTable(this IEnumerable<XmlSchemaEnumerationFacet> facets, DataTable table = null)
    {
      // Create a new table if the input table is null. 
      if (table == null)
        table = new DataTable("FacetDocumentation");
      const string defaultColumnName = "Value";
      foreach (var xmlSchemaEnumerationFacet in facets)
        if (xmlSchemaEnumerationFacet.Annotation == null)
        {
          if (table.Columns.Count == 0)
            table.Columns.Add(defaultColumnName);
          table.LoadDataRowWithValues(xmlSchemaEnumerationFacet.Value);
        }
        else
        {
          var xmlSchemaDocumentations = xmlSchemaEnumerationFacet.Annotation.Items.OfType<XmlSchemaDocumentation>().ToList();
          if (xmlSchemaDocumentations.Count > table.Columns.Count)
            foreach (var columnName in xmlSchemaDocumentations.Select(xmlSchemaDocumentation => xmlSchemaDocumentation.Source ?? defaultColumnName)
              .Where(columnName => !table.Columns.Contains(columnName)))
              table.Columns.Add(columnName);
          table.LoadDataRow(xmlSchemaDocumentations.Select(xd => xd.Markup.Any() ? xd.Markup[0].Value : null));
        }
      return table;
    }

    /// <summary>
    ///   Given a list of XML schema simple types it puts their enumerations into tables in a DataSet.
    /// </summary>
    /// <param name="xmlSchemaSimpleTypes">The XML schema simple types.</param>
    /// <returns></returns>
    public static DataSet EnumsToDataSet(IEnumerable<XmlSchemaSimpleType> xmlSchemaSimpleTypes)
    {
      var dataSet = new DataSet();
      EnumsToDataSet(xmlSchemaSimpleTypes, dataSet.Tables);
      return dataSet;
    }

    private static void EnumsToDataSet(IEnumerable<XmlSchemaSimpleType> xmlSchemaSimpleTypes, DataTableCollection dataTableCollection)
    {
      foreach (var schemaSimpleType in xmlSchemaSimpleTypes)
      {
        var tableName = schemaSimpleType.Name;
        AddFacets(dataTableCollection, schemaSimpleType, tableName);
      }
    }

    private static void AddFacets(DataTableCollection dataTableCollection, XmlSchemaSimpleType schemaSimpleType, string tableName, string tableNamespace = null)
    {
      var facets = GetFacets<XmlSchemaEnumerationFacet>(schemaSimpleType).ToList();
      if (facets.Any())
      {
        var table = new DataTable(tableName, tableNamespace);
        facets.CopyToDataTable(table);
        dataTableCollection.Add(table);
      }
    }

    /// <summary>
    ///   Put the Schema's enumerations into tables in a DataSet.
    ///   The list of elements that use that enumeration is in the tables namespace, prefixed with the parent element, if any.
    /// </summary>
    /// <param name="schema">The schema.</param>
    /// <returns></returns>
    public static DataSet SchemaEnumerationsToDataSet(XmlSchema schema)
    {
      var dataSet = new DataSet();
      SchemaEnumerationsToDataSet(schema, dataSet.Tables);
      return dataSet;
    }

    private static void SchemaEnumerationsToDataSet(XmlSchema schema, DataTableCollection dataTableCollection)
    {
      foreach (var element in GetAllElements(schema).OrderBy(e => e.Name))
      {
        var simpleType = GetSimpleType(element.ElementSchemaType);
        if (simpleType != null)
        {
          var tableName = simpleType.Name;
          var parentSchemaElement = GetParentSchemaElement(element);
          var parentSchemaType = GetParentSchemaType(parentSchemaElement ?? element);
          string entityName = null;
          if (parentSchemaType != null)
            entityName = parentSchemaType.Name;
          if (entityName == null && parentSchemaElement != null) entityName = parentSchemaElement.Name;

          var prefixedElementName = GeneralHelper.Join(".", entityName, element.Name);
          if (dataTableCollection.Contains(tableName))
            dataTableCollection[tableName].Namespace += "," + prefixedElementName;
          else
            AddFacets(dataTableCollection, simpleType, tableName, prefixedElementName);
        }
      }
    }
  }

  #endregion
}