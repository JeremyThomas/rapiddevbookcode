#region Copyright (c) 2003-2005, Luke T. Maxon

/********************************************************************************************************************
'
' Copyright (c) 2003-2005, Luke T. Maxon
' All rights reserved.
' 
' Redistribution and use in source and binary forms, with or without modification, are permitted provided
' that the following conditions are met:
' 
' * Redistributions of source code must retain the above copyright notice, this list of conditions and the
' 	following disclaimer.
' 
' * Redistributions in binary form must reproduce the above copyright notice, this list of conditions and
' 	the following disclaimer in the documentation and/or other materials provided with the distribution.
' 
' * Neither the name of the author nor the names of its contributors may be used to endorse or 
' 	promote products derived from this software without specific prior written permission.
' 
' THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND ANY EXPRESS OR IMPLIED
' WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A
' PARTICULAR PURPOSE ARE DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
' ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT NOT
' LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR PROFITS; OR BUSINESS
' INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY,
' OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN
' IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
'
'*******************************************************************************************************************/

#endregion

using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace NUnit.Extensions.Forms.TestApplications
{
    /// <summary>
    /// Summary description for TreeViewTestForm.
    /// </summary>
    public class TreeViewTestForm : Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private Container components = null;

        private Label myLabel;

        private TreeView myTree;

        public TreeViewTestForm()
        {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            myLabel.Text = e.Node.Text;
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.myTree = new TreeView();
            this.myLabel = new Label();
            this.SuspendLayout();
            // 
            // myTree
            // 
            this.myTree.Anchor = ((AnchorStyles) (((AnchorStyles.Top | AnchorStyles.Bottom) | AnchorStyles.Left)));
            this.myTree.ImageIndex = -1;
            this.myTree.Location = new Point(0, 0);
            this.myTree.Name = "myTree";
            this.myTree.Nodes.AddRange(
                new TreeNode[]
                    {
                        new TreeNode("Node0",
                                     new TreeNode[]
                                         {new TreeNode("Node1", new TreeNode[] {new TreeNode("Node2")})})
                        ,
                        new TreeNode("Node3",
                                     new TreeNode[]
                                         {
                                             new TreeNode("Node4",
                                                          new TreeNode[]
                                                              {
                                                                  new TreeNode("Node5"),
                                                                  new TreeNode("Node6",
                                                                               new TreeNode[]
                                                                                   {
                                                                                       new
                                                                                           TreeNode
                                                                                           ("Node7")
                                                                                       ,
                                                                                       new
                                                                                           TreeNode
                                                                                           ("Node8")
                                                                                       ,
                                                                                       new
                                                                                           TreeNode
                                                                                           ("Node9")
                                                                                   })
                                                              })
                                         })
                    });
            this.myTree.SelectedImageIndex = -1;
            this.myTree.Size = new Size(224, 488);
            this.myTree.TabIndex = 0;
            this.myTree.AfterSelect += new TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // myLabel
            // 
            this.myLabel.Location = new Point(280, 104);
            this.myLabel.Name = "myLabel";
            this.myLabel.TabIndex = 1;
            this.myLabel.Text = "default";
            // 
            // TreeViewTestForm
            // 
            this.AutoScaleDimensions = new SizeF(5, 13);
            this.ClientSize = new Size(568, 485);
            this.Controls.Add(this.myLabel);
            this.Controls.Add(this.myTree);
            this.Name = "TreeViewTestForm";
            this.Text = "TreeControlTestForm";
            this.ResumeLayout(false);
        }

        #endregion
    }
}