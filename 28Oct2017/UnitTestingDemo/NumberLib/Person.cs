using System.Collections.Generic;

namespace NumberLib
{

    public class Person
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string FullName => $"{FirstName} {LastName}";

        public int Age => 45;

        public double Salary => 12984.439658;

        public List<string> Roles => new List<string>
        {
            "Developer",
            "Dev Ops",
            "Tester"
        };

    }

}
