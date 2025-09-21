namespace BankATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapa en kund med ett konto och en PIN-kod:
            var person = new Person("Michael Franzese", "19510527-0000");
            var account = new BankAccount();
            var customer = new Customer(person, account, "8310");

            // Starta ATM:
            if (!AuthenticateLogin(customer))
            {// misslyckad inloggning
                Console.WriteLine("You have entered your PIN too many times. Your card is now blocked.");
                return;
            }
            else
            {// lyckad inloggning
                Console.WriteLine($"Welcome {customer.Person.Name}!");
                Console.WriteLine();
            }
            
            while (true)
            {
                // Visa meny och hantera val:
                ShowMenu();
                int val = GetInt();
                if (val < 1 || val > 4)
                {
                    Console.WriteLine("You did not enter a valid choice, please try again");
                    continue;
                }
                switch (val)
                {
                    case 1:
                        Console.WriteLine($"Your balance is: {customer.Account.Balance} SEK");
                        break;

                    case 2:
                        Console.Write("Enter amount to deposit: ");
                        var depositAmount = GetInt();
                        customer.Account.Deposit(depositAmount);
                        Console.WriteLine($"You have deposited {depositAmount} SEK");
                        break;
                    case 3:
                        Console.Write("Enter amount to withdraw: ");
                        var withdrawAmount = GetInt();
                        if (customer.Account.Withdraw(withdrawAmount))
                            Console.WriteLine($"You have withdrawn {withdrawAmount} SEK");
                        else
                            Console.WriteLine("Insufficient funds or invalid amount.");
                        break;
                    case 4:
                        Console.WriteLine("Thank you for using our ATM. Goodbye!");
                        return;





                }












            }

        }



        private static int GetInt()
        {
            int helTal;
            while (int.TryParse(Console.ReadLine(), out helTal) == false)
            {
                Console.WriteLine("You did not enter a whole number. Please try again");

            }

            return helTal;
        }






        private static void ShowMenu()
        {
            Console.WriteLine("BANK-ATM");
            Console.WriteLine();
            Console.Write("Choose an option: ");
            Console.WriteLine();
            Console.WriteLine("1. View Balance");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            
        }


        private static bool AuthenticateLogin(Customer customer)
        {
            for (int i = 0; i < 3; i++) // max 3 försök
            {
                Console.Write("Enter your four-digit PIN: ");
                var pin = Console.ReadLine() ?? "";

                if (customer.Authenticate(pin))
                    return true; // inloggad, fortsätt till menyn

                
            }
            return false; // 3 fel -> misslyckad inloggning
        }

    }
}
