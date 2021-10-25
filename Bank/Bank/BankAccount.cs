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

        /// <summary>Создать экземпляр класса BankAccount.</summary>
        /// <param name="accNumb">Номер банковского счета.</param>
        /// <param name="accType">Тип банковского счета.</param>
        public BankAccount(AccountType accType)
        {
            //каждый новый номер счета увеличивается на 1.
            AccountNumb = _PrevAccNumb++;
            AccountType = accType;
        }

        #region AccountMethods

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
