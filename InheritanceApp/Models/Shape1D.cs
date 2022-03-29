using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    public abstract class Shape1D : Shape
    {
        protected Shape1D(string name, int width) : base(name)
        {
            Width = width;
        }

        public int Width { get; }

        public override string ToString()
        {
            return $"{base.ToString()} o szerkości {Width}";
        }

        //override - umożliwia nadpisanie metody rodzica (można zastosować tylko do metod wirtualnych i abstrakcyjnych)
        public override void SomeVirtualMethod()
        {
            base.SomeVirtualMethod();
        }

        public override void SomeAbstractMethod()
        {
        }
    }
}
