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
        
        public static void Izvedi()
        {
            Console.WriteLine("Unesite brojeve (unos zavrsava s -1):");
            try
            {
                double[] brojevi = UnesiBrojeve();
                if (brojevi.Length > 0)
                {
                    double zbroj = Zbroj(brojevi);
                    double najmanji = Najmanji(brojevi);
                    double najveci = Najveci(brojevi);
                    double prosjek = Prosijek(brojevi);

                    IspisiRezultate(zbroj, najmanji, najveci, prosjek);
                }
                else
                {
                    Console.WriteLine("Niste unijeli nijedan broj.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Greška: {ex.Message}");
            }
        }

        static double[] UnesiBrojeve()
        {
            var brojevi = new System.Collections.Generic.List<double>();
            while (true)
            {
                string unos = Console.ReadLine();
                if (unos == "-1")
                {
                    break;
                }

                if (!double.TryParse(unos, out double broj))
                {
                    throw new Exception("Neispravan unos. Molimo unesite broj.");
                }

                brojevi.Add(broj);
            }

            return brojevi.ToArray();
        }

        static double Zbroj(double[] brojevi)
        {
            double zbroj = 0;
            foreach (var broj in brojevi)
            {
                zbroj += broj;
            }
            return zbroj;
        }

        static double Najmanji(double[] brojevi)
        {
            if (brojevi.Length == 0)
            {
                throw new Exception("Nema brojeva za pronalazak najmanjeg broja.");
            }

            double najmanji = brojevi[0];
            foreach (var broj in brojevi)
            {
                if (broj < najmanji)
                {
                    najmanji = broj;
                }
            }
            return najmanji;
        }

        static double Najveci(double[] brojevi)
        {
            if (brojevi.Length == 0)
            {
                throw new Exception("Nema brojeva za pronalazak najvećeg broja.");
            }

            double najveci = brojevi[0];
            foreach (var broj in brojevi)
            {
                if (broj > najveci)
                {
                    najveci = broj;
                }
            }
            return najveci;
        }

        static double Prosijek(double[] brojevi)
        {
            if (brojevi.Length == 0)
            {
                throw new Exception("Nema brojeva za izračun prosjeka.");
            }

            double zbroj = Zbroj(brojevi);
            return zbroj / brojevi.Length;
        }

        static void IspisiRezultate(double zbroj, double najmanji, double najveci, double prosjek)
        {
            Console.WriteLine($"Zbroj: {zbroj}");
            Console.WriteLine($"Najmanji broj: {najmanji}");
            Console.WriteLine($"Najveći broj: {najveci}");
            Console.WriteLine($"Prosjek: {prosjek}");
        }
    




    }
}
