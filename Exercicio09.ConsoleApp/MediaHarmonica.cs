using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    internal class MediaHarmonica
    {
        public double[] notas = new double[4];

        public double ObterMedia()
        {
            double mediaHarmonica;

            mediaHarmonica = (4 / ((1 / notas[0]) + (1 / notas[1]) + (1 / notas[2]) + (1 / notas[3])));

            return mediaHarmonica;
        }
    }
}