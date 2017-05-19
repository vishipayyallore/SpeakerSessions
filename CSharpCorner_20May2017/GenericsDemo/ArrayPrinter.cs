using System;
using System.Threading;

namespace GenericsDemo
{
    public class ArrayPrinter
    {
        public ArrayPrinter PrintArray<T>(T[] arrayElements)
        {
            foreach (var current in arrayElements)
            {
                Console.WriteLine($"{current}");
            }
            Thread.Sleep (5000);
            return this;
        }
    }
}
