using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong accNumb = 13245678900987654321;
            BankAccount account = new BankAccount(accNumb, AccountType.Current);

            Console.WriteLine(account.ToString());

            account.AddSum(123.4M);
            Console.WriteLine(account.ToString());

            account.WithdrawSum(100M);
            Console.WriteLine(account.ToString());

            Console.ReadLine();
        }
    }
}
