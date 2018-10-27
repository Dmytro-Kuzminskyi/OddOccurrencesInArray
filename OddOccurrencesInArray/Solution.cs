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
			int currentNumber = 0;
			int currentCount = 0;
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] != 0)
				{
					currentNumber = A[i];
					foreach (var e in A)
					{
						if (e == currentNumber) currentCount++;
					}
					if (currentCount % 2 == 0)
					{
						currentCount = 0;
						for (int j = 0; j < A.Length; j++)
						{
							if (A[j] == currentNumber) A[j] = 0;
						}
					}
					else break;
				}
			}
			return currentNumber;
		}
	}
}
