using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.ConsoleApp
{
    public class Esfera
    {
        public double raio;
        public double pi = 3.14;

        public double ObterVolume()
        {
            double volume = (4 * (raio*raio*raio) * pi) / 3;

            return volume;
        }

    }
}
