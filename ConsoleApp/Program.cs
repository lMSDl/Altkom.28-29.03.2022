//USING - deklarujemy, że będziemy korzystać z klasy wskazanej przestrzeni nazw
using System;

// PRZESTRZEŃ NAZW - swego rodzaju adres, pod którym "mieszkają" klasy
namespace ConsoleApp
{
    //KLASA - opisuje zachowania i właściwości obiektów (instancje klas), które będą na jej potstawie wytwarzane
    //Pełna nazwa klasy to namespace + nazwa klasy
    //Modyfikatory dostępu: public (dostępna wszędzie) i internal (tylko w obrębie assembly)
    class Program
    {
        //METODA - typ zwracany + nazwa + nawiasy okrągłe + opcjonalne parametry + ciało w nawiasach klamrowych
        //Modyfikatory dostępu: public, internal, private (dostępna tylko w obrebie klasy), protected (dostępna w obrębie klasy i klas dziedziczących)
        //brak wskazania modyfikatora dostępu = private
        //STATIC - jest to metoda niezależna od instancji klasy (może być wywołana bez potrzeby tworzenia obiektu danej klasy)
        //VOID - radzaj typu zwracanego - oznaczający, że metoda nic nie zwraca
        static void Main(string[] args)
        {
            Strings();
        }

        private static void Strings()
        {
            //deklaracja i inicjalizacja zmiennej loklnej typu string o nazwie helloString
            string helloString = "Hello";

            //deklaracja - określenie, że będziemy używać zmienną typu string o nazwie world
            string world;
            //inicjalizacja - pierwsze przypisanie wartości do zmiennej
            world = "world!";
            Console.WriteLine(world);
            //przypisanie wartości
            world = "world";
            Console.WriteLine(world);


            Console.WriteLine(helloString + world);
            string helloWorldString = helloString + world;
            Console.WriteLine(helloWorldString);

            //budowanie stringa z kilku części
            helloWorldString = helloString + " " + world + "!";
            Console.WriteLine(helloWorldString);

            //string format
            helloWorldString = string.Format("{0} {1}!", helloString, world);
            Console.WriteLine(helloWorldString);
            string helloWorldStringFormat = "{1} {0}!!!";
            helloWorldString = string.Format(helloWorldStringFormat, world, helloString);
            Console.WriteLine(helloWorldString);

            //string interpolowany
            Console.WriteLine($"{helloString} {world}!");
            Console.WriteLine("{helloString} {world}!");

            world.Replace("o", "0");
            Console.WriteLine($"{helloString} {world}!");
            world = world.Replace("o", "0");
            world = world.ToUpper();
            //Console.WriteLine($"{helloString} {world}!");
            WriteGreetingsToTargetOnConsole(helloString, world);
            WriteGreetingsToTargetOnConsole("Welcome", world);

            string target = Console.ReadLine();
            WriteGreetingsToTargetOnConsole(helloString, target);
        }

        static void WriteGreetingsToTargetOnConsole(string greetings, string target)
        {
            Console.WriteLine($"{greetings} {target}!");
        }
    }
}
