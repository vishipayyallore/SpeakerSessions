using static System.Console;
using System.Threading;

namespace GenericsDemo
{
    public class ArrayPrinter
    {
        public ArrayPrinter PrintArray<T>(T[] arrayElements)
        {
            foreach (var current in arrayElements)
            {
                WriteLine($"{current}");
            }
            Thread.Sleep (5000);
            return this;
        }
    }
}