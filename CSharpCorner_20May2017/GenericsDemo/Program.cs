using static System.Console;

namespace GenericsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] {1, 2, 3, 4, 5 };
            var vowels = new char[] {'A', 'B', 'C'};
            var names = new string[] { "Shiva", "Mathews", "Azim" };

            var arrayPrinter = new ArrayPrinter();

            arrayPrinter.PrintArray(numbers)
                        .PrintArray(vowels)
                        .PrintArray(names);

            WriteLine("\n\nPress any key ....");
            Read();
        }
    }
}
