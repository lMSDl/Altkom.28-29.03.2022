using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.L
{
    public abstract class Shape
    {
        public abstract int GetArea();
    }

    public class Square : Rectangle //złamanie zasady LSP
    {
        public override int A
        {
            set
            {
                base.A = base.B = value;
            }
        }
        public override int B
        {
            set
            {
                base.B = base.A = value;
            }
        }
    }

    public class Rectangle : Shape
    {
        public virtual int A { get; set; }
        public virtual int B { get; set; }

        public override int GetArea()
        {
            return A * B;
        }
    }
}
