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
            try
            {
                Console.WriteLine("Unesite svoje ime:");
                string tvojeIme = Console.ReadLine();
                ProvjeriIme(tvojeIme);

                Console.WriteLine("Unesite ime vaše simpatije:");
                string imeSimpatije = Console.ReadLine();
                ProvjeriIme(imeSimpatije);

                string rezultat = IzracunajPostotakLjubavi(tvojeIme, imeSimpatije);
                Console.WriteLine($"Postotak ljubavi: {rezultat}%");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Došlo je do pogreške: {e.Message}");
            }
        }

        public static void ProvjeriIme(string ime)
        {
            if (string.IsNullOrEmpty(ime))
            {
                throw new ArgumentException("Ime ne smije biti prazno.");
            }

            foreach (char c in ime)
            {
                if (!char.IsLetter(c) || !char.IsUpper(c))
                {
                    throw new ArgumentException("Ime mora sadržavati samo velika slova.");
                }
            }
        }

        static string IzracunajPostotakLjubavi(string tvojeIme, string imeSimpatije)
        {
            string spojenaImena = tvojeIme + imeSimpatije;
            int[] brojaci = new int[spojenaImena.Length];

            foreach (char c in spojenaImena)
            {
                brojaci[c - 'A']++;
            }

            string rezultat = "";

            foreach (int brojac in brojaci)
            {
                if (brojac > 0)
                    rezultat += brojac.ToString();
            }

            while (rezultat.Length > 2)
            {
                string privremeniRezultat = "";

                for (int i = 0; i < rezultat.Length - 1; i++)
                {
                    int zbrojZnamenki = (rezultat[i] - '0') + (rezultat[i + 1] - '0');
                    privremeniRezultat += zbrojZnamenki.ToString();
                }

                rezultat = privremeniRezultat;
            }

            return rezultat;
        }
    









    }
}
