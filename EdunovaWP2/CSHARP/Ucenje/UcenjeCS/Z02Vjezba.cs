using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02Vjezba
    {
        public static int Zbroj(int broj, int suma)
        {
            suma += broj;

            return suma;
        }

        public static int Najmanji(int broj, int min)
        {
            if (broj < min)
            {
                min = broj;
            }

            return min;
        }

        public static int Najveci(int broj, int max)
        {
            if (broj > max)
            {
                max = broj;
            }

            return max;
        }

        public static double Prosjek(int suma, int br)
        {
            return (double)suma / br;
        }

        public static void Izvedi()
        {
            int suma = 0;
            int min = 0;
            int max = 0;
            int br = 0;
            while (true)
            {
                Console.Write("Unesite broj (-1 za kraj): ");
                try
                {
                    int broj = int.Parse(Console.ReadLine());

                    if (broj == -1)
                    {
                        break;
                    }

                    Zbroj(broj, suma);
                    Najmanji(broj, min);
                    Najveci(broj, max);
                    br++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Neispravan unos, molimo unesite cijeli broj.");
                }
            }

            Console.WriteLine("Zbroj unesenih brojeva je: " + suma);
            Console.WriteLine("Najmanji uneseni broj je: " + min);
            Console.WriteLine("Najveći uneseni broj je: " + max);
            Console.WriteLine("Prosjek unesenih brojeva je: " + Prosjek(suma, br));
        }








    }
}
