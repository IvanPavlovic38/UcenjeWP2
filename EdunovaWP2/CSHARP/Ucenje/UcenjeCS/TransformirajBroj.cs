using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class TransformirajBroj
    {
        static int TransformirajBr(int broj)
        {
            // Pretvara broj u niz znamenki
            char[] znamenke = broj.ToString().ToCharArray();
            int duljina = znamenke.Length;

            // Stvara novi niz za transformirane znamenke
            char[] transformiraneZnamenke = new char[duljina];

            // Iterira kroz znamenke i obavlja transformaciju
            for (int i = 0; i < duljina; i++)
            {
                // Pronalazi indeks suprotne znamenke
                int suprotniIndex = duljina - 1 - i;

                // Računa zbroj trenutne i suprotne znamenke
                int zbroj = int.Parse(znamenke[i].ToString()) + int.Parse(znamenke[suprotniIndex].ToString());

                // Postavlja transformiranu znamenku na odgovarajući indeks
                transformiraneZnamenke[i] = char.Parse(zbroj.ToString());
            }

            // Pretvara niz znamenki u string i zatim u cijeli broj
            int transformiraniBroj = int.Parse(new string(transformiraneZnamenke));

            return transformiraniBroj;
        }

        public static void Izvedi()
        {
            // Primjer poziva metode
            int broj = 342262;
            int transformiraniBroj = TransformirajBr(broj);
            Console.WriteLine("Transformirani broj: " + transformiraniBroj);
        }
    }
}
