using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.ConsoleApp
{
    internal class Fahrenheit
    {
        public double temperaturaFahr;

        public double ObterCelsius()
        {
            double temperaturaCelsius;

            temperaturaCelsius = (temperaturaFahr - 32) / 1.8;

            return temperaturaCelsius;
        }

    }
}
