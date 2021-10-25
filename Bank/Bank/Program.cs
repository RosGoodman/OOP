using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 пустой
            BankAccount account = new BankAccount();
            WorkWithAccount(account);

            // 2 тип аккаунта
            account = new BankAccount(AccountType.Correspondent);
            WorkWithAccount(account);

            // 3 баланс
            account = new BankAccount(156M);
            WorkWithAccount(account);

            // 4 баланс и тип аккаунта
            account = new BankAccount(AccountType.Settlement, 298.3M);
            WorkWithAccount(account);

            Console.ReadLine();
        }

        /// <summary>Метод изменяет и выводит данные счета.</summary>
        /// <param name="account">Обрабатываемый счет.</param>
        private static void WorkWithAccount(BankAccount account)
        {
            Console.WriteLine(account.ToString());

            account.AddSum(123.4M);
            Console.WriteLine(account.ToString());

            account.WithdrawSum(100M);
            Console.WriteLine(account.ToString());

            account.WithdrawSum(100M);
            Console.WriteLine(account.ToString());

            Console.WriteLine("------------------------------------------");
        }
    }
}
