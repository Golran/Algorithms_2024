using System;

namespace Algorithms;

public static class RecursionAlgorithms
{
	public static double MathPow(double num, int deg)
	{
		return Math.Pow(num, deg);
	}

	public static double TrivialPow(double num, int deg)
	{
		var result = 1.0;
		for (int i = 0; i < deg; i++)
		{
			result *= num;
		}

		return result;
	}

	public static double FastRecPow(double num, int deg)
	{
		//TODO: implement recursive version FastPow
		return 73;
	}

	public static double FastCyclePow(double num, int deg)
	{
		//TODO: implement cycle version FastPow
		return 73;
	}
}