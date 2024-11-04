using BenchmarkDotNet.Running;

namespace AlgorithmsBenchmarks;

internal class Program
{
	public static void Main(string[] args)
	{
		BenchmarkSwitcher.FromAssembly(typeof(Program).Assembly).Run(args);
	}
}