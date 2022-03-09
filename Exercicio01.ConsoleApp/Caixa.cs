using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.ConsoleApp
{
    public class Caixa
    {
        public double altura;
        public double largura;
        public double comprimento;

        public double ObterVolume()
        {
            double volume = altura * largura * comprimento;

            return volume;
        }
    }
}
