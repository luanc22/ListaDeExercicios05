using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    public class LataDeOleo
    {
        public double areaDaBase;
        public double altura;

        public double ObterVolume()
        {
            double volumeDoCilindro;
            double aa;

            volumeDoCilindro = areaDaBase * altura;

            return volumeDoCilindro;
        }
    }
}
