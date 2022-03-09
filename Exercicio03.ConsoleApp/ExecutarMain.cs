using System;

namespace Exercicio03.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            Cilindro cilindro1 = new Cilindro();

            bool fecharApp = false;
            while (fecharApp == false)
            {
                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Cabecalho();

                    Console.Write("Digite a area da base do Cilindro: ");
                    string areaDoCilindroString = Console.ReadLine();
                    bool medidasValidas0 = false;
                    medidasValidas0 = double.TryParse(areaDoCilindroString, out cilindro1.areaDaBase);

                    Console.WriteLine();

                    Console.Write("Digite a altura do Cilindro: ");
                    string alturaDoCilindroString = Console.ReadLine();
                    bool medidasValidas1 = false;
                    medidasValidas1 = double.TryParse(alturaDoCilindroString, out cilindro1.altura);

                    if (medidasValidas0 == false || medidasValidas1 == false)
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

                Console.WriteLine("O volume do cilindro fica: " + cilindro1.ObterVolume());

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
            Console.WriteLine("============ Obter Volume de Cilindro ============");
            Console.WriteLine();
            Console.WriteLine("Use esse programa para obter o volume de um cilindro.");
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
