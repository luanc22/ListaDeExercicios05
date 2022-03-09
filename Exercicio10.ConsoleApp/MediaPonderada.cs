using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio08.ConsoleApp
{
    internal class MediaPonderada
    {
        public double[] notas = new double[2];
        public double[] pesos = new double[2];  

        public double ObterMedia()
        {
            double mediaPonderada;

            mediaPonderada = (notas[0] * pesos[0] + notas[1] * pesos[1]) / (pesos[0] + pesos[1]);

            return mediaPonderada;
        }
    }
}