using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS
{
    internal class Test
    {
        public static void Izvedi()
        {
            Console.WriteLine("Unesite broj redaka matrice:");
            int redci = int.Parse(Console.ReadLine());

            Console.WriteLine("Unesite broj stupaca matrice:");
            int stupci = int.Parse(Console.ReadLine());

            int[,] spiralnaMatrica = GenerirajSpiralnuMatricu(redci, stupci);

            Console.WriteLine("Generirana spiralna matrica:");
            IspisiMatricu(spiralnaMatrica);
        }

        static int[,] GenerirajSpiralnuMatricu(int redci, int stupci)
        {
            int[,] matrica = new int[redci, stupci];

            int brojac = 1;
            int vrh = 0, dno = redci - 1, lijevo = 0, desno = stupci - 1;

            while (brojac <= redci * stupci)
            {
                for (int i = desno; i >= lijevo; i--)
                {
                    matrica[dno, i] = brojac++;
                }
                vrh++;

                for (int i = dno; i >= vrh; i--)
                {
                    matrica[i, lijevo] = brojac++;
                }
                desno--;

                for (int i = lijevo; i <= desno; i++)
                {
                    matrica[vrh, i] = brojac++;
                }
                dno--;

                for (int i = vrh; i <= dno; i++)
                {
                    matrica[vrh, desno] = brojac++;
                }
                lijevo++;
            }

            return matrica;
        }

        static void IspisiMatricu(int[,] matrica)
        {
            int redci = matrica.GetLength(0);
            int stupci = matrica.GetLength(1);

            for (int i = 0; i < redci; i++)
            {
                for (int j = 0; j < stupci; j++)
                {
                    Console.Write($"{matrica[i, j],4} ");
                }
                Console.WriteLine();
            }
        }
    

    }
}
