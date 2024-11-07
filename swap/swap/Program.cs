using System;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        void Swap<T>(ref T x, ref T y)
        {
            T Temporal = x;
            x = y;
            y = Temporal;
        }

        int x = 7;
        int y = 25;
        Swap<int>(ref x, ref y); 
        Console.WriteLine($"x = {x}, y = {y}"); 

        string s1 = "hello";
        string s2 = "bye";
        Swap<string>(ref s1, ref s2); 
        Console.WriteLine($"s1 = {s1}, s2 = {s2}"); 

    }
}