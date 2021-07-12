using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace TddProject
{
	public class Processor : IProcessor
	{
		public BigInteger Add(params int[] x)
		{
			var result = new BigInteger();
			foreach (var n in x)
			{
				result += n;
			}

			return result;
		}

		public BigInteger Multiply(params int[] x)
		{
			if (x.Length == 0)
				return 0;

			var result = new BigInteger(1);
			foreach (var n in x)
			{
				result *= n;
			}

			return result;
		}
	}
}
