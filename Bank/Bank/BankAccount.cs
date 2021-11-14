#nullable enable
using System;

namespace Bank
{
    /// <summary> Класс описывающий банковский аккаунт. </summary>
    class BankAccount : IEquatable<BankAccount>
    {
        private static ulong _PrevAccNumb = 10000000000000000000;
        private static readonly object _Locker = new();

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
        public BankAccount() => AccountNumb = GenerateAccNumb();

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
        public static ulong GenerateAccNumb()
        {
            lock (_Locker)
            {
                return _PrevAccNumb++;
            }
        }

        /// <summary>Положить сумму на счет.</summary>
        /// <param name="sum">Сумма, которая будет добавлена на счет.</param>
        public decimal AddSum(decimal sum) => _Balance += sum;

        /// <summary>Снять сумму со счета.</summary>
        /// <param name="sum">Сумма, которая будет снята со счета.</param>
        public decimal WithdrawSum(decimal sum) 
        {
            if(_Balance < sum)
            {
                throw new InvalidOperationException("Insufficient funds in the account.");
            }

            return _Balance -= sum;
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

        /// <summary> Проверить равенство двух вккаунтов. </summary>
        /// <param name="account1"> BankAccount. </param>
        /// <param name="account2"> BankAccount. </param>
        /// <returns> Result. </returns>
        public static bool operator ==(BankAccount account1, BankAccount account2)
        {
            return account1.ToString() == account2.ToString();
        }

        /// <summary> Проверить неравенство двух вккаунтов. </summary>
        /// <param name="account1"> BankAccount. </param>
        /// <param name="account2"> BankAccount. </param>
        /// <returns> Result. </returns>
        public static bool operator !=(BankAccount account1, BankAccount account2)
        {
            return account1.ToString() != account2.ToString();
        }

        /// <summary> Проверить равенство указанного объекта текущему. </summary>
        /// <param name="other"> Объект для сравнения. </param>
        /// <returns> Result. </returns>
        public bool Equals(BankAccount? other)
        {
            return this.ToString() == other?.ToString();
        }

        /// <summary> Проверить равенство указанного объекта текущему. </summary>
        /// <param name="obj"> Объект для сравнения. </param>
        /// <returns> Result. </returns>
        public override bool Equals(object? obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            else
            {
                return this.ToString() == obj.ToString();
            }
        }

        /// <summary> Получить хэш-код аккаунта. </summary>
        /// <returns> Hash-code. </returns>
        public override int GetHashCode()
        {
            return this._AccountNumb.GetHashCode();
        }

        #endregion
    }
}
