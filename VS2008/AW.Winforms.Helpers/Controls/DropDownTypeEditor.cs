/********************************************************************
	created:	2005/03/27
	created:	27:3:2005   7:05
	filename: 	DropDownTypeEditor.cs	
	author:		Mike Chaliy
	
	purpose:	Base class for simple drop down type editors.
*********************************************************************/
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Chaliy.Windows.Forms.Design
{
	/// <summary>
	/// Base class for simple drop down type editors.
	/// </summary>	
	public abstract class DropDownTypeEditor : System.Drawing.Design.UITypeEditor 
	{		
		#region Fields

		private IWindowsFormsEditorService editorService;

		#endregion

		#region Events
		
		private void ListBox_SelectedIndexChanged(object objSender, EventArgs eventArgs) 
		{
			if(this.editorService != null ) 
			{
				this.editorService.CloseDropDown();
			}
		}

		#endregion

		#region Implemenatation
		
		/// <summary>
		/// Overrides to set editor style in DropDown.
		/// </summary>
		/// <param name="context">Type descriptor context.</param>
		/// <returns>Style of the editor.</returns>
		public override System.Drawing.Design.UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
		{
			if( context != null && context.Instance != null ) 
			{
				return UITypeEditorEditStyle.DropDown;
			}
			return base.GetEditStyle(context);
		}				

		
		public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
		{			
			if(context != null && context.Instance != null && context.Container != null && provider != null ) 
			{
				this.editorService = provider.GetService(typeof(IWindowsFormsEditorService)) as IWindowsFormsEditorService;
				if(this.editorService != null )
				{
					
					using(ListBox listBox = new ListBox())
					{
						listBox.BorderStyle = BorderStyle.None;
					
						this.FillListBox(listBox, context, value);					
						listBox.SelectedIndexChanged += new EventHandler(ListBox_SelectedIndexChanged);
					
						this.editorService.DropDownControl(listBox);
					
						if(listBox.SelectedItem != null)
						{						
							value = GetValueFromListItem(context, listBox.SelectedItem);
						}					
						listBox.SelectedIndexChanged -= new EventHandler(ListBox_SelectedIndexChanged);	
					}
					this.editorService = null;
				}
			}
			return value;
		}
		
		/// <summary>
		/// Implement this to fill listBox.Items.
		/// </summary>
		/// <param name="listBox">ListBox control to fill.</param>
		/// <param name="context">Type descriptor context.</param>
		/// <param name="value">Current value.</param>
		protected abstract void FillListBox(ListBox listBox, ITypeDescriptorContext context, object value);

		/// <summary>
		/// Override this to change output value.
		/// </summary>
		/// <param name="context">Type descriptor context.</param>
		/// <param name="value">Value to change.</param>
		/// <returns>Changed value.</returns>
		protected virtual object GetValueFromListItem(ITypeDescriptorContext context, object value)
		{
			return value;
		}


		#endregion		
	}
}
