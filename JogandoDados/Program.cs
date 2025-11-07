using System.Reflection.Metadata.Ecma335;
using System.Xml;

namespace JogandoDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random dado = new Random();
            int vitoriasj1 = 0;
            int vitoriasj2 = 0;
            int empate = 0;
            int j1 = 0;
            int j2 = 0;

            Console.Write("Escolha a quantidade de rodadas desejadas entre 1 a 5: ");
            int qtdRodadas = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("-------- Informe os nomes dos jogadores --------");
            Console.WriteLine();

            Console.Write("Nome do 1º Jogador(a): ");
            string nomej1 = Console.ReadLine();

            Console.Write("Nome da 2º Jogadora(o): ");
            string nomej2 = Console.ReadLine();
            Console.WriteLine();

            for (int i = 1; i <= qtdRodadas; i++)
            {
                Console.WriteLine($"-------- {i}º Rodada  --------");
                Console.WriteLine();
                j1 = dado.Next(1, 7);
                Console.WriteLine($"{nomej1} jogou e tirou: {j1}");

                j2 = dado.Next(1, 7);
                Console.WriteLine($"{nomej2} jogou e tirou: {j2}");
                Console.WriteLine();

                if (j1 > j2)
                {
                    Console.WriteLine($"{nomej1} ganhou a {i}º rodada.");
                    vitoriasj1++;
                }
                else if (j2 > j1)
                {
                    Console.WriteLine($"{nomej2} ganhou a {i}º rodada.");
                    vitoriasj2++;
                }
                else
                {
                    empate++;
                    Console.WriteLine($"{nomej1} e {nomej2} empataram {i}º rodada.");
                }

                Console.WriteLine("--------PLACAR--------");
                Console.WriteLine();
                Console.WriteLine($"{nomej1}: {vitoriasj1}");
                Console.WriteLine($"{nomej2}: {vitoriasj2}");

            }
            if (vitoriasj1 > vitoriasj2)
            {
                Console.WriteLine($"VECEDEDOR É {nomej1} por {vitoriasj1} pontos");
            }
            else if (vitoriasj2 > vitoriasj1)
            {
                Console.WriteLine($"VECEDEDOR É {nomej2} por {vitoriasj2} pontos");
            }
            else
            {
                Console.WriteLine($"{nomej1} e {nomej2} EMPATARAM!!!!");
            }
        }

    }
}
