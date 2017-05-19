using System;

namespace GenericsDemo
{
    public class ArrayPrinter
    {
        public void PrintArray<T>(T[] arrayElements)
        {
            foreach (var current in arrayElements)
            {
                Console.WriteLine($"{current}");
            }
        }
    }
}
