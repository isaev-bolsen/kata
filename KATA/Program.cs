using System;
using System.Collections.Generic;

namespace KATA
{
	public class Foo
	{
		public static List<Foo> listOfObjectsCreated = new List<Foo>();

		public Foo()
		{
			Console.WriteLine(GetType() + " Created !");
			listOfObjectsCreated.Add(this);
		}
	}

	public class Bar
	{
		protected virtual Foo foo { get; } = new Foo();
	}

	public class Bar1 : Bar
	{
		protected override Foo foo { get; } = new Foo();
	}

	class Program
	{
		static void Main(string[] args)
		{
			Bar1 b = new Bar1();
			Console.WriteLine(Foo.listOfObjectsCreated.Count);
		}
	}
}

