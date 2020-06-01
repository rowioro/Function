using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_Funkcje
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab = new int[2];
            int[] tab = { 6, 12 };
            Console.WriteLine(tab[0] + " , " + tab[1]);
            Zmien_tab(tab);
            Console.WriteLine(tab[0] + " , " + tab[1]);

            Console.WriteLine(Suma(6, 11));
            int a = 5;
            Console.WriteLine("Przed: " + a);
            Referencja(ref a);
            Console.WriteLine("Po: " + a);
            int y;
            Poza(out y);
            Console.WriteLine("Po: " + y);
            Console.ReadKey();
        }

        static void Zmien_tab(int[] tab)
        {
            tab[0] = 0;
            tab[1] = 0;
        }
        static string Suma(int a, int b)
        {
            int wynik = a + b;
            if (wynik >= 17)
                //Console.WriteLine(wynik);
                return "Brawo! Zdales egzamin.";
            else
                return "Nie zdales egzaminu.";
        }

        static void Referencja(ref int x)
        {
            x += 5;
            Console.WriteLine(x);
        }

        static void Poza(out int z)
        {
            z = 10;
            Console.WriteLine(z);
            z += 10;
        }
    }
}
