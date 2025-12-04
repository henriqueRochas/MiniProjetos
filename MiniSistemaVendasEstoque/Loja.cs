using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaVendasEstoque
{
    internal class Loja
    {
        private List<Vendedor> _vendedores;
        private List<Comprador> _compradores;
        private List<Produto> _produtos;
        private List<Pedido> _pedidos;

        public void CadastrarVendedor(string nome)
        {
            _vendedores = new List<Vendedor>();
            Vendedor vendedor = new Vendedor();
            vendedor.Nome = nome;
            _vendedores.Add(vendedor);
        }

        public void CadastrarComprador(string nome, decimal saldo)
        {
            _compradores = new List<Comprador>();
            Comprador comprador = new Comprador();
            comprador.Nome = nome; comprador.Saldo = saldo;
            _compradores.Add(comprador);
        }

        public List<Vendedor> ListaVendedores()
        {
            return _vendedores;
        }

        public List <Comprador> Compradores()
        {
            return _compradores;
        }

        public string CadastrarProduto(Guid idVendedor, string nomeProduto, decimal preco, int estoque)
        {
            _produtos = new List<Produto>();
            Produto produto = new Produto();
            if (_vendedores.Any( a => a.Id != idVendedor))
            {
                Console.WriteLine("Erro vendedor não encontrado");
            }
            else
            {
                produto.Nome = nomeProduto; produto.Preco = preco; produto.Estoque = estoque; produto.VendedorId = idVendedor;
                _produtos.Add(produto);
            }
            return ("Produto cadastrado com sucesso");
        }

        public List<Produto> ListaProdutosDisponiveis()
        {
            _produtos = new List<Produto>();
            Produto produto = new Produto();
            if (produto.Estoque > 0)
            {
                foreach (var item in _produtos)
                {
                    Console.WriteLine($" Id vendedor{item.VendedorId}");
                    Console.WriteLine($" Nome produto:{item.Nome} ");
                    Console.WriteLine($" Preço{item.Preco} ");
                    Console.WriteLine($" Estoque{item.Estoque} ");

                }
            }
            return _produtos.ToList();
        }

        public string Comprar(Guid compradorId, Guid produtoId)
        {
            _compradores = new List<Comprador>();
            Comprador comprador = new Comprador();

        }
    }
}
