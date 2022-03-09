using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.ConsoleApp
{
    public class Automovel
    {
        public double kmInicial;
        public double kmFinal;
        public double consumo;

        public double ConsumoPorKm()
        {
            double kmRodado = kmFinal - kmInicial;
            double consumoKm = kmRodado / consumo;

            return consumoKm;
        }
    }
}
