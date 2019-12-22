using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ListVSHashSet
{
	[TestClass]
	public class ListVSHashSet
	{
		private const int elementsCount = int.MaxValue / 100;

		[TestMethod]
		public void AddItemHashSet()
		{
			HashSet<string> col = new HashSet<string>();
			for (int i = 0; i < elementsCount; ++i)
			{
				col.Add(i.ToString());
			}
		}

		[TestMethod]
		public void AddItemList()
		{
			List<string> col = new List<string>();
			for (int i = 0; i < elementsCount; ++i)
			{
				col.Add(i.ToString());
			}
		}

		[TestMethod]
		public void AddUniqueItemList()
		{
			List<string> col = new List<string>();
			for (int i = 0; i < elementsCount; ++i)
			{
				string str = i.ToString();
				if (!col.Contains(str))
					col.Add(str);
			}
		}
	}
}
