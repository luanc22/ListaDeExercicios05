using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio06.ConsoleApp
{
    internal class Celsius
    {
        public double temperaturaCels;

        public double ObterFahrenheit()
        {
            double temperaturaFahr;

            temperaturaFahr = (temperaturaCels * (9 / 5)) + 32;

            return temperaturaFahr;
        }
    }
}
