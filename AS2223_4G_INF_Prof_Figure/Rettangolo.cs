using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Figure
{
    public class Rettangolo : Figura
    {
        double b;
        double altezza;
        public Rettangolo(double b, double altezza)
        {
            nome = "Rettangolo";
            lati = 4;

            this.b = b;
            this.altezza = altezza;
        }
        public override double Area()
        {
            return b * altezza;
        }

        public override double Perimetro()
        {
            return 2*b + 2 * altezza;
        }
    }
}
