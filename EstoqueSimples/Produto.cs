using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstoqueSimples
{
    internal class Produto
    {
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Preco { get; set; }

        public Produto() { }

        public Produto(string nome, int quantidade, decimal preco)
        {
            Nome = nome;
            Quantidade = quantidade;
            Preco = preco;
        }

        public void MenuEstoque()
        {
            int opcao;
            do
            {


                Console.WriteLine("==_==_==_ Menu Estoque _==_==_==");
                Console.WriteLine();

                Console.WriteLine("1) Adicionar novo produto");
                Console.WriteLine("2) Dar entrada no estoque");
                Console.WriteLine("3) Dar saída no estoque");
                Console.WriteLine("4) Listas todos os produtos");
                Console.WriteLine("5) Remover produtos");
                Console.WriteLine("0) Sair");
                Console.WriteLine();

                if(!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente");
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarProduto();
                        break;
                    case 2:
                        EntradaEstoque();
                        break;
                    case 3:
                        SaidaEstoque();
                        break;
                    case 4:
                        ListarProdutos();
                        break;
                    case 5:
                        RemoverProdutos();
                        break;
                    case 0:
                        break;
                }
            } while (opcao != 0);

        }
        List<Produto> produtosLista = new List<Produto>();

        public void AdicionarProduto()
        {
            Produto produto = new Produto();

            Console.WriteLine($"==_==_==_ Adicionar Produtos _==_==_==");
            Console.WriteLine();

            Console.Write("Informe o nome do produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Informe a quatidade do produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());


            Console.Write("Informe o preço do produto: ");
            produto.Preco = decimal.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            foreach (var adicionarLista in produtosLista)
            {
                if (produto.Nome == adicionarLista.Nome)
                {
                    Console.WriteLine("Esse produto já existe. Insira uma novo produto.");
                    return;
                }
            }

            produtosLista.Add(produto);
        }

        public void EntradaEstoque()
        {
            Produto consultaProduto = null;

            Console.WriteLine($"==_==_==_ Entrada de produtos _==_==_==");
            Console.WriteLine();

            Console.Write("Qual o nome do produto que deseja dar entrada? ");
            string nomeEntradaProduto = Console.ReadLine().ToLower();

            foreach (var verifProduto in produtosLista)
            {
                if (verifProduto.Nome.ToLower() == nomeEntradaProduto)
                {
                    consultaProduto = verifProduto;
                    break;
                }
            }

            if (consultaProduto != null)
            {
                Console.Write("Informe a quantidade que quer adicionar? ");
                int quantidadeEntradaProduto = int.Parse(Console.ReadLine());
                consultaProduto.Quantidade += quantidadeEntradaProduto;
                Console.WriteLine($"Produto: {consultaProduto.Nome} | Preço: {consultaProduto.Preco} | Estoque: {consultaProduto.Quantidade} unidades");
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }
        }

        public void SaidaEstoque()
        {
            Produto consultaProduto = null;
            Console.WriteLine($"==_==_==_ Saída de produtos _==_==_==");
            Console.WriteLine();

            Console.Write("Qual o nome do produto que deseja dar saída? ");
            string nomeSaidaProduto = Console.ReadLine().ToLower();

            foreach (var verifProduto in produtosLista)
            {
                if (verifProduto.Nome.ToLower() == nomeSaidaProduto)
                {
                    consultaProduto = verifProduto;
                    break;
                }
            }

            if (consultaProduto != null)
            {
                Console.Write("Informe a quantidade que quer subtrair? ");
                int quantidadeSaidaProduto = int.Parse(Console.ReadLine());

                if (quantidadeSaidaProduto > consultaProduto.Quantidade)
                {
                    Console.WriteLine($"Não é possivel subtrair e valor, estoque atual é {consultaProduto.Quantidade}");
                    return;
                }
                else
                {
                    consultaProduto.Quantidade -= quantidadeSaidaProduto;
                    Console.WriteLine($"Produto: {consultaProduto.Nome} | Preço: {consultaProduto.Preco} | Estoque: {consultaProduto.Quantidade} unidades");
                }
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }
        }

        public void ListarProdutos()
        {
            decimal calculo = 0;
            decimal total = 0;
            Console.WriteLine($"==_==_==_ Produtos cadastrados _==_==_==");
            Console.WriteLine();

            foreach (var produtosListados in produtosLista)
            {
                calculo = produtosListados.Quantidade * produtosListados.Preco;
                Console.WriteLine($"Produto: {produtosListados.Nome} (Preço: R${produtosListados.Preco}) - Estoque: {produtosListados.Quantidade} un");
                total += calculo;
            }
            Console.WriteLine($"TOTAL R${total.ToString("F2")}");
        }

        public void RemoverProdutos()
        {
            Produto remover = null;
            Console.WriteLine("Informe o produto que deseja excluir.");
            string removerProduto = Console.ReadLine();

            foreach (var removerItem in produtosLista)
            {
                if (removerItem.Nome.Contains(removerProduto))
                {
                    remover = removerItem;
                    break;
                }
            }

            if (remover != null)
            {
                produtosLista.Remove(remover);
                Console.WriteLine("Produto removido.");
            }
            else
            {
                Console.WriteLine("Produto não encontrado");
            }

        }
    }
}
