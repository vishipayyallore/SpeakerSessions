using System.Collections.Generic;
using System.Linq;
using TodoApi.Controllers;
using Xunit;

namespace TodoApi.Tests
{
    public class ValuesControllerTests
    {

        private readonly ValuesController _valuesController;

        public ValuesControllerTests()
        {
            _valuesController = new ValuesController();
        }

        [Fact]
        public void ShouldReturn_MultipleValues()
        {
            IEnumerable<string> results = _valuesController.Get();

            Assert.True(results.Any());
        }

        [Fact]
        public void ShouldReturn_SingleValues()
        {
            var results = _valuesController.Get(1);

            Assert.True(results == "value");
        }


    }
}
