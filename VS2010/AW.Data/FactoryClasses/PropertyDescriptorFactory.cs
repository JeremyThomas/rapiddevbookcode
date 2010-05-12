///////////////////////////////////////////////////////////////
// This is generated code. If you modify this code, be aware
// of the fact that when you re-generate the code, your changes
// are lost. If you want to keep your changes, make this file read-only
// when you have finished your changes, however it is recommended that
// you inherit from this class to extend the functionality of this generated
// class or you modify / extend the templates used to generate this code.
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 1.0.2005.1
// Code is generated on: Wednesday, November 09, 2005 8:47:30 PM
// Code is generated using templates: C# template set for SqlServer (1.0.2005.1)
// Templates vendor: Solutions Design.
// Templates version: 1.0.2005.1.102305
//////////////////////////////////////////////////////////////
using System;
using System.Collections;
using System.ComponentModel;

#if CF
using System.Reflection;
#endif

using AW.Data.EntityClasses;

using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.FactoryClasses
{
	/// <summary>
	/// class which creates different sets of property descriptor sets. Required for complex databinding.  
	/// </summary>
	[Serializable]
	public class PropertyDescriptorFactory : IPropertyDescriptorFactory
	{
		/// <summary>
		/// CTor
		/// </summary>
		public PropertyDescriptorFactory()
		{
		}


		/// <summary>
		/// Creates a new propertydescriptorcollection using the specialized methods of the types stored INSIDE the type specified.
		/// </summary>
		/// <param name="typeOfCollection">type which contains other types which properties we're interested in.</param>
		/// <returns>filled propertydescriptorcollection of type inside the type specified.</returns>
		public virtual PropertyDescriptorCollection GetItemProperties(Type typeOfCollection)
		{
			PropertyDescriptorCollection toReturn = null;
			switch(typeOfCollection.UnderlyingSystemType.Name)
			{
				
				case "AddressCollection":
					toReturn = GetPropertyDescriptors(new AddressEntity(), typeof(AddressEntity));
					break;

				case "AddressTypeCollection":
					toReturn = GetPropertyDescriptors(new AddressTypeEntity(), typeof(AddressTypeEntity));
					break;

				case "ContactCollection":
					toReturn = GetPropertyDescriptors(new ContactEntity(), typeof(ContactEntity));
					break;

				case "CountryRegionCollection":
					toReturn = GetPropertyDescriptors(new CountryRegionEntity(), typeof(CountryRegionEntity));
					break;

				case "CustomerCollection":
					toReturn = GetPropertyDescriptors(new CustomerEntity(), typeof(CustomerEntity));
					break;

				case "CustomerAddressCollection":
					toReturn = GetPropertyDescriptors(new CustomerAddressEntity(), typeof(CustomerAddressEntity));
					break;

				case "CustomerViewRelatedCollection":
					toReturn = GetPropertyDescriptors(new CustomerViewRelatedEntity(), typeof(CustomerViewRelatedEntity));
					break;

				case "EmployeeCollection":
					toReturn = GetPropertyDescriptors(new EmployeeEntity(), typeof(EmployeeEntity));
					break;

				case "EmployeeAddressCollection":
					toReturn = GetPropertyDescriptors(new EmployeeAddressEntity(), typeof(EmployeeAddressEntity));
					break;

				case "IndividualCollection":
					toReturn = GetPropertyDescriptors(new IndividualEntity(), typeof(IndividualEntity));
					break;

				case "ProductCollection":
					toReturn = GetPropertyDescriptors(new ProductEntity(), typeof(ProductEntity));
					break;

				case "SalesOrderDetailCollection":
					toReturn = GetPropertyDescriptors(new SalesOrderDetailEntity(), typeof(SalesOrderDetailEntity));
					break;

				case "SalesOrderHeaderCollection":
					toReturn = GetPropertyDescriptors(new SalesOrderHeaderEntity(), typeof(SalesOrderHeaderEntity));
					break;

				case "ShipMethodCollection":
					toReturn = GetPropertyDescriptors(new ShipMethodEntity(), typeof(ShipMethodEntity));
					break;

				case "SpecialOfferCollection":
					toReturn = GetPropertyDescriptors(new SpecialOfferEntity(), typeof(SpecialOfferEntity));
					break;

				case "SpecialOfferProductCollection":
					toReturn = GetPropertyDescriptors(new SpecialOfferProductEntity(), typeof(SpecialOfferProductEntity));
					break;

				case "StateProvinceCollection":
					toReturn = GetPropertyDescriptors(new StateProvinceEntity(), typeof(StateProvinceEntity));
					break;
				default:
					toReturn = new PropertyDescriptorCollection(null);
					break;
			}

			return toReturn;
		}


		/// <summary>
		/// Constructs the actual property descriptor collection.
		/// </summary>
		/// <param name="entityToCheck">entity instance which properties should be included in the collection</param>
		/// <param name="typeOfEntity">full type of the entity</param>
		/// <returns>filled in property descriptor collection</returns>
		public PropertyDescriptorCollection GetPropertyDescriptors(IEntity entityToCheck, Type typeOfEntity)
		{
			// get the descriptors of this instance
			PropertyDescriptorCollection instancePropertiesCollection = TypeDescriptor.GetProperties(typeOfEntity);
			ArrayList instanceProperties = new ArrayList();
			Hashtable namesAdded = new Hashtable();

			foreach(IEntityField currentField in (EntityFields)entityToCheck.Fields)
			{
				EntityPropertyDescriptor newDescriptor = new EntityPropertyDescriptor(currentField, typeOfEntity);
				// check if the field is overriden. If so, replace it with THIS field. 
				if(namesAdded.ContainsKey(currentField.Name))
				{
					// replace
					instanceProperties.Remove( (EntityPropertyDescriptor)namesAdded[currentField.Name]);
					instanceProperties.Add(newDescriptor);
					namesAdded[currentField.Name] = newDescriptor;
				}
				else
				{
					// add
					instanceProperties.Add(newDescriptor);
					namesAdded.Add(currentField.Name, newDescriptor);
				}
			}
#if CF
			// grab the propery info's. As the CF can't read the attributes from property descriptors, we have to use these. 
			PropertyInfo[] propertyInfos = this.GetType().GetProperties();

			// now walk all properties in the property descriptor collection. 
			foreach(PropertyInfo property in propertyInfos)
			{
				if(!namesAdded.ContainsKey(property.Name))
				{
					// check if the property has a BrowsableAttribute.
					object[] customAttributes = property.GetCustomAttributes(typeof(BrowsableAttribute), false);
					if(customAttributes.Length>0)
					{
						if(!((BrowsableAttribute)customAttributes[0]).Browsable)
						{
							continue;
						}
					}
					PropertyDescriptor toAdd = instancePropertiesCollection[property.Name];
					if(toAdd!=null)
					{
						instanceProperties.Add(toAdd);
					}
				}
			}
#else
			// now walk all properties in the property descriptor collection. Check if the name occurs in the hashtable. if not and if browsable, copy the descriptor over.
			foreach(PropertyDescriptor property in instancePropertiesCollection)
			{
				if(!namesAdded.ContainsKey(property.Name))
				{
					if(!property.IsBrowsable)
					{
						continue;
					}

					// add it
					instanceProperties.Add(property);
				}
			}
#endif
			return new PropertyDescriptorCollection((PropertyDescriptor[])instanceProperties.ToArray(typeof(PropertyDescriptor))); 
		}

		#region Included Code

		#endregion
	}
}
