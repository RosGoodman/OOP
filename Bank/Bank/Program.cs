using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(AccountType.Current);

            Console.WriteLine(account.ToString());

            account.AddSum(123.4M);
            Console.WriteLine(account.ToString());

            account.WithdrawSum(100M);
            Console.WriteLine(account.ToString());

            BankAccount account2 = new BankAccount(AccountType.Correspondent);

            Console.WriteLine(account2.ToString());

            account2.AddSum(123.4M);
            Console.WriteLine(account2.ToString());

            account2.WithdrawSum(100M);
            Console.WriteLine(account2.ToString());

            account2.WithdrawSum(100M);
            Console.WriteLine(account2.ToString());

            Console.ReadLine();
        }
    }
}
