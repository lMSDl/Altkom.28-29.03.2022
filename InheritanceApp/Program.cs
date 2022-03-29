using InheritanceApp.Models;
using System;
using System.Collections.Generic;

namespace InheritanceApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Point shape = new Point();
            Shape1D shape1D = new Line(10);
            Shape2D shape2D = new Rectangle(5, 6);
            Elipse elipse = new Elipse(10, 15);

            List<Point> points = new List<Point>();
            points.Add(new Point());

            List<Shape> shapes = new List<Shape>();
            shapes.Add(new Point());
            shapes.Add(new Line(10));
            shapes.Add(new Elipse(2, 4));
            shapes.Add(shape2D);

            foreach (var item in shapes)
            {
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine(  shape2D.GetArea() );
        }
    }
}
