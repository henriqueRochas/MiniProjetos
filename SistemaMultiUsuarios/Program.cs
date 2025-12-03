namespace SistemaMultiUsuarios
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            GestorPerfis gestorPerfis = new GestorPerfis();
            PerfilUsuario perfilUsuario = new PerfilUsuario();
            do
            {
                Console.WriteLine("Menu Login");
                Console.WriteLine();

                Console.WriteLine("1) Login");
                Console.WriteLine("2) Listar usuários");
                Console.WriteLine("0) Sair");

                while(!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }

                switch (opcao)
                {
                    case 1:
                        Console.Write("Informe o nome o seu nome: ");
                        perfilUsuario.NomeUsuario = Console.ReadLine();
                        perfilUsuario = gestorPerfis.Login(perfilUsuario.NomeUsuario);

                        int opcao2;
                        do
                        {
                            Console.WriteLine($"Bem vindo, {perfilUsuario.NomeUsuario}!!");
                            Console.WriteLine();

                            Console.WriteLine("1) Mudar Tema");
                            Console.WriteLine("0) Deslogar");

                            while (!int.TryParse(Console.ReadLine(), out opcao2))
                            {
                                Console.WriteLine("Valor inválido, tente novamente.");
                            }

                            switch (opcao2)
                            {
                                case 1:
                                    Console.Write("Informe o tema que deseja: ");
                                    perfilUsuario.Tema = Console.ReadLine();
                                    gestorPerfis.Salvar(perfilUsuario.NomeUsuario, perfilUsuario.Tema);
                                    Console.WriteLine("Tema atualizado!");
                                    break;
                                case 0:
                                    break;
                            }
                        } while (opcao2 != 0);
                        break;
                    case 2:
                        var teste = gestorPerfis.ListarTodosUsuarios();
                        foreach (var item in teste)
                        {
                            Console.WriteLine(item);
                        }
                        break;
                    case 0:
                        break;
                }
            }while (opcao != 0);
        }
    }
}
