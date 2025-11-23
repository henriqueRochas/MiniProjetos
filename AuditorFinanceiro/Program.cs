using System;

namespace AuditorFinanceiro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            Transacao transacao = new Transacao();
            AuditorService service = new AuditorService();

            do
            {
                Console.WriteLine("#=#=#= MENU =#=#=#");
                Console.WriteLine("1) RELATÓRIO DE SUSPEITAS");
                Console.WriteLine("2) CONTROLE MENSAL");
                Console.WriteLine("3) MAIOR GASTO");
                Console.WriteLine("4) RELATÓRIO RESUMIDO");
                Console.WriteLine("0) SAIR");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                    Console.WriteLine("Só são aceitos números inteiros de 0 a 3");
                }

                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("#=#=#= TRANSAÇÕES SUSPEITAS =#=#=#");
                        Console.WriteLine();

                        var listas = service.TransacoesSupeitas();

                        foreach (var listaTransacao in listas)
                        {
                            Console.WriteLine($"Data: {listaTransacao.Data} | Valor: {listaTransacao.Valor:C2} | Categoria: {listaTransacao.Categoria}");
                        }
                        break;

                    case 2:
                        Console.WriteLine("#=#=#= CONTROLE MENSAL =#=#=#");
                        Console.WriteLine();

                        var calculoControle = service.CalculoControlePorMes();

                        foreach (var listaCalculo in calculoControle)
                        {
                            Console.WriteLine($"Mês: {listaCalculo.Key} -> Saldo: {listaCalculo.Value:C2}");
                        }
                        break;

                    case 3:
                        Console.WriteLine("#=#=#= MAIOR CUSTO =#=#=#");
                        Console.WriteLine();

                        Console.WriteLine($"Maior custo: { service.CategoriaMaiorCusto()}");
                        break;

                    case 4:
                        Console.WriteLine("#=#=#= RELATÓRIO RESUMIDO =#=#=#");
                        Console.WriteLine();

                        var resumoRelatorio = service.Relatorio();

                        foreach (var resumo in resumoRelatorio)
                        {
                            Console.WriteLine($"Data: {resumo.DataResumida} Tipo: {resumo.Tipo}");
                        }
                        break; 

                    case 0:
                        break;
                }

            } while (opcao != 0);
        }
    }
}
