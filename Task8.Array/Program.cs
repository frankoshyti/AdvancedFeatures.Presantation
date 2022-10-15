using System;
using System.Linq;

namespace Task8.Array;

 class Program
{
	static void Main(string[] args)
	{
		int[] array = new int[] { 3, 4, 4, 2, 3, 3, 4, 3, 2 };

		Dictionary<int, int> result = new Dictionary<int, int>();

		foreach(int item in array)
		{
			if (!result.ContainsKey(item))
			{
				result.Add(item, 1);
			}
			else
			{
				result[item]++;
			}
		}

	   
		foreach(KeyValuePair<int, int> pair in result)
		{
			Console.WriteLine(pair.Key + " -> " + pair.Value + " times");
		}

		Console.ReadKey();
	}
}