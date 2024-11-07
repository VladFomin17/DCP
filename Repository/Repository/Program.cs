using Repository;
using System;

class Program
{
    static void Main(string[] args)
    {
        var stringRepository = new Repository<string>();

        stringRepository.AddItem("Roman");
        stringRepository.AddItem("Peskov");

        Console.WriteLine($"Первый элемент: {stringRepository.GetItem(0)}"); 
        Console.WriteLine($"Второй элемент: {stringRepository.GetItem(1)}"); 

        Console.WriteLine($"Общее количество элементов: {stringRepository.Count}"); 
    }
}
