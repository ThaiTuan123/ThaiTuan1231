using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StartUp
{
    class PersonsInfo
    {
        private string firstName;
        private string lastName;
        private int age;

        public PersonsInfo(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }

        }
            public int Age
    {
            get { return this.age; }
            set { this.age = value; }
    }


        public override string ToString()
        {
            return $"{this.firstName}{ this.lastName} is { this.age} years old" ;
        }

    }
}
