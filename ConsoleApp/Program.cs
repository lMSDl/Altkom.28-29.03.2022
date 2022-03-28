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
            Console.WriteLine("Hello World!");
        }
    }
}
