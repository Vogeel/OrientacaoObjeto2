using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoObjeto2.ConsoleApp
{
    internal class GrausFahrenheit
    {
        public double F;
        

        public double Convertido()
        {
            double ValorFinal = (F - 32) / 1.8;
            return ValorFinal;
        }
    }
}
