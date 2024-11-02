using System;

namespace cpt4
{
    public class Programm
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle(3);

            double CircleArea = circle.GetArea();
            Console.WriteLine($"Площадь окружности: {CircleArea}");

            Rectangle rectangle = new Rectangle(34, 5.5);

            double RectangleArea = rectangle.GetArea(); 
            Console.WriteLine($"Площадь прямоугольника: {RectangleArea}");
        }
    }
}
