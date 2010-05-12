//css_ref SD.LLBLGen.Pro.ORMSupportClasses.NET20.dll;
//css_ref SD.LLBLGen.Pro.DBDriverCore.dll;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using AW.Data;
using AW.Data.Linq;
using System.Windows.Forms;
using SD.LLBLGen.Pro.ApplicationCore;
using SD.LLBLGen.Pro.ApplicationCore.Entities;
using AW.Winforms.Helpers.QueryRunner;
using AW.Winforms.Helpers.EntityViewer;

public class Script : MarshalByRefObject, IQueryScript
{
  public IEnumerable Query()
  {
//var project = Project.Load(@"C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\Ancillary\AW.Data.Plural.lgp");
    var project = ((SD.LLBLGen.Pro.ApplicationCore.Project)((FrmEntityViewer)Application.OpenForms[2]).ObjectBeingBrowsed);
    return QueryProject(project);
  }

	public IEnumerable QueryProject(Project project)
	{
	  return from entity in project.Entities.OfType<EntityDefinition>()
			 select
			   new
				 {
				   Groups = string.Join(", ", (from peg in project.ProjectElementGroups.Values.OfType<ProjectElementGroup>()
											  from ed in peg.Keys.OfType<EntityDefinition>()
											  where !peg.IsSystemGroup && ed.ElementName == entity.ElementName
											  select peg.Name).Distinct().ToArray()),
				   entity.ElementTargetName,
				   entity.ElementName,
				   entity.TargetType,
				   Description = entity.CustomProperties.ContainsKey("MS_Description") ? entity.CustomProperties["MS_Description"].ToString() : string.Empty
				 };
	}

}