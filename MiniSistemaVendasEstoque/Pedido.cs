using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaVendasEstoque
{
    internal class Pedido
    {
        public Guid Id { get; set; }

        [ForeignKey("Comprador")]
        public Guid CompradorId { get; set; }

        [ForeignKey("Produto")]
        public Guid ProdutoId { get; set; }

        public Comprador Comprador { get; set; }
        public Produto Produto { get; set; }
        public DateTime Date { get; set; }

        public Pedido() { }

        public Pedido(Guid id, Guid compradorId, Guid produtoId, Comprador comprador, Produto produto, DateTime date)
        {
            Id = id;
            CompradorId = compradorId;
            ProdutoId = produtoId;
            Comprador = comprador;
            Produto = produto;
            Date = date;
        }
    }
}
