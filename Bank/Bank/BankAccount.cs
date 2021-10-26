using System;

namespace Bank
{
    class BankAccount
    {
        private static ulong _PrevAccNumb = 10000000000000000000;

        private readonly ulong _AccountNumb;
        private decimal _Balance;
        private readonly AccountType _AccountType;

        #region properties

        /// <summary> Номер банковского счета.</summary>
        public ulong AccountNumb
        {
            get => _AccountNumb; 
            init => _AccountNumb = value; 
        }

        /// <summary> Баланс банковского счета. </summary>
        public decimal Balance { get; }

        /// <summary>Тип банковского счета.</summary>
        public AccountType AccountType
        {
            get => _AccountType;
            init => _AccountType = value;
        }

        #endregion

        #region Ctors

        /// <summary> Создать экземпляр класса BankAccount. </summary>
        public BankAccount() { AccountNumb = GenerateAccNumb(); }

        /// <summary>Создать экземпляр класса BankAccount.</summary>
        /// <param name="balance">Текущий баланс для счета.</param>
        public BankAccount(decimal balance)
        {
            AccountNumb = GenerateAccNumb();
            _Balance = balance;
        }

        /// <summary>Создать экземпляр класса BankAccount.</summary>
        /// <param name="accType">Тип банковского счета.</param>
        public BankAccount(AccountType accType)
        {
            AccountNumb = GenerateAccNumb();
            AccountType = accType;
        }

        /// <summary>Создать экземпляр класса BankAccount.</summary>
        /// <param name="accType">Тип банковского счета.</param>
        /// <param name="balance">Номер банковского счета.</param>
        public BankAccount(AccountType accType, decimal balance)
        {
            AccountNumb = GenerateAccNumb();
            _AccountType = accType;
            _Balance = balance;
        }

        #endregion

        #region AccountMethods

        /// <summary> Получить перевод с указанного счета. </summary>
        /// <param name="senderAccount">Счет отправитель перевода.</param>
        /// <param name="sum">Сумма перевода.</param>
        public void ReceiveMoneyTransfer(BankAccount senderAccount, decimal sum)
        {
            senderAccount.WithdrawSum(sum);
            this.AddSum(sum);
        }

        /// <summary>Генерировать новый номер счета.</summary>
        /// <returns>Новый номер счета.</returns>
        public static ulong GenerateAccNumb() => _PrevAccNumb++;

        /// <summary>Положить сумму на счет.</summary>
        /// <param name="sum">Сумма, которая будет добавлена на счет.</param>
        public decimal AddSum(decimal sum)
        {
            _Balance += sum;
            return _Balance;
        }

        /// <summary>Снять сумму со счета.</summary>
        /// <param name="sum">Сумма, которая будет снята со счета.</param>
        public decimal WithdrawSum(decimal sum) 
        {
            if(_Balance < sum)
            {
                Console.WriteLine("Insufficient funds in the account.");
                return _Balance;
            }

            _Balance -= sum;
            return _Balance;
        }

        /// <summary>Получить строку с данными об аккаунте.</summary>
        /// <returns>Номер счета, баланс, тип аккаунта.</returns>
        /// <remarks>Метод переопределент только для удобства в данной задаче.</remarks>
        public override string ToString()
        {
            return $"AccNumber: {_AccountNumb}\n" +
                $"balance: {_Balance}\n" +
                $"accType: {_AccountType}\n";
        }

        #endregion
    }
}
