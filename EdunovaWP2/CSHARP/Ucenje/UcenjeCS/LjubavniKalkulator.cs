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

            Console.WriteLine(PretvoriUBrojeve(TvojeIme, SimpatijaIme));
            Console.WriteLine(Rezultat(TvojeIme, SimpatijaIme));
        }

        public static string Rezultat(string TvojeIme, string SimpatijaIme)
        {
            return IzracunajKompatibilnost(PretvoriUBrojeve(TvojeIme,SimpatijaIme)) + "%";
        }

        public static int PretvoriUBrojeve(string TvojeIme, string SimpatijaIme)
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
                    if (c == cc)
                    {
                        Ukupno++;
                    }
                }
                foreach (char cc in SimpatijaIme)
                {
                    if (c == cc)
                    {
                        Ukupno++;
                    }
                }
                TvojaSlova[Index++] = Ukupno;
            }
            Index = 0;
            foreach (char c in SimpatijaIme)
            {
                Ukupno = 0;
                foreach (char cc in TvojeIme)
                {
                    if (c == cc)
                    {
                        Ukupno++;
                    }
                }
                foreach (char cc in SimpatijaIme)
                {
                    if (c == cc)
                    {
                        Ukupno++;
                    }
                }
                SimpatijaSlova[Index++] = Ukupno;
            }
            string ConcatTvoje = string.Join("", TvojaSlova);
            string ConcatSimpatija = string.Join("", SimpatijaSlova);

            string Rezultat = "";
            int length = Math.Max(ConcatTvoje.Length, ConcatSimpatija.Length);

            for (int i = 0; i < length; i++)
            {
                int PrvaZnamenka = i < ConcatTvoje.Length ? int.Parse(ConcatTvoje[i].ToString()) : 0;
                int DrugaZnamenka = i < ConcatSimpatija.Length ? int.Parse(ConcatSimpatija[length - 1 - i].ToString()) : 0;

                int sum = PrvaZnamenka + DrugaZnamenka;
                Rezultat += sum.ToString();
            }

            return int.Parse(Rezultat);
        }


        public static int IzracunajKompatibilnost(int Slova)
        {
            char[] Znamenke = Slova.ToString().ToCharArray();
            int Duljina = Znamenke.Length;
            char[] TransformiraneZnamenke = new char[Duljina];
            int zbroj;
            int i;
            for (i = 0; i < Duljina / 2; i++)
            {
                int SuprotniIndex = Duljina - 1 - i;
                zbroj = int.Parse(Znamenke[i].ToString()) + int.Parse(Znamenke[SuprotniIndex].ToString());
                TransformiraneZnamenke[i] = (char)(zbroj + '0');
            }
            if (Duljina % 2 == 1)
            {
                TransformiraneZnamenke[Duljina / 2] = Znamenke[Duljina / 2];
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
