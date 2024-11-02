using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cpt1
{
    public class BankAccount
    {
        public decimal _balance;

        public BankAccount(decimal newBalance)
        {
            if (newBalance < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(newBalance), "Начальный баланс не может быть отрицательным.");
            }
            _balance = newBalance;
        }

        public decimal Balance => _balance;

        public void Deposit(decimal amount)
        {
            _balance += amount;
            Console.WriteLine($"Пополнено на {amount}. Текущий баланс: {_balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > _balance)
            {
                throw new InvalidOperationException("Недостаточно средств на счете.");
            }
            _balance -= amount;
            Console.WriteLine($"Снято {amount}. Текущий баланс: {_balance}");
        }
    }

}
