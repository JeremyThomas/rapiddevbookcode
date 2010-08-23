using System;
using System.Data.Linq;
using AW.Helper;

namespace AW.Winforms.Helpers.Controls
{
	public interface IDataEditorPersister
	{
		int Save(object dataToSave);
		int Delete(object dataToSave);
		bool CanSave(Type typeToSave);
	}

	public class DataEditorPersister : IDataEditorPersister
	{
		public Type[] SaveableTypes;
		public Func<object, int> SaveFunction;
		public Func<object, int> DeleteFunction;

		public DataEditorPersister(Func<object, int> saveFunction, Func<object, int> deleteFunction, params Type[] saveableTypes)
		{
			SaveableTypes = saveableTypes;
			SaveFunction = saveFunction;
			DeleteFunction = deleteFunction;
		}

		public int Save(object dataToSave)
		{
			return SaveFunction != null ? SaveFunction(dataToSave) : 0;
		}

		public int Delete(object dataToSave)
		{
			return DeleteFunction != null ? DeleteFunction(dataToSave) : 0;
		}

		public bool CanSave(Type typeToSave)
		{
			return SaveFunction != null && (SaveableTypes == null || typeToSave.IsAssignableTo(SaveableTypes));
		}
	}

	public class DataEditorLinqtoSQLPersister : IDataEditorPersister
	{
		private readonly DataContext _dataContext;

		public DataEditorLinqtoSQLPersister(DataContext dataContext)
		{
			_dataContext = dataContext;
		}

		public int Save(object dataToSave)
		{
			var changeSet = _dataContext.GetChangeSet();
			_dataContext.SubmitChanges();
			return changeSet.Inserts.Count + changeSet.Updates.Count;
		}

		public int Delete(object dataToSave)
		{
			_dataContext.SubmitChanges();
			return _dataContext.GetChangeSet().Deletes.Count;
		}

		public bool CanSave(Type typeToSave)
		{
			try
			{
				var metaType = _dataContext.Mapping.GetMetaType(typeToSave);
				//_dataContext.GetTable(typeToSave);
				return metaType.Table != null;
			}
			catch (InvalidOperationException)
			{
				return false;
			}
		}
	}
}