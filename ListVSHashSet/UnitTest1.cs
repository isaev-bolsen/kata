using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	class Foo
	{
		public string Bar => "bar";
	}

	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void AreSame()
		{
			Foo foo = new Foo();
			Assert.AreSame(foo.Bar, foo.Bar);
			Assert.AreSame(foo.Bar, new Foo().Bar);

		}
	}
}
