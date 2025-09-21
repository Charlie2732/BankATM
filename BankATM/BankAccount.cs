using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankATM
{
    internal class BankAccount
    {    // Här bor pengarna och reglerna - Håller saldot privat.
        //Släpper bara in/ut pengar via metoder som kollar regler.

        private decimal balance;
        public decimal Balance => balance;
        public void Deposit(decimal amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public bool Withdraw(decimal amount)
        {
            if (amount <= 0 || amount > balance)
                return false;

            balance -= amount;
            return true;
        }



    }
}
