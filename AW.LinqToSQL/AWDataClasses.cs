using AW.Helper;

namespace AW.LinqToSQL
{
	partial class AWDataClassesDataContext
	{
		static AWDataClassesDataContext()
		{
			ProfilerHelper.InitializeOrmProfilerIfEnabled();
		}

		public static AWDataClassesDataContext GetNew()
		{
			return new AWDataClassesDataContext();
		}
	}
}