using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public class Rectangle : Shape2D
    {
        public Rectangle(int width, int height) : base("Prostokąt", width, height)
        {
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
