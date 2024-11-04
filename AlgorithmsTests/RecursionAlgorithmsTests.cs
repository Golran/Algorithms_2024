using Algorithms;
using NUnit.Framework;

namespace AlgorithmsTests;

public class RecursionAlgorithmsTests
{
	private static IEnumerable<TestCaseData> TestCaseDataForPow
	{
		get
		{
			yield return new TestCaseData(0, 1, 0);
			yield return new TestCaseData(1, 73, 1);
			yield return new TestCaseData(2, 2, 4);
			yield return new TestCaseData(10, 5, 10e4);
			yield return new TestCaseData(Math.E, 3, Math.E * Math.E * Math.E);
			yield return new TestCaseData(-2, 2, 4);
			yield return new TestCaseData(-2, 3, -8);
		}
	}

	[TestCaseSource(nameof(TestCaseDataForPow))]
	public void MathPowTests(double num, int deg, double expected)
	{
		TestImpl(num, deg, expected, RecursionAlgorithms.MathPow);
	}

	[TestCaseSource(nameof(TestCaseDataForPow))]
	public void TrivialPowTests(double num, int deg, double expected)
	{
		TestImpl(num, deg, expected, RecursionAlgorithms.TrivialPow);
	}

	[TestCaseSource(nameof(TestCaseDataForPow))]
	public void FastRecPowTests(double num, int deg, double expected)
	{
		TestImpl(num, deg, expected, RecursionAlgorithms.FastRecPow);
	}

	[TestCaseSource(nameof(TestCaseDataForPow))]
	public void FastCyclePowTests(double num, int deg, double expected)
	{
		TestImpl(num, deg, expected, RecursionAlgorithms.FastCyclePow);
	}

	private void TestImpl(double num, int deg, double expected, Func<double, int, double> alg)
	{
		var result = alg(num, deg);
		Assert.AreEqual(expected, result, 0.5e-7);
	}
}