using System;

namespace Exercicio02.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            Fahrenheit temperatura1 = new Fahrenheit();
            bool fecharApp = false;
            while (fecharApp == false)
            {
                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Cabecalho();

                    Console.Write("Digite a temperatura em Fahrenheit: ");
                    string temperaturaEmFahrenString = Console.ReadLine();
                    bool temperaturaValida = false;
                    temperaturaValida = double.TryParse(temperaturaEmFahrenString, out temperatura1.temperaturaFahr);

                    if (temperaturaValida == false)
                    {
                        ApresentarMensagem("Temperatura invalida, utilize somente digitos!", ConsoleColor.Red);
                        Console.Clear();

                    }
                    else
                    {
                        opcaoValida = true;
                    }
                }

                Console.WriteLine();

                Console.WriteLine("A temperatura em celsius fica: " + temperatura1.ObterCelsius());

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
            Console.WriteLine("============ Converter Fahrenheit para Celsius ============");
            Console.WriteLine();
            Console.WriteLine("Use se programa para converter a temperatura.");
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
