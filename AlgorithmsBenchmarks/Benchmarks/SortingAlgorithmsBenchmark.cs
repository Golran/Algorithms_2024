using Algorithms;
using BenchmarkDotNet.Attributes;

namespace AlgorithmsBenchmarks.Benchmarks;

[MemoryDiagnoser]
public class SortingAlgorithmsBenchmark
{
	private int[] randomArray;

	[IterationSetup]
	public void SetUp()
	{
		//TODO: реализуй SetUp
	}

	//TODO: реализуй бенчмарки
}