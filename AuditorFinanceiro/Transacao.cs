using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditorFinanceiro
{
    internal class Transacao
    {
        public Guid Id { get; set; }
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }
        public string Descricao { get; set; }
        public string Categoria { get; set; }

        public Transacao() { }

        public Transacao(Guid id, decimal valor, DateTime data, string descricao, string categoria)
        {
            Descricao = descricao;
            Data = data;
            Id = id;
            Valor = valor;
            Categoria = categoria;
        }
    }
}
