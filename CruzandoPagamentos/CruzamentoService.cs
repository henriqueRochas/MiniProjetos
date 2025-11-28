using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CruzandoPagamentos
{
    internal class CruzamentoService
    {
        private List<Venda> _vendas;
        private List<PagamentoBanco> _pagamentos;
        public CruzamentoService()
        {
            _vendas = new List<Venda>
            {
                new Venda{ID = 1}, new Venda{ID = 2}, new Venda{ID = 3}, new Venda{ID = 4}, new Venda{ID = 5},
                new Venda{ID = 6}, new Venda{ID = 7}, new Venda{ID = 8}, new Venda{ID = 9}, new Venda{ID = 10},
            };

            _pagamentos = new List<PagamentoBanco>
            {
                new PagamentoBanco{IdVendaOriginal = 1},new PagamentoBanco{IdVendaOriginal = 2},new PagamentoBanco{IdVendaOriginal = 3},
                new PagamentoBanco{IdVendaOriginal = 4},new PagamentoBanco{IdVendaOriginal = 5},new PagamentoBanco{IdVendaOriginal = 6},
                new PagamentoBanco{IdVendaOriginal = 7},new PagamentoBanco{IdVendaOriginal = 8},new PagamentoBanco{IdVendaOriginal = 15},
            };
        }    
        public void VendasSemPagamento()
        {
            var idPagamentos = _pagamentos
                .Select(a => a.IdVendaOriginal);

            var idVendas = _vendas
                .Select(v => v.ID);

            var vendasForaPagamentos = idVendas.Except(idPagamentos);

            foreach (var item in vendasForaPagamentos)
            {
                Console.WriteLine(item);
            }




        }

        public void PagamentosAvulsos()
        {
            var idPagamentos = _pagamentos
                .Select(a => a.IdVendaOriginal);

            var idVendas = _vendas
                .Select(v => v.ID);

            var pagamentosAvulsos = idPagamentos.Except(idVendas);

            foreach (var item in pagamentosAvulsos)
            {
                Console.WriteLine(item);
            }
        }

        public void DiferenciaEntreValores()
        {
            var idPagamentos = _pagamentos
                .Select(a => a.ValorPago);

            var idVendas = _vendas
                .Select(v => v.Valor);

            var diferenciaValores = idVendas.Except(idPagamentos);

            foreach (var item in _vendas)
            {
                var procurandoDiferencia = _pagamentos.FirstOrDefault(p => p.IdVendaOriginal == item.ID);

                if(item.Valor != null)
                {
                    if (item.Valor != procurandoDiferencia.ValorPago)
                    {
                        Console.WriteLine(item);

                    }
                }
            }

        }

    }
}
