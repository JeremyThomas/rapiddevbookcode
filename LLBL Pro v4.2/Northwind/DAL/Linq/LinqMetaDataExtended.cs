using Northwind.DAL.EntityClasses;

namespace Northwind.DAL.Linq
{
	partial class LinqMetaData
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