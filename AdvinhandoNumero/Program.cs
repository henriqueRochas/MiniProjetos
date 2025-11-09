
using System.Data;

namespace AdvinhandoNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------- JOGO DO ADIVINHE O NÚMERO --------");
            Console.WriteLine();

            ConfigJogo jogo = new ConfigJogo();
            

            while(true)
            {
                jogo.Jogador(jogo.NivelDificuldade());
                Console.WriteLine("Gostaria de continuar a jogar? (S/N)");
                string continuar = Console.ReadLine();

                if (continuar.Contains("S"))
                {
                    continue;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
