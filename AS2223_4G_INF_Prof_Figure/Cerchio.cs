using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Figure
{
    public class Cerchio : Figura
    {
        double raggio;

        public Cerchio(double raggio)
        {
            nome = "Cerchio";
            lati = 1;

            this.raggio = raggio;
        }
        public override double Area()
        {
            return Math.PI * raggio * raggio;
        }

        public override double Perimetro()
        {
            return 2 * Math.PI * raggio;
        }
    }
}
