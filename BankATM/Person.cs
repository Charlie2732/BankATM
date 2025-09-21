using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATM
{
    internal class Person
    {
        public string Name { get; }
        public string PersonalNumber { get; }
        public Person(string name, string personalNumber)
        {
            Name = name;
            PersonalNumber = personalNumber;
        }
    }
}
