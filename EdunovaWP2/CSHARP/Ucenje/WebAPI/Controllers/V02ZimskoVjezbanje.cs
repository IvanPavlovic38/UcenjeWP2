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

        


       
    }
}
