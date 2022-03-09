using System;

namespace Exercicio08.ConsoleApp
{
    internal class ExecutarMain
    {
        static void Main(string[] args)
        {
            MediaHarmonica media1 = new MediaHarmonica();

            bool fecharApp = false;
            while (fecharApp == false)
            {
                bool opcaoValida = false;

                while (opcaoValida == false)
                {
                    Cabecalho();

                    bool[] notaValida = new bool[4];
                    string[] notaString = new string[4];

                    for (int i = 0; i < media1.notas.Length; i++)
                    {

                        Console.Write("Digita a nota {0} do aluno: ", i + 1);
                        notaString[i] = Console.ReadLine();
                        notaValida[i] = double.TryParse(notaString[i], out media1.notas[i]);


                        if (notaValida[i] == false)
                        {
                            ApresentarMensagem("Respostas invalidas, utilize somente digitos!", ConsoleColor.Red);
                            i--;
                            Console.Clear();
                            Cabecalho();
                            continue;

                        }
                        else
                        {
                            opcaoValida = true;
                        }
                    }
                }

                Console.WriteLine();

                Console.WriteLine("O media harmonica do aluno fica: " + media1.ObterMedia());

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
            Console.WriteLine("============ Calcular Media Harmonica ============");
            Console.WriteLine();
            Console.WriteLine("Usa esse programa para calcular a media harmonica de um aluno.");
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