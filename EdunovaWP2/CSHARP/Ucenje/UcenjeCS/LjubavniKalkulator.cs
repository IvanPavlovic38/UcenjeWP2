using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class LjubavniKalkulator
    {


using System;
using System.Collections.Generic;
using System.Linq;

class Program
    {
        static void Main()
        {
            Console.WriteLine("Unesite svoje ime:");
            string tvojeIme = Console.ReadLine();

            Console.WriteLine("Unesite ime svoje simpatije:");
            string simpatijaIme = Console.ReadLine();

            Console.WriteLine("Prvi redak:");
            IspisiBrojeve(tvojeIme);
            IspisiBrojeve(simpatijaIme);

            Console.WriteLine("Drugi redak:");
            int[] zbrojiPrviZadnji = ZbrojiPrviZadnji(tvojeIme, simpatijaIme);
            IspisiZbroj(zbrojiPrviZadnji);

            Console.WriteLine("Treći redak:");
            int[] zbrojiSrednje = ZbrojiSrednje(tvojeIme, simpatijaIme);
            IspisiZbroj(zbrojiSrednje);

            Console.WriteLine("Četvrti redak - Postotak ljubavi:");
            double postotakLjubavi = IzracunajPostotak(zbrojiPrviZadnji, zbrojiSrednje);
            Console.WriteLine($"{postotakLjubavi}%");

        }

        static void IspisiBrojeve(string ime)
        {
            Dictionary<char, int> brojac = new Dictionary<char, int>();

            foreach (char slovo in ime)
            {
                if (brojac.ContainsKey(slovo))
                {
                    brojac[slovo]++;
                }
                else
                {
                    brojac[slovo] = 1;
                }
            }

            foreach (var par in brojac)
            {
                Console.Write($"{par.Key}{par.Value} ");
            }
            Console.WriteLine();
        }

        static int[] ZbrojiPrviZadnji(string tvojeIme, string simpatijaIme)
        {
            int prviZadnji = BrojZadnjih(tvojeIme) + BrojPrvih(simpatijaIme);
            return new int[] { prviZadnji };
        }

        static int[] ZbrojiSrednje(string tvojeIme, string simpatijaIme)
        {
            int srednjiTvoje = BrojSrednjih(tvojeIme);
            int srednjiSimpatije = BrojSrednjih(simpatijaIme);
            return new int[] { srednjiTvoje, srednjiSimpatije };
        }

        static void IspisiZbroj(int[] zbroj)
        {
            foreach (var broj in zbroj)
            {
                Console.Write($"{broj} ");
            }
            Console.WriteLine();
        }

        static int BrojPrvih(string tekst)
        {
            return int.Parse(new string(tekst.Take(2).ToArray()));
        }

        static int BrojZadnjih(string tekst)
        {
            return int.Parse(new string(tekst.Reverse().Take(2).Reverse().ToArray()));
        }

        static int BrojSrednjih(string tekst)
        {
            return int.Parse(new string(tekst.Skip(2).Take(2).ToArray()));
        }

        static double IzracunajPostotak(int[] zbrojPrviZadnji, int[] zbrojSrednje)
        {
            int ukupniZbroj = zbrojPrviZadnji[0] + zbrojSrednje[0] + zbrojSrednje[1];
            return (ukupniZbroj % 101); // Da dobijemo postotak
        }
    }

















}
}
