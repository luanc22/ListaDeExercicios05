using System;

namespace Exercicio04.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            Automovel carro1 = new Automovel();

            bool fecharApp = false;
            while (fecharApp == false)
            {
                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Cabecalho();

                    Console.Write("Digite a Kilometragem inicial do carro: ");
                    string kmInicialString = Console.ReadLine();
                    bool medidasValidas0 = false;
                    medidasValidas0 = double.TryParse(kmInicialString, out carro1.kmInicial);

                    Console.WriteLine();

                    Console.Write("Digite a Kilometragem final do carro: ");
                    string kmFinalString = Console.ReadLine();
                    bool medidasValidas1 = false;
                    medidasValidas1 = double.TryParse(kmFinalString, out carro1.kmFinal);

                    Console.WriteLine();

                    Console.Write("Digite o consumo do carro: ");
                    string consumoString = Console.ReadLine();
                    bool medidasValidas2 = false;
                    medidasValidas2 = double.TryParse(consumoString, out carro1.consumo);

                    if (medidasValidas0 == false || medidasValidas1 == false || medidasValidas2 == false)
                    {
                        ApresentarMensagem("Numeros invalidos, utilize somente digitos!", ConsoleColor.Red);
                        Console.Clear();

                    }
                    else
                    {
                        opcaoValida = true;
                    }
                }

                Console.WriteLine();

                Console.WriteLine("O carro roda {0} Km's por Litro de Combustivel", carro1.ConsumoPorKm()); ;

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
            Console.WriteLine("============ Calcular KM por Litro ============");
            Console.WriteLine();
            Console.WriteLine("Use esse programa para obter quantos kilometros o carro roda por litro.");
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
