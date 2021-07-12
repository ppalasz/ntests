using NSubstitute;
using NUnit.Framework;
using Shouldly;
using TddProject;

namespace NTests.UnitTests
{
	[TestFixture]
	public class TestComputer
	{
		[SetUp]
		public void Setup()
		{

		}

		[TestCase(1, 2, "add", 3)]
		[TestCase(2, 1, "add", 3)]
		[TestCase(1, 2, "multiply", 2)]
		[TestCase(2, 1, "multiply", 2)]
		public void Computer_TwoNumbers_ShouldProcess(int x, int y, string action, int expectedResult)
		{
			var processor = Substitute.For<IProcessor>();

			processor
				.Add(x, y)
				.Returns(expectedResult);

			processor
				.Multiply(x, y)
				.Returns(expectedResult);

			var computer = new Computer(processor);

			var result = computer.ProcessNumbers(action, x, y);

			result.ShouldBe(expectedResult);

		}

		[TestCase(-1, 2, "multiply", -2)]
		[TestCase(-2, 1, "multiply", -2)]
		[TestCase(-1, 1, "add", 0)]
		[TestCase(1, -1, "add", 0)]
		[TestCase(0, 0, "add", 0)]
		public void Computer_PositiveAndNegativeNumber_ShouldProcess(int x, int y, string action, int expectedResult)
		{
			var processor = Substitute.For<IProcessor>();
			var counter = 0;

			processor
				.Add(x, y)
				.Returns(xp => x + y)
				.AndDoes(t => counter++);

			processor
				.Multiply(x, y)
				.Returns(xp => x * y)
				.AndDoes(t => counter++);

			var computer = new Computer(processor);

			var result = computer.ProcessNumbers(action, x, y);

			result.ShouldBe(expectedResult);
			counter.ShouldBe(1);

		}


	}
}