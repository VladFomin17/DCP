using System;
using cpt1;


public class Program
{
    public static void Main()
    {
        try
        {
            // Создание банковского счета с начальным балансом 1000
            BankAccount account = new BankAccount(1000);
            Console.WriteLine($"Начальный баланс: {account.Balance}");

            // Пополнение счета
            account.Deposit(500);

            // Снятие средств
            account.Withdraw(300);

            // Попытка снятия больше, чем на счете
            account.Withdraw(1500);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}


