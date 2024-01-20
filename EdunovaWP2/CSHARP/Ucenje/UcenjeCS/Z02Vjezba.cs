using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Z02Vjezba
    {
        public static int Zbroj(int[] niz)
        {
            int suma = 0;
            foreach (int broj in niz)
            {
                suma += broj;
            }
            return suma;
        }

        public static int Najmanji(int[] niz)
        {
            int min = niz[0];
            foreach (int broj in niz)
            {
                if (broj < min)
                {
                    min = broj;
                }
            }
            return min;
        }

        public static int Najveci(int[] niz)
        {
            int max = niz[0];
            foreach (int broj in niz)
            {
                if (broj > max)
                {
                    max = broj;
                }
            }
            return max;
        }

        public static double Prosjek(int[] niz)
        {
            return (double)Zbroj(niz) / niz.Length;
        }

        public static void Izvedi()
        {
            var lista = new System.Collections.Generic.List<int>();

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

                    lista.Add(broj);
                }
                catch (FormatException)
                {
                    Console.WriteLine("Neispravan unos, molimo unesite cijeli broj.");
                }
            }

            int[] niz = lista.ToArray();

            if (niz.Length == 0)
            {
                Console.WriteLine("Niste unijeli niti jedan broj.");
            }
            else
            {
                Console.WriteLine("Zbroj unesenih brojeva je: " + Zbroj(niz));
                Console.WriteLine("Najmanji uneseni broj je: " + Najmanji(niz));
                Console.WriteLine("Najveći uneseni broj je: " + Najveci(niz));
                Console.WriteLine("Prosjek unesenih brojeva je: " + Prosjek(niz));
            }
        }








    }
}
