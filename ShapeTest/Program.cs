using System;

namespace ShapeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(20.00,20.00,20.00,20.00);
            Circle circle = new Circle(20.00,20.00,20.00);

            Console.WriteLine($"{circle.Area()}");
            Console.WriteLine($"{rectangle.Area()}");
        }
    }
}
