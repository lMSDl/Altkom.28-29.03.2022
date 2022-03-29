using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Numbers
    {
        //KONTRUKTOR Z PARAMETREM
        public Numbers(int initNumber)
        {
        }
        //KONTRUKTOR BEZPARAMETROWY - jeśli nie istnieje żadnen kontruktor, to takie jest tworzony automatycznie
        public Numbers()
        {

        }


        public void Run()
        {
            int a = 30;
            int b = 2;
            int c;
            c = 11;

            int d = a - 3 * c + a * b;
            Console.WriteLine($"a = {a}, b = {b}, c = {c}");
            Console.WriteLine($"a - 3 * c + a * b = {d}");

            //int ucina część po przecinku - nie zaokrągla wyniku
            d = a / c;
            Console.WriteLine($"a / c = {d} reszty {a % c}");

            byte byteValue = 2;
            short shortValue = 2;
            long longValue = 2l;

            float floatValue = 2f;
            double doubleValue = 2d;
            doubleValue = .2;
            decimal decimanValue = 2m;

            Console.WriteLine($"int posiada zakres od {int.MinValue} do {int.MaxValue}");
            Console.WriteLine($"long posiada zakres od {long.MinValue} do {long.MaxValue}");
            Console.WriteLine($"float posiada zakres od {float.MinValue} do {float.MaxValue}");
            Console.WriteLine($"double posiada zakres od {double.MinValue} do {double.MaxValue}");
            Console.WriteLine($"decimal posiada zakres od {decimal.MinValue} do {decimal.MaxValue}");

            //Math - statyczna klasa z użytecznymi funkcjami matematycznymi
            var area = Math.Pow(a, 2) / 2 * Math.PI;
            Console.WriteLine($"Połowa powierzchni koła o promieniu {a} = {area}");

            floatValue = 1f / 3;
            //niejawne rzutowanie na typ o wyższej precyzji
            doubleValue = floatValue;
            Console.WriteLine($"{floatValue} => {doubleValue}");


            doubleValue = 1d / 3;
            //jawne rzutowanie na typ o niższej precyzji
            floatValue = (float)doubleValue;
            Console.WriteLine($"{doubleValue.ToString()} => " + floatValue);


            //metoda Parse konwertuje string do wartości liczbowej - w przypadku niepowodzenia rzucany jest wyjątek
            //metoda TryParse konwertuje string do wartości liczbowej - w przypadku niepowodzenia metoda zwraca fałsz, a w przeciwnym razie prawda oraz wpisuje wartość do patametru wyjściowego (out)
            //var - niejawna deklaracja - typ określony jest przez prawą stronę równania (przez inicjalizację)
            var userValue = Console.ReadLine();
            float floatUserValue;
            //floatUserValue = float.Parse(userValue);
            bool result = float.TryParse(userValue, out floatUserValue);
            if (result == true)
                Console.WriteLine(floatUserValue);

            //long longUserValue = long.Parse(userValue);
            result = long.TryParse(userValue, out var longUserValue);
            if (result == true)
            {
                Console.WriteLine(longUserValue);
            }
        }

        public double CaluclateAreaCircle(double r)
        {
            var area = Math.PI * Math.Pow(r, 2);
            //return - zwraca wynik funkcji
            return area;
        }
        public double CaluclateCircumreferenceCircle(double r)
        {
            var result = Math.PI * 2 * r;
            return result;
        }

        public void RunCircleCalculator()
        {
            var r = RequestR();
            //if (r == null)
            if (!r.HasValue)
                    return;


            var result = CaluclateAreaCircle(r.Value);
            Console.WriteLine($"Obwód koła o promieniu {r} to: {result}");

        }

        /// <summary>
        /// Metoda pobierająca promień od użytkownika
        /// </summary>
        /// <returns>promień koła lub null jeśli nie udało się pobrać wartości</returns>
        private double? RequestR(int counter = 3) //counter - parametr opcjonalny (z wartością domyślną). takie parametry muszą być zdefiniowane na końcu ciągu parametrów
        {
            Console.WriteLine("Podaj promień koła");

            double r = 0;
            //pętla for - wykonuje działania w 4 etapach - inicjalizacja -> sprawdzenie warunku -> ciało pętli -> inkrementacja/dekrementacja -> sprawdzenie warunku -> itd....

            //for(; ; ) - nieskończona pętla for
            //[*] for(var i = 0;  i < counter; i++/*i = i + 1*/)
            for (var i = counter; i > 0; i--)
            {
                var userValue = Console.ReadLine();
                //instrukcja warunkowa - if

                //[*] if (double.TryParse(userValue, out r) == false)
                if (!double.TryParse(userValue, out r))
                {
                    //[*] if (i == counter - 1)
                    if (i == 1)
                    {
                        Console.WriteLine("Przepkroczono liczbę prób!");
                        return null;
                    }
                    else
                    {
                        //[*] Console.WriteLine($"Błędna wartość, spóbuj jeszcze raz! (pozostało prób: {counter - i - 1})");
                        Console.WriteLine($"Błędna wartość, spóbuj jeszcze raz! (pozostało prób: {i - 1})");
                    }
                }
                else
                {
                    //[*] i = 3;
                    break;
                }
            }

            //return - wychodzi z funkcji i służy do zwracania wartości
            return r;
        }
    }
}
