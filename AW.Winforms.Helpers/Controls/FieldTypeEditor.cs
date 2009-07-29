/********************************************************************
	created:	2005/03/27
	created:	27:3:2005   7:05
	filename: 	FieldTypeEditor.cs
	author:		Mike Chaliy
	
	purpose:	Data members fields editor.
*********************************************************************/
using System;
using System.Windows.Forms;
using System.ComponentModel;

namespace Chaliy.Windows.Forms.Design
{
	/// <summary>
	/// Data members fields editor.
	/// </summary>
	public class FieldTypeEditor : DropDownTypeEditor
	{
		#region Constructors
			

		#endregion

		/// <summary>
		/// Fill list box with fileds of the current datasource.
		/// </summary>
		/// <param name="listBox">ListBox control to fill.</param>
		/// <param name="context">Type descriptor context.</param>
		/// <param name="value">Current value.</param>
		protected override void FillListBox(ListBox listBox, ITypeDescriptorContext context, object value)
		{
			string selectedFiled = (string)value;
			if (selectedFiled == null)
			{
				selectedFiled = string.Empty;
			}

			PropertyDescriptor dataSourceDescriptor = TypeDescriptor.GetProperties(context.Instance)["DataSource"];
			PropertyDescriptor dataMemberDescriptor = TypeDescriptor.GetProperties(context.Instance)["DataMember"];
			if (dataSourceDescriptor == null
				|| dataMemberDescriptor == null)
			{
				return;
			}
			object dataSource = dataSourceDescriptor.GetValue(context.Instance);
			string dataMember = (string)dataMemberDescriptor.GetValue(context.Instance);
			if (dataSource != null)
			{
				CurrencyManager currencyManager = new BindingContext()[dataSource, dataMember] as CurrencyManager;
				if (currencyManager != null)
				{
					int lastIndex;
					foreach(PropertyDescriptor descriptor in currencyManager.GetItemProperties())
					{
						lastIndex = listBox.Items.Add(descriptor.Name);
						if (string.Compare(descriptor.Name, selectedFiled) == 0)
						{
							listBox.SelectedIndex = lastIndex;
						}						
					}
				}
			}
		}
	}
}
