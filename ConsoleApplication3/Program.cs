using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication3
{
    internal class Program
    {
        public static void Napisz(List<string> kandydatki)
        {
            bool trzezwy = false;
            Console.Clear();
            Console.WriteLine("Kandydatki do wysłania SMS : ");
            foreach (var VARIABLE in kandydatki)
            {
                Console.Write(VARIABLE + " ");
            }

            Console.WriteLine();
            Console.WriteLine("Wybierz do jakiej piszemy! (1-3)");
            Console.WriteLine();
            int ID = int.Parse(Console.ReadLine()) - 1;
            Console.WriteLine($"Wybrałeś {kandydatki[ID]}");
            Console.WriteLine();
            Console.WriteLine("Napisz co jej wyslesz za SMS : ");
            string wiadomosc = Console.ReadLine();
            Console.WriteLine($"Czy napewno chcesz wysłać SMS o treści {wiadomosc} do {kandydatki[ID]}? [T/N]");
            string potwierdzenie = Console.ReadLine();
            switch (potwierdzenie)
            {
                case "T":
                    Console.WriteLine("Wysłano!");
                    Console.ReadKey();
                    break;
                case "N":
                    Console.WriteLine("Tchórz");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Zła litera");
                    break;
            }
        }
        public static bool CzyZdolny()
        {
            bool wynik = false;
            Random r = new Random();
            int dzialanie = r.Next(1, 5);
            int a = r.Next(1, 11);
            int b = r.Next(1, 11);
            int odp;
            switch (dzialanie)
            {
                case 1:
                    Console.WriteLine($"Podaj wynik =  {a} + {b} : ");
                    odp = int.Parse(Console.ReadLine());
                    wynik = odp == a + b;
                    break;
                case 2:
                    Console.WriteLine($"Podaj wynik =  {a} - {b} : ");
                    odp = int.Parse(Console.ReadLine());
                    wynik = odp == a - b;
                    break;
                case 3:
                    Console.WriteLine($"Podaj wynik =  {a} * {b} : ");
                    odp = int.Parse(Console.ReadLine());
                    wynik = odp == a * b;
                    break;
                case 4:
                    Console.WriteLine($"Podaj wynik =  {a} / {b} : ");
                    odp = int.Parse(Console.ReadLine());
                    wynik = odp == a / b;
                    break;
            }
            return wynik;
        }

        public static bool Menu(bool trzezwy)
        {
            
            List<string> Kandydatki = new List<string>();
            Kandydatki.Add("Zocha");
            Kandydatki.Add("Krycha");
            Kandydatki.Add("Marycha");
            Console.Clear();
            Console.WriteLine("Co robimy?");
            Console.WriteLine("1. Napisz");
            Console.WriteLine("2. Czy zdolny?");
            Console.WriteLine("3. Wyjdź");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if (!trzezwy)
                    {
                        Console.WriteLine("Wykonaj zadanie!");
                        Console.ReadKey();
                    }
                    else
                    {
                        Napisz(Kandydatki);
                    }
                    return Menu(trzezwy);
                case "2":
                    if (CzyZdolny())
                    {
                        trzezwy = true;
                    }
                    return Menu(trzezwy);
                case "3":
                    return trzezwy;
                default:
                    return Menu(trzezwy);
            }
        }
        
        public static void Main(string[] args)
        {
            bool trzezwy = false;
            Menu(trzezwy);
        }
    }
}
