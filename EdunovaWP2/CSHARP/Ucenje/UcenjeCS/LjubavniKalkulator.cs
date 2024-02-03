﻿using System;
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

            Rezultat();
        }

        public static string Rezultat()
        {
            return IzracunajKompatibilnost(PretvoriUBrojeve(TvojeIme+SimpatijaIme)) + "%";
        }

        public static int[] PretvoriUBrojeve(string TvojeIme, string SimpatijaIme)
        {
            string Unos = string.Concat(TvojeIme, SimpatijaIme);
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

        public static int[] IzracunajKompatibilnost(int[] Slova)
        {
            int[] Rezultat = new int[Slova.Length];
            for (int i = 0; i < Slova.Length && Slova.Length -i >= 0; i++)
            {
                Rezultat[i] = Slova[i] + Slova[Slova.Length-i];
            }
            return Rezultat;
        }




    }
}
