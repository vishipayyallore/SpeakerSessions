using static System.Console;
using CoreLibrary;

namespace StringLibrary
{
    public class PalindromicString : IProcessor
    {
        #region Methods
        public void Process()
        {
            WriteLine("Sample Input {aba}");
            var jCtr = 0;
            var output = "YES";
            var data = ReadLine().Trim();

            for (var iCtr = data.Length - 1; iCtr >= 0; iCtr--, jCtr++)
            {

                if (char.ToLowerInvariant(data[iCtr]).Equals(char.ToLowerInvariant(data[jCtr])))
                {
                    continue;
                }
                output = "NO";
                break;
            }
            WriteLine(output);
        }
        #endregion
    }
}
