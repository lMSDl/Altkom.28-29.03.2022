using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public class Line : Shape1D
    {
        public Line(int width) : base("Linia", width)
        {
        }
    }
}
