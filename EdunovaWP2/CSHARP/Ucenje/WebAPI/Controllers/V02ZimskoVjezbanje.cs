﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje : ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1()
        {
            int zbroj = 0;

            for (int i = 0; i < 100; i++)
            {
                zbroj = zbroj + i + 1;
            }

            return zbroj;
        }

        [HttpGet]
        [Route("zad2")]
        public int[] Zad2()
        {
            int[] Niz = new int[28];
            int Index = 0;
            for (int i = 1; i <= 57; i++)
            {
                if (i % 2 == 0)
                {
                    Niz[Index] = i;
                    Index++;
                }
            }
            return Niz;
        }


        [HttpGet]
        [Route("zad3")]
        public int Zad3()
        {
            int zbroj = 0;

            for (int i = 2; i <= 18; i++)
            {
                if (i % 2 == 0)
                {
                    zbroj = zbroj + i;
                }
            }

            return zbroj;

        }

        [HttpGet]
        [Route("zad4")]
        public int Zad4(int broj)
        {
            int suma = 0;
            for (int i = 1; i <= broj; i++)
            {
                suma += i;
            }
            return suma;
        }

        [HttpGet]
        [Route("Zad5")]
        public int[] Zad5(int Od, int Do)
        {
            int[] Niz = new int[(Do-Od)/2];
            int Index = 0;
            for (int i = Od+1; i < Do; i++)
            {
                if (i % 2 == 0)
                {
                    Niz[Index] = i;
                    Index++;
                }
            }
            return Niz;
        }

        [HttpGet]
        [Route("Zad6")]
        public int[] Zad6(int Od, int Do)
        {
            int[] Niz = new int[(Do-Od)/2+(Do-Od)%2-1];
            int Index = 0;
            for (int i = Od+1; i < Do; i++)
            {
                if (i % 2 != 0)
                {
                    Niz[Index] = i;
                    Index++;
                }
            }
            return Niz;
        }

        [HttpGet]
        [Route("zad7")]
        public int Zad7(int Od, int Do)
        {
            int suma = 0;
            for (int i = Od+1; i < Do; i++)
            {
                suma += i;
            }
            return suma;
        }

        [HttpGet]
        [Route("zad8")]
        public int Zad8(int Od, int Do)
        {
            int suma = 0;
            for (int i = Od + 1; i < Do; i++)
            {
                if ((i % 3) == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }

        [HttpGet]
        [Route("zad9")]
        public int Zad9(int Od, int Do)
        {
            int suma = 0;
            for (int i = Od + 1; i < Do; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }

        [HttpGet]
        [Route("Zad10")]
        public string Zad10(int a, int b)
        {
            int[,] Niz = new int[a, b];

            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Niz[i, j] = (i + 1) * (j + 1);
                }
            }

            return JsonConvert.SerializeObject(Niz, Formatting.Indented);
        }


        [HttpGet]
        [Route("Zad11")]
        public int[] Zad11(int Broj)
        {
            int[] Niz = new int[Broj];
            for (int i = Broj; i >= 1; i--)
            {
                Niz[Broj - i] = i;
            }
            return Niz;
        }

        [HttpGet]
        [Route("zad12")]
        public bool Zad12(int Broj)
        {
            int BrojDjelitelja = 2;
            for (int i = 2; i < Broj; i++)
            {
                if (Broj % i == 0)
                {
                    BrojDjelitelja++;
                }
            }
            if (BrojDjelitelja == 2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        [HttpGet]
        [Route("SpiralnaMatrica")]
        public string GenerirajSpiralnuMatricu(int redci, int stupci)
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
                dno--;

                for (int i = dno; i >= vrh; i--)
                {
                    matrica[i, lijevo] = brojac++;
                }
                lijevo++;

                for (int i = lijevo; i <= desno; i++)
                {
                    matrica[vrh, i] = brojac++;
                }
                vrh++;

                for (int i = vrh; i <= dno; i++)
                {
                    matrica[i, desno] = brojac++;
                }
                desno--;
            }

            return JsonConvert.SerializeObject(matrica, Formatting.Indented);
        }

    }
}
