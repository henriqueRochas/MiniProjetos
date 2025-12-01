using System.Reflection.Metadata;

namespace GerenciadorPersonagensRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            GestorFicha gestorFicha = new GestorFicha();

            do
            {
                Console.WriteLine("Criando Personagens");
                Console.WriteLine();

                Console.WriteLine("1 - Criar Personagem");
                Console.WriteLine("2 - Adicionar itens na bolsa");
                Console.WriteLine("3 - Estatisticas personagem");
                Console.WriteLine("0 - Sair");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }

                switch (opcao)
                {
                    case 1:
                        Personagem personagem = new Personagem();
                        Atributos atributos = new Atributos();
                        Console.Write("Nome: ");
                        personagem.Nome = Console.ReadLine();

                        Console.Write("Nivel: ");
                        personagem.Nivel = int.Parse(Console.ReadLine());

                        Console.Write("Classe: ");
                        personagem.Classe = Console.ReadLine();

                        Console.Write("Força: ");
                        atributos.Forca = int.Parse(Console.ReadLine());

                        Console.Write("Destreza: ");
                        atributos.Destreza = int.Parse(Console.ReadLine());

                        Console.Write("Inteligência: ");
                        atributos.Inteligencia = int.Parse(Console.ReadLine());

                        personagem.Estatistica.Add(atributos);

                        gestorFicha.CriarPersonagem(personagem);
                        break;
                    case 2:
                        {
                            Item item = new Item();

                            Console.Write("Nome do personagem: ");
                            string nome = Console.ReadLine();

                            Console.Write("Nome do item: ");
                            item.Nome = Console.ReadLine();

                            Console.Write("Peso do item: ");
                            item.Peso = double.Parse(Console.ReadLine());

                            Console.Write("Valor do item: ");
                            item.Valor = int.Parse(Console.ReadLine());

                            gestorFicha.AdicionarInventario(nome, item);
                        }
                        break;
                    case 3:
                        Console.Write("Nome do personagem: ");
                        string nomeConsulta = Console.ReadLine();
                        
                        Personagem carregarPersonagem = gestorFicha.CarregarPersonagem(nomeConsulta);
                        if (carregarPersonagem != null)
                        {
                            Console.WriteLine($@"Nome: {carregarPersonagem.Nome} Nivel: {carregarPersonagem.Nivel} Classe: {carregarPersonagem.Classe}");

                            foreach (var item in carregarPersonagem.Estatistica)
                            {
                                Console.WriteLine($" Força: {item.Forca} Destreza: {item.Destreza} Inteligência: {item.Inteligencia}");
                            }

                            foreach (var item in carregarPersonagem.Inventario)
                            {
                                Console.WriteLine($" Nome do item: {item.Nome} Peso do item: {item.Peso} Valor do item: {item.Valor}");
                            }
                        }
                        break;
                    case 0:
                        break;
                }
            }while (opcao != 0);

        }
    }
}
