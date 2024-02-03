using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
        public string TvojeIme { get; set; }
        public string SimpatijaIme { get; set; }
        public static void Izvedi()
        {
            Console.WriteLine("Unesite svoje ime:");
            TvojeIme = Console.ReadLine();

            Console.WriteLine("Unesite ime svoje simpatije:");
            SimpatijaIme = Console.ReadLine();

            Rezultat();
        }

        public static string Rezultat()
        {
            return IzracunajKompatibilnost(PretvoriUBrojeve(TvojeIme+SimpatijaIme)) + "%";
        }

        public static int PretvoriUBrojeve(string TvojeIme, string SimpatijaIme)
        {
            string Unos;
            for(int i = 0; i < TvojeIme.Length; i++)
            {
                Unos[i] = TvojeIme[i];
            }
            for (int i = 0; i < SimpatijaIme.Length; i++)
            {
                Unos[i] = SimpatijaIme[i];
            }
            int[] Slova = new int[Unos.Length];
            int Index = 0;
            int Ukupno;
            foreach (char c in Unos)
            {
                Ukupno = 0;
                foreach (char cc in Unos)
                {
                    Ukupno++;
                }
                Slova[Index++] = Ukupno;
            }
            return Slova;
        }

        public static int IzracunajKompatibilnost(int Slova)
        {
            int[] Rezultat = new int[Slova.Length];
            for (int i; i<Slova.Length && Slova.Length-i>=0; i++)
            {
                Rezultat[i] = Slova[i] + Slova[Slova.Length-i];
            }
            return Rezultat;
        }




    }
}
