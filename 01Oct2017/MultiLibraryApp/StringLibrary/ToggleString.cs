using static System.Console;
using CoreLibrary;

namespace StringLibrary
{
    public class ToggleString : IProcessor
    {
        #region Methods
        public void Process()
        {
            WriteLine("Sample Input {abcdE}");
            var data = ReadLine();
            var output = 0;
            foreach (var currentChar in data)
            {
                if ((currentChar >= 65 && currentChar <= 90))
                {
                    output = currentChar + 32;
                }
                else if ((currentChar >= 97 && currentChar <= 122))
                {
                    output = currentChar - 32;
                }
                else
                {
                    output = currentChar;
                }
                Write($"{(char)output}");
            }
        }
        #endregion
    }
}