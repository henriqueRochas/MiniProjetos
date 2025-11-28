using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruzandoPagamentos
{
    internal class Venda
    {
        public int ID { get; set; }
        public decimal Valor { get; set; }
        public string EmailCliente { get; set; }

        public Venda() { }

        public Venda(int id, decimal valor, string emailCliente)
        {
            ID = id;
            Valor = valor;
            EmailCliente = emailCliente;
        }
    }
}
