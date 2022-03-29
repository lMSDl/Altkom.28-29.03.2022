using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public class Elipse : Shape2D
    {
        public Elipse(int width, int height) : base("Elipsa", width, height)
        {
        }
        public override double GetArea()
        {
            return Math.PI * Width/2.0 * Height/2.0;
        }
    }
}
