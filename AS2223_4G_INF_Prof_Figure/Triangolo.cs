using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Figure
{
    public class Triangolo : Figura
    {
        double b;
        double altezza;
        public Triangolo(double b, double altezza)
        {
            nome = "Triangolo";

            this.b = b;
            this.altezza = altezza;
        }
    }
}
