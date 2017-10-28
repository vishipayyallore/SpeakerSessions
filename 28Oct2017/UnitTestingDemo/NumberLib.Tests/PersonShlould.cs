using Xunit;

namespace NumberLib.Tests
{

    public class PersonShould
    {
        private readonly Person _person;

        public PersonShould()
        {
            _person = new Person();
        }

        [Fact]
        [Trait("Person Class", "Person")]
        public void FullName_ShouldReturn_FirstAndLastName()
        {
            _person.FirstName = "Shiva";
            _person.LastName = "Sai";

            var fullName = $"{_person.FirstName} {_person.LastName}";

            Assert.Equal(fullName, _person.FullName);
            Assert.Contains("iva Sai", _person.FullName);
            Assert.Equal("SHIVA sAI", _person.FullName, ignoreCase: true);
        }

        [Fact]
        [Trait("Person Class", "Person")]
        public void Age_ShouldReturn_Between18And60()
        {
            Assert.InRange(_person.Age, 18, 60);
        }

        [Fact]
        [Trait("Person Class", "Person")]
        public void Salary_ShouldReturn_Value()
        {
            Assert.Equal(12984.44, _person.Salary, 2);
        }

        [Fact]
        [Trait("Person Class", "Person")]
        public void Roles_ShouldContain_Developer()
        {
            Assert.Contains("Developer", _person.Roles);
        }

        [Fact]
        [Trait("Person Class", "Person")]
        public void Roles_ShouldNotContain_Manager()
        {
            Assert.DoesNotContain("Manager", _person.Roles);
        }
    }


}
