using System;
using System.Numerics;

namespace TddProject
{
	public class Computer : IComputer
	{
		private readonly IProcessor _processor;

		public Computer(IProcessor processor)
		{
			_processor = processor ?? throw new ArgumentNullException(nameof(processor));
		}

		public BigInteger ProcessNumbers(string action, params int[] x)
		{
			var result = new BigInteger();

			switch (action.ToLower())
			{
				case "add":
					result = _processor.Add(x);
					break;

				case "multiply":
					result = _processor.Multiply(x);
					break;

				default:
					throw new ArgumentException($"no such an action '{action}'");
			}

			return result;
		}
	}
}