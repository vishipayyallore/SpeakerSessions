using System;

namespace NumberLib
{
    
    public class PrimeService
    {
        public bool IsPrimeNumber(int number) 
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
