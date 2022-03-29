using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp.Models
{
    //klasa abstrakcyjna - nie można utworzyć instancji tej klasy
    public abstract class Shape
    {
        //read-only property - brak settera, możliwość ustawienia wartości tylko w konstruktorze
        private string Name { get; }

        protected Shape(string name)
        {
            Name = name;
        }


        public override string ToString()
        {
            return Name;
        }

        public void SomeMethod()
        {

        }

        //metoda wirtualna - metoda, której nadpisanie jest możliwe w klasach dziedziczących z pomocą słowka override
        public virtual void SomeVirtualMethod()
        {

        }
        //metoda abstrakcyjna - nie posiada ciała, musi ono zostać zapewnione w klasach dziedziczących
        public abstract void SomeAbstractMethod();
    }
}
