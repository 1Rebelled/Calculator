using System;

namespace kalkulatorfinal
{
    class Program1
    {
        static void Main1(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;


            Console.WriteLine("Kalkulator WSB");
            Console.WriteLine("---------------");

            Console.WriteLine("Proszę o podanie pierwszej liczby");


            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Proszę o podanie drugiej liczby");



            var num2 = int.Parse(Console.ReadLine());


            



            Console.WriteLine("Jaką czynność chcesz wykonać?"); 


            

            Console.WriteLine("a - dodawanie"); 




            Console.WriteLine("b - odejmowanie"); 
            Console.WriteLine("c - mnożenie"); 
            Console.WriteLine("d - dzielenie"); 
            Console.WriteLine("e - wyliczanie wartości procentowej"); 
            Console.WriteLine("f - kwadrat wybranej liczby"); 
            Console.WriteLine("g - pierwiastek wybranej liczby\n\n"); 



            var operations = (Console.ReadLine());
            

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
                    Console.WriteLine("");
                    int num3 = (num1 + num2);
                    double WynikDzielenia = num3 *0.01;

                    Console.WriteLine($"\nSuma obu cyfr wynosi {WynikDzielenia} procent liczby 100");
                    break;




                case "f":
                  
                  Console.WriteLine($"Którą liczbę chcesz podnieść do kwadratu? {num1} czy {num2}");

                    var Wybor = int.Parse(Console.ReadLine());
                 



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




                case "g":
                    
                    Console.WriteLine($"Której liczby pierwiastek chcesz obliczyć {num1} czy {num2}?");

                     Wybor = int.Parse(Console.ReadLine());

                    double wynik2;


                    if (Wybor == num1)
                    {
                        wynik2 = Math.Sqrt(num1);
                        Console.WriteLine($"\nTwój wynik to " + wynik2);
                    }
                    else
                    {
                        wynik2 = Math.Sqrt(num2);
                        Console.WriteLine($"\nTwój wynik to " + wynik2);
                    }
                    break;


                






                
























            }
        }


    }
}