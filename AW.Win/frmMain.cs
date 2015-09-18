using System;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using AW.Data;
using AW.Data.DaoClasses;
using AW.Data.EntityClasses;
using AW.Data.Linq;
using AW.Helper;
using AW.Helper.LLBL;
using AW.Win.Properties;
using AW.Winforms.Helpers;
using AW.Winforms.Helpers.Controls;
using AW.Winforms.Helpers.Forms;
using AW.Winforms.Helpers.LLBL;
using AW.Winforms.Helpers.LLBL.PropGridEx;
using AW.Winforms.Helpers.MostRecentlyUsedHandler;
using AW.Winforms.Helpers.QueryRunner;

namespace AW.Win
{
  public partial class FrmMain : FrmPersistantLocation
  {
    public FrmMain()
    {
      InitializeComponent();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      MetaDataHelper.FoldAllAssociatedMetadataProvidersIntoTheSubjectType(typeof (CommonEntityBase));
      reOpenWindowsToolStripMenuItem.Checked = Settings.Default.ReopenWindows;
    }

    private void frmMain_Shown(object sender, EventArgs e)
    {
      if (!Settings.Default.ReopenWindows || Settings.Default.OpenWindows == null) return;
      var queryRunners = (from string formName in Settings.Default.OpenWindows.ToBindingListView()
        select LaunchChildForm(formName) as FrmQueryRunner).ToList();
      foreach (var runner in queryRunners)
      {
        if (runner != null)
          runner.OpenFiles(Settings.Default.QueryFilesToReopen);
        Application.DoEvents();
      }
    }

    private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
    {
      Settings.Default.Save();
    }

    private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
    {
      Settings.Default.ReopenWindows = reOpenWindowsToolStripMenuItem.Checked;
      if (Settings.Default.OpenWindows == null)
        Settings.Default.OpenWindows = new StringCollection();
      else
        Settings.Default.OpenWindows.Clear();
      if (!Settings.Default.ReopenWindows || MdiChildren.Length <= 0) return;
      foreach (var myForm in MdiChildren.Where(myForm => Convert.ToBoolean(myForm.Tag)))
      {
        Settings.Default.OpenWindows.Add(myForm.GetType().FullName);
        var form = myForm as FrmQueryRunner;
        if (form != null)
          Settings.Default.QueryFilesToReopen = form.GetOpenFiles();
      }
    }

    private Form LaunchChildForm(string formName)
    {
      var formType = Type.GetType(formName);
      if (formType == null)
        return LaunchChildForm(formName, typeof (FrmQueryRunner), typeof (FrmLLBLEntityViewer), typeof (FrmEntitiesAndFields), typeof (FrmPersistantLocation));
      return LaunchChildForm(formType);
    }

    private Form LaunchChildForm(string formName, params Type[] formTypes)
    {
      foreach (var formType in formTypes.Where(formType => formName == formType.FullName))
      {
        if (formType == typeof (FrmLLBLEntityViewer))
          viewMetadataToolStripMenuItem_Click(null, null);
        else if (formType == typeof (FrmEntitiesAndFields))
          viewEntitiesAndFieldsToolStripMenuItem_Click(null, null);
        return LaunchChildForm(formType);
      }
      return null;
    }

    public Form LaunchChildForm(Type formType, params Object[] args)
    {
      return formType == null ? null : formType == typeof (FrmEasyQuery) ? LaunchEasyQuery()
        : formType == typeof (FrmPersistantLocation) ? ShowDataBrowser()
          : AWHelper.LaunchChildForm(this, formType, args);
    }

    private T LaunchChildFormGeneric<T>(params Object[] args) where T : Form
    {
      return (T) LaunchChildForm(typeof (T), args);
    }

    private FrmQueryRunner LaunchQueryRunner()
    {
      var qr = LaunchChildFormGeneric<FrmQueryRunner>();
      if (qr != null)
      {
        qr.SaveFunction += EntityHelper.Save;
        qr.DeleteFunction += EntityHelper.Delete;
      }
      return qr;
    }

    private FrmEasyQuery LaunchEasyQuery(string fileName = null)
    {
      var frmEasyQuery = (FrmEasyQuery) (AWHelper.LaunchChildForm(this, typeof (FrmEasyQuery)));
      frmEasyQuery.MRUHandlerProject = mruHandlerProject;
      Application.DoEvents();
      frmEasyQuery.LoadFromFile(fileName);
      return frmEasyQuery;
    }

    private void ordersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrderSearch));
    }

    private void orders2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrderSearch2));
    }

    private void customersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmCustomers));
    }

    private void organizationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrganization));
    }

    private void vacationBonusUtilityToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmVacationBonus));
    }

    private void traceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmTrace));
    }

    private void fileToolStripMenuItemOpen_Click(object sender, EventArgs e)
    {
      var dr = openFileDialogProject.ShowDialog();

      if (dr == DialogResult.OK)
        DoFileOpen(openFileDialogProject.FileNames);
    }

    private void DoFileOpen(string fileName)
    {
      if (".XML".Equals(Path.GetExtension(fileName), StringComparison.OrdinalIgnoreCase))
      {
        LaunchEasyQuery(fileName);
      }
      else
      {
        var frmQueryRunner = LaunchQueryRunner();
        if (frmQueryRunner != null) frmQueryRunner.DoFileOpen(fileName);
      }
      openFileDialogProject.InitialDirectory = Path.GetDirectoryName(fileName);
      mruHandlerProject.AddRecentlyUsedFile(fileName);
    }

    private void mruHandlerProject_MRUItemClicked(object sender, MRUItemClickedEventArgs e)
    {
      DoFileOpen(e.File);
    }

    #region WindowsMenuHandlers

    private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.Cascade);
    }

    private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileVertical);
    }

    private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.TileHorizontal);
    }

    private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LayoutMdi(MdiLayout.ArrangeIcons);
    }

    private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (var childForm in MdiChildren)
      {
        childForm.Close();
      }
    }

    #endregion

    private void adHocLINQQueryRunnerToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchQueryRunner();
    }

    private void viewMetadataToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var childForm = LaunchChildForm(typeof (FrmLLBLEntityViewer), MetaSingletons.MetaData);
      childForm.Tag = true;
    }

    private void viewEntitiesAndFieldsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var childForm = LaunchChildForm(typeof (FrmEntitiesAndFields), MetaSingletons.MetaData, true, null);
      childForm.Tag = true;
    }

    private void dataBrowserToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ShowDataBrowser();
    }

    private FrmPersistantLocation ShowDataBrowser()
    {
      var childForm = UsrCntrlEntityBrowser.ShowDataBrowser(MetaSingletons.MetaData, this);
      childForm.Tag = true;
      return childForm;
    }

    private void organizationStructureToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchChildForm(typeof (FrmOrganizationStructure));
    }

    private void easyQueryToolStripMenuItem_Click(object sender, EventArgs e)
    {
      LaunchEasyQuery();
    }

    private void frmMain_DragDrop(object sender, DragEventArgs e)
    {
      var files = (string[]) e.Data.GetData(DataFormats.FileDrop);
      if (files != null)
      {
        Activate();
        DoFileOpen(files);
      }
    }

    private void DoFileOpen(params string[] fileNames)
    {
      foreach (var fileName in fileNames)
        DoFileOpen(fileName);
    }

    private void frmMain_DragOver(object sender, DragEventArgs e)
    {
      e.Effect = e.Data.GetDataPresent(DataFormats.FileDrop) ? DragDropEffects.Move : DragDropEffects.None;
    }

    private void organizationStructureEditorToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var employeeEntities =LinqMetaData.CreateWithContext().Employee.PrefetchAll();
      var form = ShowControlInForm(LLBLWinformHelper.HierarchyEditorFactoryServicing(employeeEntities, em => em.EmployeeID, em => em.ManagerID, em => em.EmployeeDisplayName), "Employee Hierarchy In Tree " + employeeEntities, this);
      form.Tag = true;
    }
    private void organizationStructureEditorSelfJoinToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //var employeeEntities = EmployeeEntity.WireUpSelfJoin(MetaSingletons.MetaData.Employee.PrefetchAllButManages().ToEntityCollection());  
      var employeeEntities = EmployeeEntity.WireUpSelfJoin(LinqMetaData.CreateWithContext().Employee.PrefetchAll());
      var form = ShowControlInForm(LLBLWinformHelper.HierarchyEditorFactoryServicing(employeeEntities.Where(em => em.ManagerID == null), em => em.EmployeeDisplayName, em => em.Manages), "Employee Hierarchy In Tree "+ employeeEntities, this);
      form.Tag = true;
    }

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      //  LaunchChildForm(typeof(AboutBox));
      var moreInfo = Environment.NewLine + Environment.NewLine;
      moreInfo += "https://rapiddevbookcode.codeplex.com/documentation" + Environment.NewLine;
      moreInfo += Environment.NewLine + Environment.NewLine + ProfilerHelper.OrmProfilerStatus;
      var commonDaoBase = new CommonDaoBase();
      var dbConnection = commonDaoBase.CreateConnection();
      moreInfo += string.Format("{0}OrmProfiler has {1}wrapped the DbProviderFactory", Environment.NewLine, (ProfilerHelper.DbProviderFactoryIsWrappedByOrmProfiler(dbConnection.GetType())
        ? "" : "NOT "));
      var ab = new AboutBox(moreInfo);
      ab.ShowDialog(this);
    }


  }
}