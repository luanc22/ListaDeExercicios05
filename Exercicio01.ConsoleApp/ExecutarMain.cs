using System;

namespace Exercicio01.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            
            Caixa caixa1 = new Caixa();

            bool fecharApp = false;
            while (fecharApp == false)
            {
                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Cabecalho();

                    Console.Write("Digite a altura da caixa: ");
                    string alturaCaixaString = Console.ReadLine();
                    bool medidasValidas0 = false;
                    medidasValidas0 = double.TryParse(alturaCaixaString, out caixa1.altura);

                    Console.WriteLine();

                    Console.Write("Digite a largura da caixa: ");
                    string larguraCaixaString = Console.ReadLine();
                    bool medidasValidas1 = false;
                    medidasValidas1 = double.TryParse(larguraCaixaString, out caixa1.largura);

                    Console.WriteLine();

                    Console.Write("Digite a largura da caixa: ");
                    string comprimentoCaixa = Console.ReadLine();
                    bool medidasValidas2 = false;
                    medidasValidas2 = double.TryParse(comprimentoCaixa, out caixa1.comprimento);

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

                Console.WriteLine("O volume da caixa fica: " + caixa1.ObterVolume());

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
            Console.WriteLine("============ Obter Volume da Caixa ============");
            Console.WriteLine();
            Console.WriteLine("Use esse programa para obter o volume de uma caixa.");
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
