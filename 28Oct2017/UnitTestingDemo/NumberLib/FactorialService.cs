using System;
using static System.Console;

namespace NumberLib
{
    public class FactorialService
    {

        public int Run(int number)
        {
            var factorial = 1;
            while (number > 0)
            {
                factorial *= number;
                number--;
            }
            return factorial;
        }
        
    }
}
