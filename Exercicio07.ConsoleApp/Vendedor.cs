using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio07.ConsoleApp
{
    public class Vendedor
    {
        public double salarioBase;
        public double totalDeVendas;
        public double percentualDeComissao;

        public double ObterSalarioTotal()
        {
            double salarioTotal;

            percentualDeComissao = percentualDeComissao / 100;

            salarioTotal = salarioBase + (percentualDeComissao * totalDeVendas);

            return salarioTotal;
        }
    }
}
