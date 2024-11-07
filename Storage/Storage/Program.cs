using Storage;
using System;

public class Program
{
    public static void Main(string[] args)
    {
        IStorage<int> FunnyNumbers = new ListStorage<int>();
        FunnyNumbers.Add(1488);
        FunnyNumbers.Add(78);
        FunnyNumbers.Add(2);

        Console.WriteLine("Элементы в FunnyNumbers:");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine(FunnyNumbers.Get(i));
        }

        IStorage<string> NameOfGenius = new ListStorage<string>();
        NameOfGenius.Add("Sergey");
        NameOfGenius.Add("Osin");

        Console.WriteLine("Элементы в NameOfGenius:");
        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine(NameOfGenius.Get(i));
        }
    }
}