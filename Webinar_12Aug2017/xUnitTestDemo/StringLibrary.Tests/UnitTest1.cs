using System;
using Xunit;

namespace StringLibrary.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var _toggleString = new ToggleString1();
            var output = _toggleString.Process("Shiva");
 
            Console.WriteLine(output);
            Assert.Equal(output, "sHIVA");
        }
    }
}
