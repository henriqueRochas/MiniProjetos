using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSistemaVendasEstoque
{
    internal class Comprador
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public decimal Saldo { get; set; }

        public Comprador() { }

        public Comprador(Guid id, string nome, decimal saldo)
        {
            Id = id;
            Nome = nome;
            Saldo = saldo;
        }

    }
}
