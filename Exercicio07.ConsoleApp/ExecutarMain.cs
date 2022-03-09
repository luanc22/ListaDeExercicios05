using System;

namespace Exercicio07.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            Vendedor vendedor1 = new Vendedor();
            bool fecharApp = false;
            while (fecharApp == false)
            {
                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Cabecalho();

                    Console.Write("Digite o salario base do vendedor: ");
                    string salarioBaseString = Console.ReadLine();
                    bool salarioValido0 = false;
                    salarioValido0 = double.TryParse(salarioBaseString, out vendedor1.salarioBase);

                    Console.Write("Digite o total de vendas (em dinheiro) do vendedor: ");
                    string totalDeVendasString = Console.ReadLine();
                    bool salarioValido1 = false;
                    salarioValido1 = double.TryParse(totalDeVendasString, out vendedor1.totalDeVendas);

                    Console.Write("Digite a porcentagem de comissao do vendedor: ");
                    string comissaoString = Console.ReadLine();
                    bool salarioValido2 = false;
                    salarioValido2 = double.TryParse(comissaoString, out vendedor1.percentualDeComissao);

                    if (salarioValido0 == false || salarioValido1 == false || salarioValido2 == false)
                    {
                        ApresentarMensagem("Respostas invalidas, utilize somente digitos!", ConsoleColor.Red);
                        Console.Clear();

                    }
                    else
                    {
                        opcaoValida = true;
                    }
                }

                Console.WriteLine();

                Console.WriteLine("O salario total do vendedor fica: " + vendedor1.ObterSalarioTotal());

                Console.WriteLine();

                bool opcaoValidaParaFechar = false;
                while (opcaoValidaParaFechar == false)
                {
                    Console.WriteLine("Deseja realizar o calculo novamente com outro valor? Utilize 'Sim' ou 'Nao'");
                    Console.Write("Opcao escolhida: ");
                    string opcaoEscolhida = Console.ReadLine();
                    opcaoEscolhida = opcaoEscolhida.ToUpper();

                    if (opcaoEscolhida == "SIM")
                    {
                        Console.Clear();
                        opcaoValidaParaFechar = true;
                    }
                    else if (opcaoEscolhida == "NAO")
                    {
                        fecharApp = true;
                        opcaoValidaParaFechar = true;
                    }
                    else
                    {
                        ApresentarMensagem("Opcao invalida!", ConsoleColor.Red);
                        Console.Clear();
                        Cabecalho();
                        continue;
                    }
                }
            }
        }


        static void Cabecalho()
        {
            Console.WriteLine("============ Calcular salario total de funcionario ============");
            Console.WriteLine();
            Console.WriteLine("Usa esse programa para calcular o salario total de um funcionario.");
            Console.WriteLine();
            Console.WriteLine("===========================================================");
            Console.WriteLine();
        }

        static void ApresentarMensagem(string mensagem, ConsoleColor cor)
        {
            Console.ForegroundColor = cor;
            Console.WriteLine();
            Console.WriteLine(mensagem);
            Console.ResetColor();
            Console.WriteLine();
            Console.Write("Aperte ENTER para prosseguir.");
            Console.ReadLine();
        }
    }
    
}
