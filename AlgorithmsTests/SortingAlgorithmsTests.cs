using Algorithms;
using NUnit.Framework;

namespace AlgorithmsTests;

public class SortingAlgorithmsTests
{
	private static IEnumerable<TestCaseData> TestCaseDataForSorting
	{
		get
		{
			yield return new TestCaseData(Array.Empty<int>(), Array.Empty<int>());
			//TODO: допиши TestCases
		}
	}

	[TestCaseSource(nameof(TestCaseDataForSorting))]
	public void BaseSortTests(int[] arr, int[] sortedArr)
	{
		var sourceArr = new int[arr.Length];
		Array.Copy(arr, sourceArr, arr.Length);

		SortingAlgorithms.BaseSort(sourceArr);

		Assert.AreEqual(sortedArr, sourceArr);
	}

	//TODO: допиши тесты
}