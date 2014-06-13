﻿///////////////////////////////////////////////////////////////
// This is generated code. 
//////////////////////////////////////////////////////////////
// Code is generated using LLBLGen Pro version: 4.0
// Code is generated on: 
// Code is generated using templates: SD.TemplateBindings.SharedTemplates
// Templates vendor: Solutions Design.
// Templates version: 
//////////////////////////////////////////////////////////////
using System;
#if !CF
using System.Runtime.Serialization;
#endif
using System.Collections.Generic;
using AW.Data.FactoryClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Data.HelperClasses
{
	/// <summary>Helper class which will eases the creation of custom made resultsets. Usable in typed lists and dynamic lists created using the dynamic query engine.</summary>
	[Serializable]
	public partial class ResultsetFields : EntityFields, ISerializable
	{
		/// <summary>CTor</summary>
		public ResultsetFields(int amountFields) : base(amountFields, InheritanceInfoProviderSingleton.GetInstance(), null)
		{
		}
		
		/// <summary>Deserialization constructor</summary>
		/// <param name="info">Info.</param>
		/// <param name="context">Context.</param>
		protected ResultsetFields(SerializationInfo info, StreamingContext context) : base(info.GetInt32("_amountFields"), InheritanceInfoProviderSingleton.GetInstance(), null)
		{
			List<IEntityField> fields = (List<IEntityField>)info.GetValue("_fields", typeof(List<IEntityField>));
			for (int i = 0; i < fields.Count; i++)
			{
				this[i] = fields[i];
			}
		}

		/// <summary>Populates a <see cref="T:System.Runtime.Serialization.SerializationInfo"/> with the data needed to serialize the target object.</summary>
		/// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo"/> to populate with data.</param>
		/// <param name="context">The destination (see <see cref="T:System.Runtime.Serialization.StreamingContext"/>) for this serialization.</param>
		public virtual void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("_amountFields", this.Count);
			List<IEntityField> fields = new List<IEntityField>(this.Count);
			for (int i = 0; i < this.Count; i++)
			{
				fields.Add(this[i]);
			}
			info.AddValue("_fields", fields, typeof(List<IEntityField>));
		}

		#region Included Code

		#endregion
	}
}
