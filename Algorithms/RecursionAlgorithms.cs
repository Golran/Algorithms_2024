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
		if (deg == 0)
		{
			return 1;
		}

		//у четного числа последний бит равен нулю
		if ((deg & 1) == 0) 
		{
			//смещение на один бит вправо равносильно делению на два
			var p = FastRecPow(num, deg >> 1);
			return p * p;
		}

		return num * FastRecPow(num, deg - 1);
	}

	public static double FastCyclePow(double num, int deg)
	{
		var result = 1.0;
		while (deg > 0)
		{
			if ((deg & 1) == 0)
			{
				num *= num;
				deg >>= 1;
			}
			else
			{
				result *= num;
				--deg;
			}
		}

		return result;
	}
}