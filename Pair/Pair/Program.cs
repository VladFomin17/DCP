using Pair;
using System;

class Program
{
    static void Main(string[] args)
    {
        Pair<int, string> FirstPair = new Pair<int, string>(11, "минут");

        Pair<string, double> SecondPair = new Pair<string, double>("одна пятая", 0.2);

        Console.WriteLine($"Значения в первом случае: {FirstPair.GetFirstValue()} и {FirstPair.GetSecondValue()}");
        Console.WriteLine($"Значения во втором случае: {SecondPair.GetFirstValue()} и {SecondPair.GetSecondValue()}");

        FirstPair.ChangeFirstValue(21);
        FirstPair.ChangeSecondValue("minutes");
        Console.WriteLine($"Измененные значения: {FirstPair.GetFirstValue()} и {FirstPair.GetSecondValue()}");

    }
}