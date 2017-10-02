using System;
using Xunit;
using Samples.Core;

namespace PrimeService.Tests
{
    public class PrimeNumberServiceTests
    {
        private readonly PrimeNumberService _primeService;

        public PrimeNumberServiceTests()
        {
            _primeService = new PrimeNumberService();
        }

        [Fact]
        public void ReturnFalseGivenValueOf1()
        {
            var result = _primeService.IsPrime(1);

            Assert.False(result, "1 should not be prime");
        }

        [Fact]
        public void ReturnFalseGivenValueOf7()
        {
            var result = _primeService.IsPrime(7);

            Assert.False(result);
        }
    }
}
