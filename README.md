# BankATM
Inloggning med fyrsiffrig PIN (max 3 försök).
Meny - Visa saldo - Sätt in pengar - Ta ut pengar - Avsluta.
Validering - Belopp måste vara numeriskt och > 0.
OOP & inkapsling - BanAccount
Person information
Kund som knyter person och BankAccount
Program (Main) med metoder, meny, loop och switch.

OOP & inkapsling – kort
BankAccount
Privat saldo private decimal balance
Read only saldo public decimal Balance { get; }
Deposit(decimal amount) lägger till bara om amount > 0
Withdraw(decimal amount) returnerar false om amount <= 0 eller amount > balance annars minskar saldot

Person
public string Name { get; }
public string PersonalNumber { get; }
Sätts via konstruktorn read only

Customer
Privat PIN private readonly string _pin
Kopplar Person och BankAccount
Authenticate(string pin) returnerar true eller false

Program Main
PIN kontroll vid start max 3 försök
Menyloop Visa saldo Sätt in Ta ut Avsluta
Konsol IO och enkel validering av inmatning








