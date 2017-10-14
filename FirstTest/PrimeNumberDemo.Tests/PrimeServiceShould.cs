using System;
using Xunit;

namespace PrimeNumberDemo.Tests
{
    public class PrimeServiceShould
    {
        private readonly PrimeService _primeService;

        public PrimeServiceShould()
        {
            _primeService = new PrimeService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrimeNumber(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void ReturnTrueGivenValueOf7()
        {
            var result = _primeService.IsPrimeNumber(7);

            Assert.True(result, "7 Is Prime");
        }

    }
}
