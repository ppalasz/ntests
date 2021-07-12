using System.Numerics;

namespace TddProject
{
	public interface IComputer
	{
		BigInteger ProcessNumbers(string action, params int[] x);
	}
}