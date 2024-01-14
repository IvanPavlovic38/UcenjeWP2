using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("V02")]
    public class V02ZimskoVjezbanje:ControllerBase
    {
        [HttpGet]
        [Route("zad1")]
        public int Zad1( int brojevi)
        {
            int zbroj=0;

            for (int i = 0; i < 100; i++)
            {
                zbroj = zbroj + i + 1;
            }

            return zbroj;  
        }


        [HttpGet]
        [Route("zad3")]
        public int Zad3(int brojevi)
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
            for(int i = 1; i <= broj; i++)
            {
                suma += i;
            }
            return suma;
        }

        [HttpGet]
        [Route("zad7")]
        public int Zad7(int Od, int Do)
        {
            int suma = 0;
            for (int i = Od; i <= Do; i++)
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
            for (int i = Od; i <= Do; i++)
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
            for (int i = Od; i <= Do; i++)
            {
                if ((i % 3) == 0 && (i % 5) == 0)
                {
                    suma += i;
                }
            }
            return suma;
        }







    }
}
