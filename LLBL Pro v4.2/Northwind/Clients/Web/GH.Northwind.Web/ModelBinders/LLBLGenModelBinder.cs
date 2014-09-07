
/* Usage documentation at the bottom of this file */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Web.Mvc;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace GH.Northwind.Web.ModelBinders
{
  /// <summary>
  /// From http://www.llblgen.com/tinyforum/Messages.aspx?ThreadID=15191 based upon 04-Feb-2010 version
  /// </summary>
  public class LLBLGenModelBinder : DefaultModelBinder
    {
        private static string[] _entity2Exclude = new string[] { "CustomPropertiesOfType", "FieldsCustomPropertiesOfType", "Validator", "AuthorizerToUse", "AuditorToUse", "Fields", "Transaction", "ConcurrencyPredicateFactoryToUse", "TypeDefaultValueProviderToUse", "PrimaryKeyFields", "LLBLGenProEntityTypeValue", "LLBLGenProEntityName", "ActiveContext", "IsDirty", "IsNew", "ObjectID", "ParticipatesInTransaction", "IsDeserializing" };
        private static string[] _entityExclude = new string[] { "CustomPropertiesOfType", "FieldsCustomPropertiesOfType", "Validator", "AuthorizerToUse", "AuditorToUse", "Fields", "Transaction", "ConcurrencyPredicateFactoryToUse", "TypeDefaultValueProviderToUse", "PrimaryKeyFields", "LLBLGenProEntityTypeValue", "LLBLGenProEntityName", "ActiveContext", "IsDirty", "IsNew", "ObjectID", "ParticipatesInTransaction", "IsDeserializing", "IsSerializing" };
        private static Dictionary<Type, List<PropertyDescriptor>> _entityPropertyDescriptorCache = new Dictionary<Type, List<PropertyDescriptor>>();

        protected override PropertyDescriptorCollection GetModelProperties(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            IEntityCore entity = bindingContext.Model as IEntityCore;
            if (entity == null) return base.GetModelProperties(controllerContext, bindingContext);

            List<PropertyDescriptor> propertyDescriptorList;
            lock (_entityPropertyDescriptorCache)
            {
                if (!_entityPropertyDescriptorCache.TryGetValue(entity.GetType(), out propertyDescriptorList))
                {
                    List<string> excludelist = entity is IEntity2 ? new List<string>(_entity2Exclude) : new List<string>(_entityExclude);
                    //skip all relations where this entity is not the PK side
                    //entity.GetAllRelations().Where(rel => rel.StartElementIsPkSide == false).ToList().ForEach(rel => excludelist.Add(rel.MappedFieldName));

                    propertyDescriptorList = new List<PropertyDescriptor>();                    
                    PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(entity.GetType());
                    foreach (PropertyDescriptor property in properties)
                    {
                        if (excludelist.Contains(property.Name) ||
                            property.Name.StartsWith("AlwaysFetch") ||
                            property.Name.StartsWith("AlreadyFetched") ||
                            property.Name.EndsWith("ReturnsNewIfNotFound")) continue;

                        propertyDescriptorList.Add(property);

                    }
                    _entityPropertyDescriptorCache.Add(entity.GetType(), propertyDescriptorList);
                }
            }
            PropertyDescriptorCollection result = new PropertyDescriptorCollection(propertyDescriptorList.Where(pd => ShouldUpdateProp(pd, bindingContext.PropertyFilter)).ToArray());
            return result;
        }

        protected override bool OnModelUpdating(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            bool result = base.OnModelUpdating(controllerContext, bindingContext);
            if (result)
            {
                IEntityCore entity = bindingContext.Model as IEntityCore;
                if (entity != null) entity.IsDeserializing = true;
            }
            return result;
        }

        protected override void SetProperty(ControllerContext controllerContext, ModelBindingContext bindingContext, PropertyDescriptor propertyDescriptor, object value)
        {
            IEntityCore entity = bindingContext.Model as IEntityCore;
            if (entity == null)
            {
                base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
                return;
            }

      EntityFieldCore field = entity.Fields.OfType<EntityFieldCore>().FirstOrDefault(efc => efc.Name == propertyDescriptor.Name);
      if (field == null)
      {
        base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
      }
      else if (!field.IsPrimaryKey)
      {
        base.SetProperty(controllerContext, bindingContext, propertyDescriptor, value);
        if (value == null && !field.IsChanged)
        {
          field.IsChanged = true;
          entity.IsDirty = true;
        }
      }
      else if (ValidKeyValue(value))
      {
        field.ForcedCurrentValueWrite(value);
        entity.IsNew = false;
      }          
        }

        protected override void OnModelUpdated(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            IEntityCore entity = bindingContext.Model as IEntityCore;
            if (entity != null) entity.IsDeserializing = false;

            base.OnModelUpdated(controllerContext, bindingContext);
        }

        protected override object CreateModel(ControllerContext controllerContext, ModelBindingContext bindingContext, Type modelType)
        {
          var overrideModelType = bindingContext.ValueProvider.GetValue(CreateSubPropertyName(bindingContext.ModelName, "OverrideModelType"));
          if (overrideModelType != null)
          {
            modelType = Type.GetType(overrideModelType.AttemptedValue);
            bindingContext.ModelMetadata = ModelMetadataProviders.Current.GetMetadataForType(null, modelType); //in theory a call to CreateModel, the model would always be null
          }

          return base.CreateModel(controllerContext, bindingContext, modelType);
        }

        protected static bool ValidKeyValue(object o)
        {
            return !((o == null) ||
                (o is Int32 && (int)o <= 0) ||                
                (o is string && string.IsNullOrEmpty((string)o)) || 
                (o is Guid && (Guid)o == Guid.Empty) ||
                (o == DBNull.Value) ||
                (o is Int16 && (short)o <= 0) ||
                (o is Int64 && (long)o <= 0) ||
                (o is DateTime && (DateTime)o == DateTime.MinValue) ||
                (o is Double && (double)o <= 0) ||
                (o is Decimal && (decimal)o <= 0) ||
                (o is Single && (float)o <= 0));
        }

    protected static readonly MethodInfo _shouldUpdateProp = typeof(DefaultModelBinder).GetMethod("ShouldUpdateProperty", BindingFlags.Static | BindingFlags.NonPublic);
    protected static bool ShouldUpdateProp(PropertyDescriptor property, Predicate<string> propertyFilter)
    {
      return (bool)_shouldUpdateProp.Invoke(null, new object[] { property, propertyFilter });
    }

    }
}

/*
This is a ModelBinder to use with the new ASP.NET MVC framework. This will automatically create and populate LLBLGen objects from form post, query string and route data. Works with both SelfServicing and Adapter.

An overview of Model Binding in ASP.NET MVC can be found here: http://weblogs.asp.net/scottgu/archive/2008/09/02/asp-net-mvc-preview-5-and-form-posting-scenarios.aspx and here: http://weblogs.asp.net/scottgu/archive/2008/10/16/asp-net-mvc-beta-released.aspx#three

This implementation inherits from the provided DefaultModelBinder and defers most of the work to it. For non LLBLGen entities, they just pass through to the default implementation. This code is to help set the primary keys and stop infinite recursive Parent-Child-Parent calls.

Requirements
============
- LLBLGen Pro v2.6
- .NET 3.5 SP1
- ASP.NET MVC 

Usage
=====
Add the LLBLGenModelBinder.cs AND IndexModelBinder.cs to your project

In the Global.asax.cs, add this to the Application_Start():
ModelBinders.Binders.DefaultBinder = new LLBLGenModelBinder();

You will be able to write code like this and have the entities automatically populated from the request

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(CompanyEntity company)
        {
            if (ModelState.IsValid)
            {
                company.Save(true);
                return RedirectToAction("Edit", new { id = company.CompanyId });
            }
            else
            {
                return View(company);
            }
        }


How it works
============
In order for the Model Binding to find the correct fields, they need to be named correctly. 

For the top level object, the take the form parameterName.Field so: <%= Html.TextBox("company.CompanyId", ViewData.Model.CompanyId)%>

For 1-to-1 objects, they look like <%= Html.TextBox("company.NormalAddress.Address", ViewData.Model.NormalAddress.Address)%>

For 1-to-many it gets a little more complex:
The release behaviour changed from the beta. 
    The beta looked for a .index property and looped through them to fill the collection 
    the release method ONLY processes for sequential indexes starting with 0. 

I have implemented the beta behaviour if an index field exists, otherwise it passes through to the release method.
    If you do not want this behaviour at all, remove IndexModelBinder and change LLBLGenModelBinder to inherit from DefaultModelBinder
  NOTE: This will not automatically fall back to a blank model name for top level parameters, use a BindAttribute to specify a blank name
 
The release behaviour: Name your fields company.Contacts[0].FieldName, counting up from 0
    
    <% for (int i=0;i<Model.Contacts.Count;i++) 
        ContactEntity contact = Model.Contacts[i]; {%>
    <tr>
        <td>Contacts.ContactId</td>
        <td><%= Html.TextBox("company.Contacts[" + i + "].ContactId", contact.ContactId)%></td>
    </tr>
    <tr>
        <td>Contacts.FirstName</td>
        <td><%= Html.TextBox("company.Contacts[" + i + "].FirstName", contact.FirstName)%></td>
    </tr>
    <tr>
        <td>Contacts.LastName</td>
        <td><%= Html.TextBox("company.Contacts[" + i + "].LastName", contact.LastName)%></td>
    </tr>
    <% } %>
 
To add, you need to add a new set of fields numbered one higher.
 
Beta behaviour: looks for a field (.index) that holds the index values to iterate:
    
    <% foreach (ContactEntity contact in Model.Contacts) {%>
    <tr>
        <td>Contacts.index</td>
        <td><%= Html.TextBox("company.Contacts.index", contact.ContactId)%></td>
    </tr>
    <tr>
        <td>Contacts.ContactId</td>
        <td><%= Html.TextBox("company.Contacts[" + contact.ContactId + "].ContactId", contact.ContactId)%></td>
    </tr>
    <tr>
        <td>Contacts.FirstName</td>
        <td><%= Html.TextBox("company.Contacts[" + contact.ContactId + "].FirstName", contact.FirstName)%></td>
    </tr>
    <tr>
        <td>Contacts.LastName</td>
        <td><%= Html.TextBox("company.Contacts[" + contact.ContactId + "].LastName", contact.LastName)%></td>
    </tr>
    <% } %>

if you want to add a new object, create any unique index:
<%= Html.TextBox("company.Contacts.index", -1)%>
<%= Html.TextBox("company.Contacts[-1].ContactId", 0)%>
<%= Html.TextBox("company.Contacts[-1].FirstName")%>

NOTES
=====
To override the type created, output a property named OverrideModelType (i.e. contact.OverrideModelType and set the value to a valid type name, fully qualified).

The Model Binder sets IsNew if a primary key field is set to a meaningful value (for ints > 0, strings not blank, etc.). You can change this behaviour by providing your own form field (i.e. company.IsNew) AND removing the "IsNew" from the list of excluded fields in the LLBLGenModelBinder

The binder only follows relations where the entity is on the PK Side, this keeps circular references from spinning out.

This process "creates" child objects, it does not "syncronize" child objects. It can syncronize objects, but you need to use the UpdateModel method to manually walk the child elements of 1-to-many. In this case, DO NOT output the .index form element because they will be in the child collection twice.

        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit2(int id)
        {
            CompanyEntity company = new CompanyEntity(id);
            UpdateModel(company, "company");
            foreach (ContactEntity contact in company.Contacts)
            {
                UpdateModel(contact, "company.Contacts[" + contact.ContactId + "]");
            }

            if (ModelState.IsValid)
            {
                company.Save(true);
                return RedirectToAction("Edit", new { id = company.CompanyId });
            }
            else
            {
                return View(company);
            }
        }
*/