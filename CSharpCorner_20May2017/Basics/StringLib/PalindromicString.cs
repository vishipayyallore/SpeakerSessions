using static System.Console;

namespace StringLib
{
    public class PalindromicString 
    {
        #region Methods
        public void Process()
        {
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