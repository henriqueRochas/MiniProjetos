using System.ComponentModel;

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
                                    foreach(var listaVendedores in loja.ListaVendedores())
                                    {
                                        Console.WriteLine($"Id: {listaVendedores.Id} Nome: {listaVendedores.Nome}");
                                        
                                    }
                                    Console.WriteLine();
                                    Guid idProduto = Guid.Parse(Console.ReadLine());
                                    Guid IdVendedor = Guid.Parse(Console.ReadLine());
                                    string nomeProduto = Console.ReadLine();
                                    decimal preco = decimal.Parse(Console.ReadLine());
                                    int quantidade = int.Parse(Console.ReadLine());
                                    loja.CadastrarProduto(idProduto,IdVendedor,nomeProduto,preco,quantidade);
                                    break;
                                case 0:
                                    break;
                            }
                        } while (opcaoCadastro != 0);
                        break;
                    case 2:
                        int opcaoListaCadastradas;
                        do
                        {
                            Console.WriteLine("Lista de cadastros");
                            Console.WriteLine();

                            Console.WriteLine("1) Vendedores");
                            Console.WriteLine("2) Compradores");
                            Console.WriteLine("3) Produtos");
                            Console.WriteLine("0) Voltar ao menu");

                            while(!int.TryParse(Console.ReadLine(), out opcaoListaCadastradas))
                            {
                                Console.WriteLine("Valor inválido, tente novamente");
                            }

                            switch(opcaoListaCadastradas)
                            {
                                case 1:
                                    var listandoVend = loja.ListaVendedores();
                                    foreach (var vendedores in listandoVend)
                                    {
                                        Console.WriteLine($"Id: {vendedores.Id} Nome: {vendedores.Nome} Saldo: {vendedores.Saldo} ");
                                    }
                                    break;
                                case 2:
                                    var listandoCompradores = loja.ListaCompradores();
                                    foreach (var compradores in listandoCompradores)
                                    {
                                        Console.WriteLine($"Id: {compradores.Id} Nome: {compradores.Nome} Saldo: {compradores.Saldo} ");
                                    }
                                    break;
                                case 3:
                                    var listandoProd = loja.ListaProdutosDisponiveis();
                                    foreach (var produtos in listandoProd)
                                    {
                                        Console.WriteLine($"Vendedor: {produtos.VendedorId} Id produto: {produtos.Id} Nome do produto: {produtos.Nome} Preco:{produtos.Preco} Estoque: {produtos.Estoque}");
                                    }
                                    break;
                                case 0:
                                    break;
                            }

                        }while(opcaoListaCadastradas != 0);
                        break;
                    case 3:
                        Guid compradorId= Guid.Parse(Console.ReadLine());
                        Guid produtoId = Guid.Parse(Console.ReadLine());
                        loja.Comprar(compradorId, produtoId);
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
