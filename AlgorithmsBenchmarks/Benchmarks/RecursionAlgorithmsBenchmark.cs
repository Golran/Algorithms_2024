using Algorithms;
using BenchmarkDotNet.Attributes;

namespace AlgorithmsBenchmarks.Benchmarks;

public class RecursionAlgorithmsBenchmark
{
	private const double num = 0.73;

	private const int deg = 10000;

	[Benchmark]
	public void MathPow()
	{
		RecursionAlgorithms.MathPow(num, deg);
	}

	[Benchmark]
	public void TrivialPow()
	{
		RecursionAlgorithms.TrivialPow(num, deg);
	}

	[Benchmark]
	public void FastRecPow()
	{
		RecursionAlgorithms.FastRecPow(num, deg);
	}

	[Benchmark]
	public void FastCyclePow()
	{
		RecursionAlgorithms.FastCyclePow(num, deg);
	}
}