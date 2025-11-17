using System;
using System.Security.Cryptography.X509Certificates;

namespace AdivinhandoNumeroSalvandoTxt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            List<Pontuacao> guardarPlacar = new List<Pontuacao>();

            GerenciadorPlacar gerenciadorPlacar = new GerenciadorPlacar();
            Jogador jogador = new Jogador();

            guardarPlacar = (gerenciadorPlacar.CarregarPlacar());

            do
            {
                Console.WriteLine("\\\\\\\\ MENU ////////");
                Console.WriteLine();

                Console.WriteLine("1) JOGAR ");
                Console.WriteLine("2) VER HALL DA FAMA");
                Console.WriteLine("0) SAIR");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opcão inválida, tente novamente.");
                }

                switch (opcao)
                {
                    case 1:
                        jogador.Jogar(jogador.NumerosAleatorios(), guardarPlacar);
                        gerenciadorPlacar.SalvarPlacar(guardarPlacar);

                        break;
                    case 2:
                        guardarPlacar.Sort((p1, p2) => p1.Tentativas.CompareTo(p2.Tentativas));
                        foreach (var listarPlacar in guardarPlacar)
                        {
                            Console.WriteLine($"Nome: {listarPlacar.Nome} Placar: {listarPlacar.Tentativas}");
                        }
                        break;
                    case 0:
                        break;
                }
            } while (opcao != 0);
        }
    }
}



