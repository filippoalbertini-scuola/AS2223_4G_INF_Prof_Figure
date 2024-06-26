﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Quadrato : Figura
    {
        double lato;

        public Quadrato(double lato)
        {
            Nome = "Quadrato";
            lati = 4;

            this.lato = lato;
        }

        public override double Area()
        {
            return lato * lato;
        }

        public override double Perimetro()
        {
            return 4 * lato;
        }
    }
}
