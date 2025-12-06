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

        public Loja()
        {
            _vendedores = new List<Vendedor>();
            _compradores = new List<Comprador>();
            _produtos = new List<Produto>();
            _pedidos = new List<Pedido>();
        }
        public void CadastrarVendedor(string nome)
        {

            Vendedor vendedor = new Vendedor();
            vendedor.Nome = nome;
            _vendedores.Add(vendedor);
        }

        public void CadastrarComprador(string nome, decimal saldo)
        {

            Comprador comprador = new Comprador();
            comprador.Nome = nome; comprador.Saldo = saldo;
            _compradores.Add(comprador);
        }

        public List<Vendedor> ListaVendedores()
        {
            return _vendedores;
        }

        public List<Comprador> ListaCompradores()
        {
            return _compradores;
        }

        public string CadastrarProduto(Guid idProduto, Guid idVendedor, string nomeProduto, decimal preco, int estoque)
        {

            Produto produto = new Produto();
            if (!_vendedores.Any(a => a.Id == idVendedor))
            {
                return("Erro vendedor não encontrado");
            }
            else
            {
                produto.Id = idProduto; produto.Nome = nomeProduto;  produto.Preco = preco; produto.Estoque = estoque; produto.VendedorId = idVendedor;
                _produtos.Add(produto);
            }
            return ("Produto cadastrado com sucesso");
        }

        public List<Produto> ListaProdutosDisponiveis()
        {
            foreach (var item in _produtos)
            {
                if (item.Estoque > 0)
                {
                    Console.WriteLine($" Id vendedor{item.VendedorId}");
                    Console.WriteLine($" Nome produto:{item.Nome} ");
                    Console.WriteLine($" Preço{item.Preco} ");
                    Console.WriteLine($" Estoque{item.Estoque} ");

                }
            }
            return _produtos;
        }

        public string Comprar(Guid compradorId, Guid produtoId)
        {
            var verifComprador = _compradores.FirstOrDefault(r => r.Id == compradorId);
            var verifProduto = _produtos.FirstOrDefault(r => r.Id == produtoId);
            if (verifComprador == null)
            {
                return ("Comprador não encontrado");
            }
            if (verifProduto == null)
            {
                return ("Produto não encontrado");
            }

            var verifVendedor = _vendedores.FirstOrDefault(r => r.Id == verifProduto.VendedorId);

            if (verifVendedor == null)
            {
                return ("Vendedor não encontrado");
            }

            if (verifProduto.Estoque <= 0)
            {
                return ("Produtos esgostado");
            }

            if (verifComprador.Saldo < verifProduto.Preco)
            {
                return ("Saldo Insuficiente");
            }

            verifComprador.Saldo -= verifProduto.Preco;
            verifVendedor.Saldo += verifProduto.Preco;
            verifProduto.Estoque -= 1;

            Pedido pedido = new Pedido();
            pedido.Id = verifProduto.Id;
            pedido.CompradorId = verifComprador.Id;
            pedido.Date = DateTime.Now;
            _pedidos.Add(pedido);

            return ("Sucesso");
        }
    }
}
