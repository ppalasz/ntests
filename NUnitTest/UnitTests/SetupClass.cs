using NUnit.Framework;

namespace NTests.UnitTests
{
	[SetUpFixture]//for all tests in assembly
	internal class SetupClass
	{
		[OneTimeSetUp]//before starting tests
		public void Init()
		{
		}

		[OneTimeTearDown]//on the very end of tests
		public void Cleanup()
		{
		}
	}
}