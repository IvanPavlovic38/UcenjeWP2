using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UcenjeCS.StreamingApp.Model;

namespace UcenjeCS.StreamingApp
{
    internal class ObradaTrazi
    {
        public List<Serija> Serije { get; }

        public ObradaTrazi()
        {
            Serije = new List<Serija>();
            if (Pomocno.dev)
            {
                TestniPodaci();
            }
        }

        public void PrikaziIzbornik()
        {
            Console.WriteLine("Trazilica");
        }
    }
}
