using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AW.Helper
{
	[Serializable]
	class EnumerableTransporter
	{

	}

	[Serializable]
	class PropertyDescriptorTransporter
	{
		public Type PropertyType { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
