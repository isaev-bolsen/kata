﻿using System;
using System.Collections.Generic;

namespace KATA
{
	public class Foo
	{
		public int i { get; set; }
		public static List<Foo> listOfObjectsCreated = new List<Foo>();

		public Foo()
		{
			Console.WriteLine(GetType() + " Created !");
			listOfObjectsCreated.Add(this);
		}
	}

	public class Bar
	{
		protected virtual Foo foo { get; } = new Foo { i = 1 };
	}

	public class Bar1 : Bar
	{
		protected override Foo foo { get; } = new Foo { i = 2 };

		public Foo fobase => base.foo;
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

