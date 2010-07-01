using System;
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
}