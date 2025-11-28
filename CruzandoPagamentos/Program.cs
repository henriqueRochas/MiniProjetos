namespace CruzandoPagamentos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CruzamentoService cruzamento = new CruzamentoService();

            cruzamento.VendasSemPagamento();
            cruzamento.PagamentosAvulsos();
            cruzamento.DiferenciaEntreValores();
        }
    }
}
