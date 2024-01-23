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
                Console.WriteLine("Unesi svoje ime:");
                string mojeIme = Console.ReadLine().ToUpper();
                Console.WriteLine("Unesi ime svoje simpatije:");
                string njegovoIme = Console.ReadLine().ToUpper();

                int[] mojiBrojevi = IzracunajBrojeve(mojeIme);
                int[] njegoviBrojevi = IzracunajBrojeve(njegovoIme);

                

                Console.WriteLine("Tvoj rezultat je {0}%", rezultat);          
            }

            static int[] IzracunajBrojeve(string ime)
            {
                int[] brojevi = new int[ime.Length];
                for (int i = 0; i < ime.Length; i++)
                {
                    char slovo = ime[i];
                    int broj = ime.Count(c => c == slovo);
                    brojevi[i] = broj;
                }
                return brojevi;
            }

            

           


    }
}
