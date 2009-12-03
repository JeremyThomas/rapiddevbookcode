﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AW.Winforms.Helpers.Properties;

namespace AW.Winforms.Helpers.DataEditor
{
  public partial class FrmDataEditor : Form
  {
    public FrmDataEditor()
    {
      InitializeComponent();
      AWHelper.SetWindowSizeAndLocation(this, Settings.Default.EntityViewerSizeLocation);
    }

    private void FrmDataEditor_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.EntityViewerSizeLocation = AWHelper.GetWindowNormalSizeAndLocation(this);
      Settings.Default.Save();
    }
  }
}
