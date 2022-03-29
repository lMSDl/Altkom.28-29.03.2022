using ShoppingList.Models;
using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static void Main(string[] args)
        {
            //wykorzystanie inicjalizatora przy tworzeniu obiektu - może to zastąpić liczne konstruktory
            var item1 = new Item() {Name = "kawa"};
            var item2 = new Item() { Name = "mleko", Quantity = 1 };
            var item3 = new Item() { Quantity = 3 };
            var item4 = new Item();

            Console.WriteLine(item1.ToString());

            List<Item> items = new List<Item>();
            items.Add(item1);
            items.Add(item2);
            items.Add(item3);
            items.Add(item4);

            //indeksowanie od 0, dlatego podajemy indeks 1 aby wyciągnąć element 2
            Console.WriteLine(items[1]);


            //for (int i = 0; i < items.Count; i++)
            //{
            //    var item = items[i];
            foreach(var item in items)
            { 
                Console.WriteLine(item);
            }
        }
    }
}
