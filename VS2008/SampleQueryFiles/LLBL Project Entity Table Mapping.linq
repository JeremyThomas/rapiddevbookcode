<Query Kind="Program">
  <Reference>&lt;ProgramFiles&gt;\Solutions Design\LLBLGen Pro v2.6\SD.LLBLGen.Pro.ApplicationCore.dll</Reference>
  <Reference>&lt;ProgramFiles&gt;\Solutions Design\LLBLGen Pro v2.6\SD.LLBLGen.Pro.DBDriverCore.dll</Reference>
  <Namespace>SD.LLBLGen.Pro.ApplicationCore</Namespace>
  <Namespace>SD.LLBLGen.Pro.ApplicationCore.Entities</Namespace>
</Query>

void Main()
{
	var project = Project.Load(@"C:\Documents and Settings\All Users\Documents\dev\Visual Studio Projects\BookSource\Code Sample\Ancillary\AW.Data.Plural.lgp");
	QueryProject(project).Dump();	
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