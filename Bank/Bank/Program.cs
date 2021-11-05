using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 аккаунт
            BankAccount account = new BankAccount();
            WorkWithAccount(account);

            // 2 аккаунт
            BankAccount account2 = new BankAccount(AccountType.Correspondent);
            WorkWithAccount(account2);

            //перевод
            account.ReceiveMoneyTransfer(account2, 333.3m);
            Console.WriteLine(account);
            Console.WriteLine(account2);

            Console.ReadLine();
        }

        /// <summary>Метод изменяет и выводит данные счета.</summary>
        /// <param name="account">Обрабатываемый счет.</param>
        private static void WorkWithAccount(BankAccount account)
        {
            account.AddSum(1000M);
            Console.WriteLine(account);

            Console.WriteLine("------------------------------------------");
        }
    }
}
