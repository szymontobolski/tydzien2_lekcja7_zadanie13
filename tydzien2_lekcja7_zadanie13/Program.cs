using System;

namespace tydzien2_lekcja7_zadanie13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Podaj drugą liczbę");
            int b = int.Parse(Console.ReadLine());

            double dodawanie = (a + b);
            double odejmowanie = (a - b);
            double mnożenie = (a * b);
            double dzielenie = (a / b);

            Console.WriteLine("Wybierz opcję");
            Console.WriteLine("1 - dodawanie");
            Console.WriteLine("2 - odejmowanie");
            Console.WriteLine("3 - mnożenie");
            Console.WriteLine("4 - dzielenie");

            int działanie = int.Parse(Console.ReadLine());

            if (działanie == 1)
                Console.WriteLine($"Twój wynik dodawania to: {dodawanie}");
            if (działanie == 2)
                Console.WriteLine($" Twój wynik to: {odejmowanie}");
            if (działanie == 3)
                Console.WriteLine($"Twój wynik to: {mnożenie}");
            if (działanie == 4)
                Console.WriteLine($"Twój wynik to: {dzielenie}");



        }   }        } 
        
