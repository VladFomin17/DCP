using System;

class Program
{
    public static T FindMin<T>(T[] elements) where T : IComparable<T>
    {
        T minValue = elements[0];

        for (int i = 1; i < elements.Length; i++)
        {
            if (elements[i].CompareTo(minValue) < 0) 
            {
                minValue = elements[i]; 
            }
        }

        return minValue; 
    }

    static void Main(string[] args)
    {
        int[] intArray = { 5, 3, 8, 1, 2 };
        double[] doubleArray = { 5.5, 3.2, 8.1, 1.0, 2.3 };
        string[] stringArray = { "apple", "orange", "banana", "grape" };

        Console.WriteLine($"Минимальное значение в intArray: {FindMin(intArray)}");
        Console.WriteLine($"Минимальное значение в doubleArray: {FindMin(doubleArray)}");
        Console.WriteLine($"Минимальное значение в stringArray: {FindMin(stringArray)}");
    }
}
