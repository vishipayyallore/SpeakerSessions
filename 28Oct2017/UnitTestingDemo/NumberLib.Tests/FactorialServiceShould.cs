using System;
using Xunit;

namespace NumberLib.Tests
{
    public class FactorialServiceShould
    {

        private static FactorialService _factorialService;

        public FactorialServiceShould()
        {
            _factorialService = new FactorialService();
        }

        [Fact]
        public void ItShouldReturn2When2IsPassed()
        {
            var results = _factorialService.Run(2);

            Assert.Equal(results, 2);
        }

    }
}
