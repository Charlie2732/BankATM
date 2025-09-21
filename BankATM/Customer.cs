using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace BankATM
{
    internal class Customer
    {
        private readonly string _pin;
        public Person Person { get; }
        public BankAccount Account { get; }

        public Customer(Person person, BankAccount account, string pin)
        {
            Person = person;
            Account = account;
            _pin = pin; // lagra PIN privat
        }
        public bool Authenticate(string pin) => pin == _pin;


    }
}
