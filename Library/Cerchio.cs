using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Cerchio : Figura
    {
        double raggio;

        public Cerchio(double raggio)
        {
            Nome = "Cerchio";
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
