using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaVendasEstoque
{
    internal class Vendedor
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Saldo { get; set; }

        public Vendedor() { }

        public Vendedor(Guid id , string nome, decimal saldo)
        {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }
    }
}
