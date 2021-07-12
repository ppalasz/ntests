using System.Numerics;

namespace TddProject
{
	public interface IProcessor
	{
		BigInteger Add(params int[] x);

		BigInteger Multiply(params int[] x);
	}
}