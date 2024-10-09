using System.Text;

namespace Lab4.Extensions;

internal static class Extensions {
	public static (int, int) FindMinMax(this int[] arr) {
		var minValue = arr[0];
		var maxValue = arr[0];

		foreach (var num in arr) {
			if (num < minValue)
				minValue = num;

			if (num > maxValue)
				maxValue = num;
		}

		return (minValue, maxValue);
	}

	public static int BinarySearch(this int[] arr, int target) {
		var left = 0;
		var right = arr.Length - 1;

		while (left <= right) {
			var middle = (left + right) / 2;

			if (arr[middle] == target)
				return middle;
			if (arr[middle] < target)
				left = middle + 1;
			else
				right = middle - 1;
		}

		return -1;
	}

	public static void PrintArrayInTable(this int[] array, StringBuilder? parentBuilder = null) {
		var builder = parentBuilder ?? new StringBuilder();
		for (var i = 0; i < array.Length; i++) {
			builder.Append($"{array[i],4} ");

			if ((i + 1) % 10 == 0)
				builder.AppendLine();
		}

		if (parentBuilder == null)
			Console.WriteLine(builder);
	}
}