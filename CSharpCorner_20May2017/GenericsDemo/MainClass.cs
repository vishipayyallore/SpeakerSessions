using System;
using static System.Console;

namespace GenericsDemo
{
    class MainClass
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {1, 2, 3, 4, 5 };
            var vowels = new char[] {'A', 'B', 'C'};
            var names = new string[] { "Shiva", "Mathews", "Azim" };

            var arrayPrinter = new ArrayPrinter();

            arrayPrinter.PrintArray(numbers);
            arrayPrinter.PrintArray(vowels);
            arrayPrinter.PrintArray(names);

            WriteLine("\n\nPress any key ....");
            //ReadKey();
        }
    }
}
