using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public class Square : Shape2D
    {
        public Square(int width) : base("Kwadrat", width, width)
        {
        }
        public override double GetArea()
        {
            return Width * Height;
        }
    }
}
