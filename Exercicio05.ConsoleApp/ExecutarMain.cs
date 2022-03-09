using System;

namespace Exercicio05.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            Esfera bola1 = new Esfera();

            bool fecharApp = false;
            while (fecharApp == false)
            {
                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Cabecalho();

                    Console.Write("Digite o raio da esfera em metros: ");
                    string raioDaEsfera = Console.ReadLine();
                    bool medidasValidas0 = false;
                    medidasValidas0 = double.TryParse(raioDaEsfera, out bola1.raio);

                    Console.WriteLine();

                    if (medidasValidas0 == false)
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

                Console.WriteLine("A esfera de raio {0} tem volume de {1} metros.", bola1.raio, bola1.ObterVolume());

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
            Console.WriteLine("============ Calcular Volume da Esfera ============");
            Console.WriteLine();
            Console.WriteLine("Use esse programa para obter o volume da esfera.");
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
