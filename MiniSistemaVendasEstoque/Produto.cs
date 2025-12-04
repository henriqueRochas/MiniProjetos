using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaVendasEstoque
{
    internal class Produto
    {

        public Guid Id { get; set; }
        [ForeignKey("Vendedor")]
        public Guid VendedorId {get; set;}
        public Vendedor Vendedor { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public int Estoque {  get; set; }

        public Produto() { }

        public Produto(Guid id, Guid vendedorId, Vendedor vendedor, string nome, decimal preco, int estoque)
        {
            Id = id;
            VendedorId = vendedorId;
            Vendedor = vendedor;
            Nome = nome;
            Preco = preco;
            Estoque = estoque;
        }
    }
}
