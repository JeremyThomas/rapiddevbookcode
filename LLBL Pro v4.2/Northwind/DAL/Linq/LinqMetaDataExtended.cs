using Northwind.DAL.EntityClasses;

namespace Northwind.DAL.Linq
{
	partial class LinqMetaData: INorthwindLinqMetaData
	{
		static LinqMetaData()
		{
			CommonEntityBase.Initialize();
		}

		public static void Initialize()
		{
		}
	}
}