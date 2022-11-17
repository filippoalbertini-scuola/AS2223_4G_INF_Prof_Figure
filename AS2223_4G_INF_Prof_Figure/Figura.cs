using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Figure
{
    public class Figura
    {
        protected int lati;
        public string Nome { get; set; }

        public Figura()
        {
            lati = 0;
            Nome = "Figura generica";   
        }

        public virtual double Area() { return 0; }
        public virtual double Perimetro() { return 0; }
    }
}
