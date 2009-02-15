using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace AW.Winforms.Helpers
{
  public partial class FrmReconcile: Form
  {
    private IEntity Entity { get; set; }
    private IEntity DBEntity { get; set; }

    public FrmReconcile()
    {
      InitializeComponent();
    }

    private readonly IEnumerable<ConflictResolution> conflicts;
    private readonly IEnumerable<ConflictResolution> changes;

    private class ConflictResolution
    {
      public IEntityFieldCore LocalField { get; private set; }
      public IEntityFieldCore DBField { get; private set; }

      public string Name
      {
        get { return LocalField.Name; }
      }

      public object CurrentValue
      {
        get { return LocalField.CurrentValue; }
      }

      public object DbValue
      {
        get { return DBField.DbValue; }
      }

      public bool Conflict
      {
        get { return LocalField.IsChanged; }
      }

      public bool UseYourChanges { get; set; }

      public ConflictResolution(IEntityFieldCore localField, IEntityFieldCore dbField)
      {
        LocalField = localField;
        DBField = dbField;
        UseYourChanges = Conflict;
      }
    }

    public FrmReconcile(IEntity entity)
      : this()
    {
      Entity = entity;
      var ef = entity.GetEntityFactory();
      DBEntity = ef.Create();
      DBEntity.Fields = entity.Fields.Clone();
      DBEntity.Refetch();

      changes = from entityField in entity.Fields.OfType<EntityField>()
                join dbentityField in DBEntity.Fields.OfType<EntityField>() on entityField.Name equals dbentityField.Name
                where !(entityField.DbValue == dbentityField.DbValue || entityField.DbValue.Equals(dbentityField.DbValue))
                select new ConflictResolution(entityField, dbentityField);

      conflicts = (from conflictResolution in changes
                   where conflictResolution.Conflict
                   select conflictResolution).ToList();

      entityFieldBindingSource.DataSource = conflicts;

      //entityFieldDataGridView.AutoGenerateColumns = true;
    }

    private void toolStripButtonToggleUseYourChanges_Click(object sender, EventArgs e)
    {
      foreach (var conflict in conflicts)
      {
        var useYourChanges = !conflict.UseYourChanges;
        conflict.UseYourChanges = useYourChanges;
        var x = conflict.UseYourChanges;
      }
      foreach (DataGridViewRow row in entityFieldDataGridView.Rows)
      {
        //  row.Cells["UseYourChanges"].Value = !Convert.ToBoolean(row.Cells["UseYourChanges"].Value);
      }
      entityFieldBindingSource.ResetBindings(false);

    }

    private void toolStripButtonResolve_Click(object sender, EventArgs e)
    {
      entityFieldBindingSource.EndEdit();
      var NumUseYourChanges = conflicts.Where(c => c.UseYourChanges).Count();

      if (NumUseYourChanges == 0)
        Entity.Fields = DBEntity.Fields.Clone();
      else if (NumUseYourChanges == changes.Count())
        Entity.Save(null);
      else
      {
        foreach (var change in changes)
          if (!change.UseYourChanges)
            Entity.Fields[Entity.Fields.IndexOf(change.LocalField)] = change.DBField.Clone() as EntityField;
        Entity.Save(null);
      }
      DialogResult = DialogResult.OK;
    }

    private void toolStripButtonShowAllChanges_Click(object sender, EventArgs e)
    {
      entityFieldBindingSource.EndEdit();
      if (entityFieldBindingSource.DataSource == conflicts)
        entityFieldBindingSource.DataSource = changes;
      else
        entityFieldBindingSource.DataSource = conflicts;
    }
  }
}