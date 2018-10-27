using System;

namespace OddOccurrencesInArray
{
	class Program
	{
		static void Main(string[] args)
		{
			Solution s = new Solution();
			Console.Write("Enter N: ");
			int n = int.Parse(Console.ReadLine());
			int[] array = new int[n];
			for (int i = 0; i < array.Length; i++)
			{
				Console.Write("Set {0} element of array: ", i + 1);
				array[i] = int.Parse(Console.ReadLine());
			}
			Console.WriteLine("Unpared element is ", s.solution(array));
			Console.ReadKey();
		}
	}
}
