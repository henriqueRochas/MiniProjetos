namespace MiniSistemaVendasEstoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Loja loja = new Loja();
            int opcao;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine();

                Console.WriteLine("1) Cadastrar");
                Console.WriteLine("2) Listas de cadastro");
                Console.WriteLine("3) Comprar");
                Console.WriteLine("4) Ver saldo");
                Console.WriteLine("0) Sair");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }

                switch (opcao)
                {
                    case 1:
                        int opcaoCadastro;
                        do
                        {
                            Console.WriteLine("CADASTROS");
                            Console.WriteLine();

                            Console.WriteLine("1) Cadastrar Vendedor");
                            Console.WriteLine("2) Cadastrar Comprador");
                            Console.WriteLine("3) Cadastrar Produto");
                            Console.WriteLine("0) Voltar ao Menu");

                            while(!int.TryParse(Console.ReadLine(),out opcaoCadastro))
                            {
                                Console.WriteLine("Valor inválido, tente novamente.");
                            }

                            switch (opcaoCadastro)
                            {
                                case 1:
                                    string nomeVendedor = Console.ReadLine();
                                    loja.CadastrarVendedor(nomeVendedor);
                                    break;
                                case 2:
                                    string nomeComprador = Console.ReadLine();
                                    decimal saldoComprador = decimal.Parse(Console.ReadLine());
                                    loja.CadastrarComprador(nomeComprador, saldoComprador);
                                    break;
                                case 3:
                                    break;
                                case 0:
                                    break;
                            }
                        } while (opcaoCadastro != 0);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 0:
                        break;
                }

            } while (opcao != 0);

        }
    }
}
