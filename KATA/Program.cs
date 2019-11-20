using System;

namespace KATA
{
	public class Foo
	{
		public Foo()
		{
			Console.WriteLine(GetType() + " Created !");
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
		}
	}
}

