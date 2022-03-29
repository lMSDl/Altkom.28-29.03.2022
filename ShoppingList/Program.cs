using ShoppingList.Models;
using System;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //wykorzystanie inicjalizatora przy tworzeniu obiektu - może to zastąpić liczne konstruktory
            var item1 = new Item() {Name = "mleko"};
            var item2 = new Item() { Name = "mleko", Quantity = 1 };
            var item3 = new Item() { Quantity = 3 };
            var item4 = new Item();

            Console.WriteLine(item1.ToString());
        }
    }
}
