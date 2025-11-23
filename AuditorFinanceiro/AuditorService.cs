using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditorFinanceiro
{
    internal class AuditorService
    {
        private List<Transacao> todasTransacoes = new List<Transacao>();
        Random random = new Random();
        public AuditorService()
        {
            for (int i = 0; i <= 50; i++)
            {
                Transacao transacao = new Transacao();
                transacao.Id = Guid.NewGuid();
                transacao.Valor = random.Next(-1000, 10000);
                transacao.Data = DateTime.Now.AddDays(-random.Next(1, 365));
                string[] categoriaVetor = { "Alimentação", "Salário", "Lazer" };
                var teste = random.Next(categoriaVetor.Count());
                transacao.Categoria = categoriaVetor[teste] ;
                todasTransacoes.Add(transacao);
            }
        }
        public List<Transacao> TransacoesSupeitas()
        {
            var intervaloTrancacoes = todasTransacoes.Where(t => t.Valor > 5000  || t.Data.Hour >= 0 && t.Data.Hour <= 4);
            return intervaloTrancacoes.ToList();
        }

        public Dictionary<string, decimal> CalculoControlePorMes()
        {
            var formatMes = todasTransacoes.GroupBy(t => t.Data.ToString("MM/yyyy"));
            var calculo = formatMes.ToDictionary(g => g.Key, g  => g.Sum(t => t.Valor));
            return calculo;
        }

        public string CategoriaMaiorCusto()
        {
            var custo = todasTransacoes.Where(t => t.Valor < 0);
            var categorias = custo.GroupBy(c => c.Categoria);
            var ordenando = categorias.OrderBy(a => a.Sum(t => t.Valor));
            var maiorCusto = ordenando.FirstOrDefault();

            if(maiorCusto != null)
            {
                return maiorCusto.Key;
            }
            else
            {
                return "Sem custos";
            }
        }

        public List<Resumo> Relatorio()
        {
            var resumo = todasTransacoes.Select(r => new Resumo( r.Data.ToString("d"), r.Valor > 0 ? "Entrada" : "Saída"));
            return resumo.ToList();
        }
    }
}
