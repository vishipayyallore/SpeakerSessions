using System.Linq;
using static System.Console;

namespace ArrayLibrary
{
    public class ArrayDemo : IProgram
    {
        public void Run()
        {
            WriteLine("Sample Input {5 4 3 2 1}");
            var numberOfItems = int.Parse(ReadLine().Trim());
            var arrayValues = ReadLine().Trim().Split(' ').Select(int.Parse).ToArray();
            WriteLine(string.Join(" ", arrayValues.Reverse()));
        }
    }
}
