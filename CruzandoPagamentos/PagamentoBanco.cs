using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruzandoPagamentos
{
    internal class PagamentoBanco
    {
        public int IdVendaOriginal { get; set; }
        public decimal ValorPago {  get; set; }
        public DateTime DataProcessamento { get; set; }

        public PagamentoBanco() { }

        public PagamentoBanco(int idVendaOriginal, decimal valorPago, DateTime dataProcessamento)
        {
            IdVendaOriginal = idVendaOriginal;
            ValorPago = valorPago;
            DataProcessamento = dataProcessamento;
        }
    }
}
