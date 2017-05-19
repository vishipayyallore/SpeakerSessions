using System.Linq;
using static System.Console;

namespace SortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
			
            var numbers = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            var currentValue = 0;
            var totalSwaps = 0;
			
			for (int i = 0; i < numbers.Length; i++)
            {
                int numberOfSwaps = 0;

                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        currentValue = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = currentValue;
                        numberOfSwaps++;
                    }
                }

                totalSwaps += numberOfSwaps;
                if (numberOfSwaps == 0)
                {
                    break;
                }
            }

            WriteLine($"Array is sorted in {totalSwaps} swaps.");
            WriteLine($"First Element: {numbers.First()}");
	    WriteLine($"Last Element: {numbers.Last()}");

	    WriteLine("\n\nPress any key ...");
	    ReadKey();
        }
    }
}
