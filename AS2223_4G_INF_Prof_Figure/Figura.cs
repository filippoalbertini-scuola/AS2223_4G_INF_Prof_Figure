using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Figure
{
    public class Figura
    {
        int lati;
        protected string nome;

        public Figura()
        {
            lati = 0;
            nome = "Figura generica";   
        }

        public virtual double Area() { return 0; }
        public virtual double Perimetro() { return 0; }
    }
}
