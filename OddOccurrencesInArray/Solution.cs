namespace OddOccurrencesInArray
{
	class Solution
	{
		public int solution(int[] A)
		{
			if (A.Length == 1) return A[0];
			for (int i = 0; i < A.Length; i++)
			{
				if (A[i] == 0) continue;
				else
				{
					if (A[i] != 0 && i == A.Length - 1) return A[i];
					for (int j = i + 1; j < A.Length; j++)
					{
						if (A[j] == A[i])
						{
							A[i] = A[j] = 0;
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
