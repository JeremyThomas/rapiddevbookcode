using AW.Helper;

namespace AW.LinqToSQL
{
	partial class AWDataClassesDataContext
	{
		static AWDataClassesDataContext()
		{
      ProfilerHelper.InitializeOrmProfiler();
		}

		public static AWDataClassesDataContext GetNew()
		{
			return new AWDataClassesDataContext();
		}
	}
}