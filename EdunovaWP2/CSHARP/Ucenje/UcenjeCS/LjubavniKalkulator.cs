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

            Console.WriteLine(PretvoriUBrojeve(TvojeIme) + "," + PretvoriUBrojeve(SimpatijaIme));
            Console.WriteLine(Rezultat(TvojeIme, SimpatijaIme));
        }

        public static string Rezultat(string TvojeIme, string SimpatijaIme)
        {
            return IzracunajKompatibilnost(ZbrojiBrojeve(PretvoriUBrojeve(TvojeIme), PretvoriUBrojeve(SimpatijaIme))) + "%";
        }

        public static int PretvoriUBrojeve(string Ime)
        {
            int[] Slova = new int[Ime.Length];
            int Index = 0;
            int Ukupno;
            foreach (char c in Ime)
            {
                Ukupno = 0;
                foreach (char cc in Ime)
                {
                    Ukupno++;
                }
                Slova[Index++] = Ukupno;
            }
            string Concatenated = string.Join("", Slova);
            int Rezultat = int.Parse(Concatenated);
            return Rezultat;
        }

        private static int ZbrojiBrojeve(int PrviBroj, int DrugiBroj)
        {
            string strBroj1 = PrviBroj.ToString();
            string strBroj2 = DrugiBroj.ToString();

            string Rezultat = "";

            int length = Math.Max(strBroj1.Length, strBroj2.Length);

            for (int i = 0; i < length; i++)
            {
                int PrvaZnamenka = i < strBroj1.Length ? int.Parse(strBroj1[i].ToString()) : 0;
                int DrugaZnamenka = i < strBroj2.Length ? int.Parse(strBroj2[i].ToString()) : 0;

                int Suma = PrvaZnamenka + DrugaZnamenka;
                Rezultat += Suma.ToString();
            }

            return int.Parse(Rezultat);
        }

        public static int IzracunajKompatibilnost(int Slova)
        {
            char[] Znamenke = Slova.ToString().ToCharArray();
            int Duljina = Znamenke.Length;
            char[] TransformiraneZnamenke = new char[Duljina];
            for (int i = 0; i < Duljina; i++)
            {
                int zbroj = int.Parse(Znamenke[i].ToString()) + int.Parse(Znamenke[Duljina-1-i].ToString());
                TransformiraneZnamenke[i] = char.Parse(zbroj.ToString());
            }
            int TransformiraniBroj = int.Parse(new string(TransformiraneZnamenke));
            if (TransformiraniBroj <= 100)
            {
                return TransformiraniBroj;
            }
            return IzracunajKompatibilnost(TransformiraniBroj);
        }




    }
}
