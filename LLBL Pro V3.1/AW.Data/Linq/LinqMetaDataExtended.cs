using AW.Data.EntityClasses;

namespace AW.Data.Linq
{
	partial class LinqMetaData
	{
		static LinqMetaData()
		{
			//if (Environment.Version.Major >= 4)
				CommonEntityBase.Initialize();
		}
	}
}