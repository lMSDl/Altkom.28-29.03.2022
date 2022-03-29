using ShoppingList.Models;
using System;
using System.Collections.Generic;

namespace ShoppingList
{
    class Program
    {
        static List<Item> shoppingList = new List<Item>();
        static void Main(string[] args)
        {
            shoppingList.Add(new Item() { Name = "mleko", Quantity = 2 });
            shoppingList.Add(new Item() { Name = "kawa", Quantity = 1 });

            while (true)
            {
                Console.Clear();
                ShowList();

                Console.WriteLine("\n1. Dodaj   2. Usuń   3. Modyfikuj   0. Wyjście");
                var option = ReadIntFromUser();

                //Enum.TryParse(typeof(Options), option, out var optionAsEnum); //konwersja string na enum

                switch ((Options)option)
                {
                    case Options.Add:
                        AddToList();
                        break;
                    case Options.Remove:
                        RemoveFromList();
                        break;
                    case Options.Edit:
                        EditItem();
                        break;
                    case Options.Exit:
                        return;
                    default:
                        break;
                }
            }
        }

        private static void EditItem()
        {
            var position = ReadPositionFromUser();
            if (position < shoppingList.Count && position >= 0)
            {
                //wyciągamy element z listy podając jego index w nawiasie kwadratowym
                var item = shoppingList[position];

                ReadQuantityFromUser(item);
            }
            else
            {
                ShowWarning("Błędny numer pozycji");
            }
        }

        private static void ShowWarning(string warning)
        {
            warning = Figgle.FiggleFonts.Standard.Render(warning);
            Console.WriteLine(warning);
            _ = Console.ReadKey();
        }

        static void RemoveFromList()
        {
            var position = ReadPositionFromUser();
            try
            {
                shoppingList.RemoveAt(position);
            }
            catch
            {
                ShowWarning("Błędny numer pozycji");
            }
        }

        private static int ReadPositionFromUser()
        {
            Console.Write("Podaj numer pozycji na liście: ");
            var position = ReadIntFromUser();
            return position;
        }

        static void ShowList()
        {
            for (var i = 0; i < shoppingList.Count; i++)
            {
                var item = shoppingList[i];
                Console.WriteLine($"{i}. {item}");
            }
        }

        static void AddToList()
        {
            var item = new Item();
            Console.Write("Podaj nazwę: ");
            item.Name = Console.ReadLine();

            ReadQuantityFromUser(item);
            

            shoppingList.Add(item);
        }

        static void ReadQuantityFromUser(Item item)
        {
            Console.Write("Podaj ilość: ");
            item.Quantity = ReadIntFromUser();
        }

        private static int ReadIntFromUser()
        {
            var userString = Console.ReadLine();
            int value;
            while (!int.TryParse(userString, out value))
            {
                Console.WriteLine("Błędna wartość!");
            }

            return value;
        }

        private static void ItemsList()
        {
            //wykorzystanie inicjalizatora przy tworzeniu obiektu - może to zastąpić liczne konstruktory
            var item1 = new Item() { Name = "kawa" };
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
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
