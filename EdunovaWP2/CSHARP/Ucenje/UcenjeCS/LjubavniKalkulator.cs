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


        }

        public static int PretvoriUBrojeve(string TvojeIme, string SimpatijaIme)
        {
            string[] Unos = new string[TvojeIme.Length + SimpatijaIme.Length];
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
            int[] Rezultat = new int[]; 
            for (int i; i<;i++)
            {
                
            }
        }




    }
}
