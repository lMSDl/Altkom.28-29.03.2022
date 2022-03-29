using SOLID.L;
using System;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Square();
            int a = 5;
            int b = 3;
            SetRectangle(rectangle, a, b);

            Console.WriteLine($"Pole prostokąta o bokach {a} i {b} = {rectangle.GetArea()}");


        }

        static void SetRectangle(Rectangle rectangle, int a, int b)
        {
            rectangle.A = a;
            rectangle.B = b;
        }
    }
}
