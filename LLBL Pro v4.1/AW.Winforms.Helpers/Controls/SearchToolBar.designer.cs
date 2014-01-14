namespace ACS.UserControls
{
    partial class SearchToolBar
    {
        /// <summary> 
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Обязательный метод для поддержки конструктора - не изменяйте 
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchToolBar));
            this.closeButton = new System.Windows.Forms.ToolStripButton();
            this.searchLabel = new System.Windows.Forms.ToolStripLabel();
            this.columnComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.searchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fromBeginButton = new System.Windows.Forms.ToolStripButton();
            this.caseSensButton = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.wholeWordButton = new System.Windows.Forms.ToolStripButton();
            this.searchSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            resources.ApplyResources(this.closeButton, "closeButton");
            this.closeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.closeButton.Name = "closeButton";
            this.closeButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // searchLabel
            // 
            resources.ApplyResources(this.searchLabel, "searchLabel");
            this.searchLabel.Name = "searchLabel";
            // 
            // columnComboBox
            // 
            this.columnComboBox.Name = "columnComboBox";
            this.columnComboBox.AutoToolTip = true;
            this.columnComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnComboBox.Items.AddRange(new object[] {
                resources.GetString("columnComboBox.Items")});
            this.columnComboBox.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
            resources.ApplyResources(this.columnComboBox, "columnComboBox");
            // 
            // searchTextBox
            // 
            resources.ApplyResources(this.searchTextBox, "searchTextBox");
            this.searchTextBox.ForeColor = System.Drawing.Color.LightGray;
            this.searchTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.searchTextBox.Enter += new System.EventHandler(this.searchTextBox_Enter);
            this.searchTextBox.Leave += new System.EventHandler(this.searchTextBox_Leave);
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextBox_KeyDown);
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
            // 
            // fromBeginButton
            // 
            resources.ApplyResources(this.fromBeginButton, "fromBeginButton");
            this.fromBeginButton.Checked = true;
            this.fromBeginButton.CheckOnClick = true;
            this.fromBeginButton.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fromBeginButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.fromBeginButton.Name = "fromBeginButton";
            // 
            // caseSensButton
            // 
            resources.ApplyResources(this.caseSensButton, "caseSensButton");
            this.caseSensButton.CheckOnClick = true;
            this.caseSensButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.caseSensButton.Name = "caseSensButton";
            // 
            // searchButton
            // 
            resources.ApplyResources(this.searchButton, "searchButton");
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Name = "searchButton";
            this.searchButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // wholeWordButton
            // 
            resources.ApplyResources(this.wholeWordButton, "wholeWordButton");
            this.wholeWordButton.CheckOnClick = true;
            this.wholeWordButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.wholeWordButton.Margin = new System.Windows.Forms.Padding(1, 1, 1, 2);
            this.wholeWordButton.Name = "wholeWordButton";
            // 
            // searchSeparator
            // 
            resources.ApplyResources(this.searchSeparator, "searchSeparator");
            this.searchSeparator.Name = "searchSeparator";
            // 
            // SearchToolBar
            // 
            resources.ApplyResources(this, "$this");
            this.AllowMerge = false;
            this.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeButton,
            this.searchLabel,
            this.columnComboBox,
            this.searchTextBox,
            this.fromBeginButton,
            this.wholeWordButton,
            this.caseSensButton,
            this.searchSeparator,
            this.searchButton});
            this.MaximumSize = new System.Drawing.Size(0, 27);
            this.MinimumSize = new System.Drawing.Size(0, 27);
            this.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.Resize += new System.EventHandler(this.SearchToolBar_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton closeButton;
        private System.Windows.Forms.ToolStripLabel searchLabel;
        private System.Windows.Forms.ToolStripComboBox columnComboBox;
        private System.Windows.Forms.ToolStripTextBox searchTextBox;
        private System.Windows.Forms.ToolStripButton fromBeginButton;
        private System.Windows.Forms.ToolStripButton caseSensButton;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton wholeWordButton;
        private System.Windows.Forms.ToolStripSeparator searchSeparator;
    }
}
