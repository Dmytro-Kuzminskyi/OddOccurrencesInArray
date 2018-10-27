using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddOccurrencesInArray
{
	class Solution
	{
		public int solution(int[] A)
		{
			if (A.Length == 1) return A[0];
			bool[] CheckedA = new bool[A.Length];
			for (int i = 0; i < A.Length; i++)
			{
				if (CheckedA[i]) continue;
				else
				{
					for (int j = i + 1; j < A.Length; j++)
					{
						if (A[j] == A[i])
						{
							CheckedA[i] = CheckedA[j] = true;
							break;
						}
						else if (A[j] != A[i] && j == A.Length - 1)
							return A[i];
					}
				}
			}
			return 0;
		}
	}
}
