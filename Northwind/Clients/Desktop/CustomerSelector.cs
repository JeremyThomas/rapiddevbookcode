using Northwind.DAL.EntityClasses;
using Northwind.DAL.Interfaces;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace Northwind.Client.Winforms
{
	/// <summary>
	/// Customer selector. Shows all customers and lets the user select one. 
	/// Illustrates the collection classes and databinding.
	/// </summary>
	public class CustomerSelector : System.Windows.Forms.Form
	{
		#region Components

		private System.Windows.Forms.Button selectButton;
		private System.Windows.Forms.Button cancelButton;
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.DataGrid customersDataGrid;
		#endregion

		#region Class Member Declarations
		private CustomerEntity _selectedCustomer;
		private IEntityCollection2 _allCustomers;
		#endregion

		/// <summary>
		/// CTor
		/// </summary>
		public CustomerSelector(INorthwindService service)
		{
			InitializeComponent();

			// get all customers
			_allCustomers = service.GetAllCustomers();
			// bind to grid.
			customersDataGrid.DataSource = _allCustomers;

			if(_allCustomers.Count>0)
			{
				// there are customers, enable select button
				selectButton.Enabled=true;

				// select first row.
				customersDataGrid.Select(0);
			}
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.customersDataGrid = new System.Windows.Forms.DataGrid();
			this.selectButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// customersDataGrid
			// 
			this.customersDataGrid.AllowNavigation = false;
			this.customersDataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
				| System.Windows.Forms.AnchorStyles.Left) 
				| System.Windows.Forms.AnchorStyles.Right)));
			this.customersDataGrid.CaptionText = "All Customers found";
			this.customersDataGrid.DataMember = "";
			this.customersDataGrid.HeaderForeColor = System.Drawing.SystemColors.ControlText;
			this.customersDataGrid.Location = new System.Drawing.Point(6, 6);
			this.customersDataGrid.Name = "customersDataGrid";
			this.customersDataGrid.ReadOnly = true;
			this.customersDataGrid.Size = new System.Drawing.Size(615, 537);
			this.customersDataGrid.TabIndex = 0;
			// 
			// selectButton
			// 
			this.selectButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.selectButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.selectButton.Enabled = false;
			this.selectButton.Location = new System.Drawing.Point(224, 549);
			this.selectButton.Name = "selectButton";
			this.selectButton.TabIndex = 1;
			this.selectButton.Text = "Select";
			this.selectButton.Click += new System.EventHandler(this.selectButton_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(326, 549);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.TabIndex = 2;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
			// 
			// CustomerSelector
			// 
			this.AcceptButton = this.selectButton;
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(628, 581);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.selectButton);
			this.Controls.Add(this.customersDataGrid);
			this.Name = "CustomerSelector";
			this.Text = "Customer selector";
			((System.ComponentModel.ISupportInitialize)(this.customersDataGrid)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void cancelButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.Close();
		}

		private void selectButton_Click(object sender, System.EventArgs e)
		{
			this.DialogResult = System.Windows.Forms.DialogResult.OK;
			_selectedCustomer = (CustomerEntity)_allCustomers[customersDataGrid.CurrentRowIndex];
			this.Close();
		}

		#region Class Property Declarations
		/// <summary>
		/// Gets the selected customer
		/// </summary>
		public CustomerEntity SelectedCustomer
		{
			get
			{
				return _selectedCustomer;
			}
		}
		#endregion
	}
}
