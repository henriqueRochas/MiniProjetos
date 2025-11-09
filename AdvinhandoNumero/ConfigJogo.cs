using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AdvinhandoNumero
{
    internal class ConfigJogo
    {
        public ConfigJogo() { }

        Random random = new Random();

        public int NivelDificuldade()
        {
            int num = 0;
            int nivelDificuldade;
            do
            {
                Console.WriteLine("Escolha o nível de dificuldade: ");
                Console.WriteLine("1) FÁCIL");
                Console.WriteLine("2) NORMAL");
                Console.WriteLine("3) DIFÍCIL");
                Console.WriteLine();

                string dificuldade = Console.ReadLine();

                bool convertDificuldade = int.TryParse(dificuldade, out nivelDificuldade);

                if (convertDificuldade == false)
                {
                    Console.WriteLine("Entrada invalida, tente novamente");
                    continue;
                }
            }

            while (nivelDificuldade < 1 || nivelDificuldade > 3);

            switch (nivelDificuldade)
            {
                case 1:
                    num = random.Next(1, 51);
                    break;
                case 2:
                    num = random.Next(1, 101);
                    break;
                case 3:
                    num = random.Next(1, 501);
                    break;
                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
            return num;
        }

        public void Jogador(int num)
        {
            string palpite = "";
            int guardarPalpite = 0;
            bool convertPalpite;
            int tentativas = 0;

            while (guardarPalpite != num)
            {
                palpite = (Console.ReadLine());
                convertPalpite = int.TryParse(palpite, out guardarPalpite);

                if (convertPalpite == false)
                {
                    Console.WriteLine("Entrada invalida, tente novamente");
                    continue;
                }

                if (guardarPalpite > num)
                {
                    Console.WriteLine("Muito alto, tente novamente com um número menor!");
                    tentativas++;
                }
                else if (guardarPalpite < num)
                {
                    Console.WriteLine("Muito baixo, tente novamente com um número maior!");
                    tentativas++;
                }

            }
            if (num == guardarPalpite)
            {
                Console.WriteLine($"Número sorteado é {num}");
                Console.WriteLine("PARABÉNS, VOCÊ ACERTOU!");
                Console.WriteLine($"Número de tentativas {tentativas}");
                Console.WriteLine();
            }
        }
        
    }
}
