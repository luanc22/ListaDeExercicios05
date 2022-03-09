using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.ConsoleApp
{
    public class Cilindro
    {
        public double areaDaBase;
        public double altura;

        public double ObterVolume()
        {
            double volumeDoCilindro;

            volumeDoCilindro = areaDaBase * altura;

            return volumeDoCilindro;
        }
    }
}
