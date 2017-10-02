using System;

namespace Samples.Core
{
    public class PrimeNumberService
    {
        public bool IsPrime(int number) 
        {
            var iCtr = 2;
            while (iCtr < number)
            {
                if (number % iCtr == 0)
                {
                    break;
                }
                iCtr++;
            }
            return (iCtr == number) ? true : false;
        } 
    }
}
