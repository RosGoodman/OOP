using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 аккаунт
            BankAccount account = new BankAccount();
            // 2 аккаунт
            BankAccount account2 = new BankAccount(AccountType.Correspondent);
            // 3 аккаунт
            BankAccount account3 = new BankAccount(AccountType.Correspondent, 256);
            // 4 аккаунт
            BankAccount account4 = new BankAccount(AccountType.Correspondent, 256);

            Console.WriteLine($"Проверка равенства: {account == account2}");
            Console.WriteLine($"Проверка неравенства: {account != account2}");

            Console.WriteLine($"Проверка Equals: {account3.Equals(account2)}");
            Console.WriteLine($"Проверка Equals: {account3.Equals(account3)}");

            Console.WriteLine($"get hashCode: {account.GetHashCode()}");

            Console.ReadLine();
        }
    }
}
