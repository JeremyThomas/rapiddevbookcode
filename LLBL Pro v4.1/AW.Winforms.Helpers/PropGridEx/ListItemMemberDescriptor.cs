using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace AW.Winforms.Helpers.PropGridEx
{
	public abstract class ListItemAbstractDescriptor : PropertyDescriptor
	{
		protected ListItemAbstractDescriptor(string name)
			: this(name, null)
		{
		}

		protected ListItemAbstractDescriptor(string name, Attribute[] attrs) : base(name, attrs)
		{
		}

		protected ListItemAbstractDescriptor(MemberDescriptor descr) : base(descr)
		{
		}

		protected ListItemAbstractDescriptor(MemberDescriptor descr, Attribute[] attrs) : base(descr, attrs)
		{
		}

		public override bool IsReadOnly
		{
			get { return false; }
		}

		public override Type PropertyType
		{
			get
			{
				var val = GetValue(null);
				return val != null ? val.GetType() : typeof (object);
			}
		}

		public override AttributeCollection Attributes
		{
			get
			{
				var hasExpandebleTypeConverter = false;
				var baseAttribs = base.Attributes;
				var attributes = new List<Attribute>(baseAttribs.Count);
				foreach (Attribute baseAttribute in baseAttribs)
				{
					var tca = baseAttribute as TypeConverterAttribute;

					if ((tca != null) && (Type.GetType(tca.ConverterTypeName).IsSubclassOf(typeof (ExpandableObjectConverter))))
					{
						attributes.Add(baseAttribute);
						hasExpandebleTypeConverter = true;
					}
					else
					{
						attributes.Add(baseAttribute);
					}
				}

				var value = GetValue(null);
				if (value != null)
				{
					var valueType = value.GetType();
					// add expandable type conv?
					if ((!hasExpandebleTypeConverter) && (!valueType.IsValueType) && (valueType != typeof (string)))
					{
						attributes.Add(new TypeConverterAttribute(typeof (ExpandableObjectConverter)));
					}
				}
				var result = new AttributeCollection(attributes.ToArray());


				return result;
			}
		}

		public override bool CanResetValue(object component)
		{
			return false;
		}

		public override void ResetValue(object component)
		{
		}

		public override void SetValue(object component, object value)
		{
		}

		public override bool ShouldSerializeValue(object component)
		{
			return false;
		}
	}

	//IEntityFields
	public class ListItemMemberDescriptor : ListItemAbstractDescriptor
	{
		private readonly IList m_List;
		private readonly int m_Index;

		public ListItemMemberDescriptor(IList list, int index)
			:
				base(String.Format("[{0}]", index), null)
		{
			m_List = list;
			m_Index = index;
		}

		public override Type ComponentType
		{
			get { return typeof (IList); }
		}

		public override object GetValue(object component)
		{
			return m_List[m_Index];
		}

		//string category = "IList";
		//        attributes.Add(new CategoryAttribute(category));
		public override string Category
		{
			get { return "IList"; }
		}

		//        attributes.Add(new DescriptionAttribute(String.Format("List item at position {0}", (object) this.m_Index)));
		public override string Description
		{
			get { return String.Format("List item at position {0}", m_Index); }
		}
	}
}