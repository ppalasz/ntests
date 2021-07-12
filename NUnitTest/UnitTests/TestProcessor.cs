using System;
using System.Numerics;
using NUnit.Framework;
using Shouldly;
using TddProject;

namespace NTests.UnitTests
{
	[TestFixture]
	public class TestProcessor
	{
		[SetUp]//before each test
		public void Setup()
		{
		}

		[TearDown]//after each test
		public void TearDown()
		{
		}

		[OneTimeSetUp]//before starting tests
		public void Init()
		{
		}

		[OneTimeTearDown]//on the very end of tests
		public void Cleanup()
		{
		}

		[TestCase(10, new int[] { 1, 2, 3, 4 })]//array param cannot be first
		public void Processor_AddManyNumbers_ShouldAdd(int expectedResult, int[] x)
		{
			var processor = new Processor();

			var result = processor.Add(x);

			result.ShouldBe(expectedResult);

		}

		[TestCase(0)]
		[TestCase(-1)]
		[TestCase(1)]
		[TestCase(int.MaxValue)]
		[TestCase(int.MinValue)]
		public void Processor_AddOneNumber_ShouldReturnNumber(int x)
		{
			var processor = new Processor();

			var result = processor.Add(x);

			result.ShouldBe(x);
		}

		[Test]
		public void Processor_AddNull_ShouldReturnZero()
		{
			var processor = new Processor();

			var result = processor.Add();

			result.ShouldBe(0);

		}

		[Test]
		public void Processor_AddHugeNumbers_ShouldAdd()
		{
			var processor = new Processor();

			var result = processor.Add(int.MaxValue, int.MaxValue);

			var expectedResults = new BigInteger(int.MaxValue) + int.MaxValue;

			result.ShouldBe(expectedResults);

		}



		[TestCase(24, new int[] { 1, 2, 3, 4 })]//array param cannot be first
		public void Processor_MultiplyManyNumbers_ShouldMultiply(int expectedResult, int[] x)
		{
			var processor = new Processor();

			var result = processor.Multiply(x);

			result.ShouldBe(expectedResult);

		}

		[Test]
		public void Processor_MultiplyOneNumber_ShouldReturnNumber()
		{
			var processor = new Processor();

			var x = 1;

			var result = processor.Multiply(x);

			result.ShouldBe(x);
		}

		[Test]
		public void Processor_MultiplyNull_ShouldReturnZero()
		{
			var processor = new Processor();

			var result = processor.Multiply();

			result.ShouldBe(0);

		}
	}
}