using System.Linq;
using CoreLibrary;
using static System.Console;

namespace ArrayLibrary
{
    public class ArrayDemo : IRunner
    {
        public void Run()
        {
            WriteLine("Sample Input {5 4 3 2 1}");
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            WriteLine(string.Join(" ", arrayValues.Reverse()));
        }
    }
}
