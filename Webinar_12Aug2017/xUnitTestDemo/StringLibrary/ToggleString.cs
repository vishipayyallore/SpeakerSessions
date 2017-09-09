using System;
using System.Text;
using static System.Console;

namespace StringLibrary
{
    public class ToggleString1
    {

        #region Methods
        public string Process(string data)
        {
            var _output = new StringBuilder(1024);
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
                //Write($"{(char)output}");
                _output.Append((char)output);
            }
            return _output.ToString();
        }
        #endregion
    }
}
