using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace ACS.UserControls
{
  /// <summary>
  /// https://adgv.codeplex.com/releases/view/116820
  /// </summary>
    public partial class SearchToolBar : ToolStrip
    {
        public event SearchToolBarSearchEventHandler Search;

        private DataGridViewColumnCollection columnsList = null;

        public SearchToolBar()
        {
            InitializeComponent();
            this.searchTextBox.Text = this.searchTextBox.ToolTipText;
            this.columnComboBox.SelectedIndex = 0;
        }

        void searchButton_Click(object sender, System.EventArgs e)
        {
            if (this.searchTextBox.TextLength > 0 && this.searchTextBox.Text != this.searchTextBox.ToolTipText && this.Search != null)
            {
                DataGridViewColumn c = null;
                if (this.columnComboBox.SelectedIndex > 0 && this.columnsList != null && this.columnsList.GetColumnCount(DataGridViewElementStates.Visible) > 0)
                {
                    DataGridViewColumn[] cols = this.columnsList.Cast<DataGridViewColumn>().Where(col => col.Visible).ToArray<DataGridViewColumn>();

                    if (cols.Length == this.columnComboBox.Items.Count-1)
                    {
                        if (cols[this.columnComboBox.SelectedIndex - 1].HeaderText == this.columnComboBox.SelectedItem.ToString())
                            c = cols[this.columnComboBox.SelectedIndex - 1];
                    }
                }
                
                SearchToolBarSearchEventArgs args = new SearchToolBarSearchEventArgs(
                    this.searchTextBox.Text,
                    c, 
                    this.caseSensButton.Checked,
                    this.wholeWordButton.Checked,
                    this.fromBeginButton.Checked
                );
                this.Search(this, args);
            }
        }

        void searchTextBox_TextChanged(object sender, System.EventArgs e)
        {
            this.searchButton.Enabled = this.searchTextBox.TextLength > 0 && this.searchTextBox.Text != this.searchTextBox.ToolTipText;
        }

        void closeButton_Click(object sender, System.EventArgs e)
        {
            this.Hide();
        }

        void searchTextBox_Enter(object sender, System.EventArgs e)
        {
            if (this.searchTextBox.Text == this.searchTextBox.ToolTipText && this.searchTextBox.ForeColor == System.Drawing.Color.LightGray)
                this.searchTextBox.Text = "";
            else
                this.searchTextBox.SelectAll();

            this.searchTextBox.ForeColor = SystemColors.WindowText;
        }

        void searchTextBox_Leave(object sender, System.EventArgs e)
        {
            if (this.searchTextBox.Text.Trim() == "")
            {
                this.searchTextBox.Text = this.searchTextBox.ToolTipText;
                this.searchTextBox.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        public void SetColumns(DataGridViewColumnCollection columns)
        {
            this.columnsList = columns;
            this.columnComboBox.BeginUpdate();
            this.columnComboBox.Items.Clear();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchToolBar));
            this.columnComboBox.Items.AddRange(new object[] {resources.GetString("columnComboBox.Items")});
            if (this.columnsList != null)
                foreach (DataGridViewColumn c in this.columnsList)
                    if (c.Visible)
                        this.columnComboBox.Items.Add(c.HeaderText);
            this.columnComboBox.SelectedIndex = 0;
            this.columnComboBox.EndUpdate();
        }

        void searchTextBox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (this.searchTextBox.TextLength > 0 && this.searchTextBox.Text != this.searchTextBox.ToolTipText && e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = false;
                e.Handled = true;
                searchButton_Click(this.searchButton, new EventArgs());
            }
        }

        private void ResizeBoxes(int width, ref int w1, ref int w2)
        {
            int dif = (int)Math.Round((width - this.Width) / 2.0, 0, MidpointRounding.AwayFromZero);

            int oldW1 = w1;
            int oldW2 = w2;
            if (this.Width < width)
            {
                w1 = Math.Max(w1 - dif, 75);
                w2 = Math.Max(w2 - dif, 75);
            }
            else
            {
                w1 = Math.Min(w1 - dif, 150);
                w2 += this.Width - width + oldW1 - w1;
            }
        }
        private void SearchToolBar_Resize(object sender, System.EventArgs e)
        {
            this.SuspendLayout();
            int w1 = 150;
            int w2 = 150;
            int oldW = this.columnComboBox.Width + this.searchTextBox.Width;
            foreach (System.Windows.Forms.ToolStripItem c in this.Items)
            {
                c.Overflow = ToolStripItemOverflow.Never;
                c.Visible = true;
            }

            int width = this.PreferredSize.Width - oldW + w1 + w2;
            if (this.Width < width) // ширина элемента недостаточна
            {
                this.searchLabel.Visible = false;
                ResizeBoxes(this.PreferredSize.Width - oldW + w1 + w2, ref w1, ref w2);
                width = this.PreferredSize.Width - oldW + w1 + w2;

                if (this.Width < width)
                {
                    this.caseSensButton.Overflow = ToolStripItemOverflow.Always;
                    ResizeBoxes(this.PreferredSize.Width - oldW + w1 + w2, ref w1, ref w2);
                    width = this.PreferredSize.Width - oldW + w1 + w2;
                }
                
                if (this.Width < width)
                {
                    this.wholeWordButton.Overflow = ToolStripItemOverflow.Always;
                    ResizeBoxes(this.PreferredSize.Width - oldW + w1 + w2, ref w1, ref w2);
                    width = this.PreferredSize.Width - oldW + w1 + w2;
                }

                if (this.Width < width)
                {
                    this.fromBeginButton.Overflow = ToolStripItemOverflow.Always;
                    this.searchSeparator.Visible = false;
                    ResizeBoxes(this.PreferredSize.Width - oldW + w1 + w2, ref w1, ref w2);
                    width = this.PreferredSize.Width - oldW + w1 + w2;
                }

                if (this.Width < width)
                {
                    this.columnComboBox.Overflow = ToolStripItemOverflow.Always;
                    this.searchTextBox.Overflow = ToolStripItemOverflow.Always;
                    w1 = 150;
                    w2 = Math.Max(this.Width - this.PreferredSize.Width - this.searchTextBox.Margin.Left - this.searchTextBox.Margin.Right, 75);
                    this.searchTextBox.Overflow = ToolStripItemOverflow.Never;
                    width = this.PreferredSize.Width - this.searchTextBox.Width + w2;
                }
                if (this.Width < width)
                {
                    this.searchButton.Overflow = ToolStripItemOverflow.Always;
                    w2 = Math.Max(this.Width - this.PreferredSize.Width + this.searchTextBox.Width, 75);
                    width = this.PreferredSize.Width - this.searchTextBox.Width + w2 ;
                } 
                if (this.Width < width)
                {
                    this.closeButton.Overflow = ToolStripItemOverflow.Always;
                    this.searchTextBox.Margin = new System.Windows.Forms.Padding(8, 2, 8, 2);
                    w2 = Math.Max(this.Width - this.PreferredSize.Width + this.searchTextBox.Width, 75);
                    width = this.PreferredSize.Width - this.searchTextBox.Width + w2;
                }
                
                if (this.Width < width)
                {
                    w2 = Math.Max(this.Width - this.PreferredSize.Width + this.searchTextBox.Width, 20);
                    width = this.PreferredSize.Width - this.searchTextBox.Width + w2;
                }
                if (width > this.Width)
                {
                    this.searchTextBox.Overflow = ToolStripItemOverflow.Always;
                    this.searchTextBox.Margin = new System.Windows.Forms.Padding(0, 2, 8, 2);
                    w2 = 150;
                }
            }
            else // ширина элемента больше необходимой
            {
                ResizeBoxes(width, ref w1, ref w2);
            }

            if (this.columnComboBox.Width != w1)
                this.columnComboBox.Width = w1;
            if (this.searchTextBox.Width != w2)
                this.searchTextBox.Width = w2;
            
            this.ResumeLayout();
        }
    }

    public delegate void SearchToolBarSearchEventHandler(object sender, SearchToolBarSearchEventArgs e);

    public class SearchToolBarSearchEventArgs : EventArgs
    {
        public string ValueToSearch { get; private set; }
        public DataGridViewColumn ColumnToSearch { get; private set; }
        public bool CaseSensitive { get; private set; }
        public bool WholeWord { get; private set; }
        public bool FromBegin { get; private set; }

        public SearchToolBarSearchEventArgs(string Value, DataGridViewColumn Column, bool Case, bool Whole, bool fromBegin)
        {
            this.ValueToSearch = Value;
            this.ColumnToSearch = Column;
            this.CaseSensitive = Case;
            this.WholeWord = Whole;
            this.FromBegin = fromBegin;
        }
    }
}
