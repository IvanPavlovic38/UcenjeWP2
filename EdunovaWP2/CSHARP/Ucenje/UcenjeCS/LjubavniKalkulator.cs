using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite svoje ime:");
            string TvojeIme = Console.ReadLine();

            Console.WriteLine("Unesite ime svoje simpatije:");
            string SimpatijaIme = Console.ReadLine();

            Rezultat(TvojeIme, SimpatijaIme);
        }

        public static string Rezultat(string TvojeIme, string SimpatijaIme)
        {
            return IzracunajKompatibilnost(PretvoriUBrojeve(TvojeIme, SimpatijaIme)) + "%";
        }

        public static int[] PretvoriUBrojeve(string TvojeIme, string SimpatijaIme)
        {
            int[] TvojaSlova = new int[TvojeIme.Length];
            int[] SimpatijaSlova = new int[SimpatijaIme.Length];
            int Index = 0;
            int Ukupno;
            foreach (char c in TvojeIme)
            {
                Ukupno = 0;
                foreach (char cc in TvojeIme)
                {
                    Ukupno++;
                }
                TvojaSlova[Index++] = Ukupno;
            }
            Index = 0;
            foreach (char c in SimpatijaIme)
            {
                Ukupno = 0;
                foreach (char cc in SimpatijaIme)
                {
                    Ukupno++;
                }
                SimpatijaSlova[Index++] = Ukupno;
            }
            if (TvojaSlova.Length == SimpatijaSlova.Length)
            {
                int[] Slova = new int[TvojaSlova.Length];
                for (int i = 0; i < TvojaSlova.Length; i++)
                {
                    Slova[i] = TvojaSlova[i] + SimpatijaSlova[SimpatijaSlova.Length - i];
                }
            }
            else if (TvojaSlova.Length > SimpatijaSlova.Length)
            {
                int[] Slova = new int[TvojaSlova.Length];
                for (int i = 0; i < SimpatijaSlova.Length; i++)
                {
                    Slova[i] = TvojaSlova[i] + SimpatijaSlova[SimpatijaSlova.Length - i];
                }
                for (int j = i; j < TvojaSlova.Length; j++)
                {
                    Slova[j] = TvojaSlova[j];
                }
            }
            else
            {
                int[] Slova = new int[SimpatijaSlova.Length];
                for (int i = 0; i < TvojaSlova.Length; i++)
                {
                    Slova[i] = TvojaSlova[i] + SimpatijaSlova[SimpatijaSlova.Length - i];
                }
                for (int j = i; j < SimpatijaSlova.Length; j++)
                {
                    Slova[j] = SimpatijaSlova[j];
                }
            }
            return Slova;
        }

        public static int IzracunajKompatibilnost(int Slova)
        {
            char[] Rezultat = Slova.ToString().ToCharArray();
            int Duljina = Rezultat.Length;
            char[] NoviBroj = new char[Duljina];
            for (int i = 0; i < Duljina; i++)
            {
                Rezultat[i] = Rezultat[i] + Rezultat[Duljina-1-i];
            }
            int NoviRezultat = int.Parse(new string(Rezultat));
            if (NoviRezultat <= 100)
            {
                return NoviRezultat;
            }
            return IzracunajKompatibilnost(Rezultat);
        }




    }
}
