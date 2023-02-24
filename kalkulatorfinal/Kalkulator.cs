 using System;

namespace kalkulatorfinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("Kalkulator WSB");
            Console.WriteLine("---------------");
            // Pobieranie pierwszej liczby do zmiennej
            Console.WriteLine("Proszę o podanie pierwszej liczby");

            var num1 = double.Parse(Console.ReadLine());
            // Pobieranie drugiej liczby do zmiennej
            Console.WriteLine("Proszę o podanie drugiej liczby");

            var num2 = double.Parse(Console.ReadLine());
            // Opcje wyboru a,b,c,d,e,f,g rezprezentujace poszczególne działania matematyczne
            Console.WriteLine("Jaką czynność chcesz wykonać?");
            Console.WriteLine("a - dodawanie");
            Console.WriteLine("b - odejmowanie");
            Console.WriteLine("c - mnożenie");
            Console.WriteLine("d - dzielenie");
            Console.WriteLine("e - wyliczanie wartości procentowej");
            Console.WriteLine("f - kwadrat wybranej liczby");
            Console.WriteLine("g - pierwiastek wybranej liczby\n\n");
            // deklaracja zmiennej operations użytej w instrukcji wyboru switch      
            var operations = (Console.ReadLine());

            // Instrukcja wyboru switch
            switch (operations)
            {
                case "a":
                    double wynik = (num1 + num2);

                    Console.WriteLine($"\nWynik dodawania wynosi {num1} + {num2} = " + wynik);
                    break;
                case "b":
                    wynik = (num1 - num2);

                    Console.WriteLine($"\nWynik odejmowania wynosi {num1} - {num2} = " + wynik);
                    break;
                case "c":
                    wynik = (num1 * num2);

                    Console.WriteLine($"\nWynik mnożenia wynosi {num1} * {num2} = " + wynik);
                    break;
                case "d":
                    wynik = (num1 / num2);

                    Console.WriteLine($"\nWynik dzielenia wynosi {num1} / {num2} = " + wynik);
                    break;
                case "e":
                    double num3 = (num1 + num2);
                    double WynikDzielenia = num3 * 0.01;

                    Console.WriteLine($"\nDodajac {num1} do {num2} otrzymamy sumę {num3} która wynosi   {WynikDzielenia} %" );
                    break;



                    // Potegowanie przez pomnożenie liczby przez samą siebie, można użyć również Math.Pow
                case "f":
                    Console.WriteLine($"Którą liczbę chcesz podnieść do kwadratu? {num1} czy {num2}");

                    var Wybor = double.Parse(Console.ReadLine());

                    if (Wybor == num1)
                    {
                        wynik = num1 * num1;
                        Console.WriteLine($"\nTwój wynik to " + wynik);
                    }
                    else
                    {
                        wynik = num2 * num2;
                        Console.WriteLine($"\nTwój wynik to " + wynik);
                    }
                    break;



                    // Pierwiastkowanie Math.Sqrt 
                case "g":
                    Console.WriteLine($"Której liczby pierwiastek chcesz obliczyć {num1} czy {num2}?");

                    Wybor = double.Parse(Console.ReadLine());

                    if (Wybor == num1)
                    {
                        wynik = Math.Sqrt(num1);
                        Console.WriteLine($"\nTwój wynik to " + wynik);
                    }
                    else
                    {
                        wynik = Math.Sqrt(num2);
                        Console.WriteLine($"\nTwój wynik to " + wynik);
                    }
                    break;
 
            }
        }


    }
}