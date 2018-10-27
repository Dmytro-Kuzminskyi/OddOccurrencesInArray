using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
			var m = s.solution(array);
		}
	}
}
