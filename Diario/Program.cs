namespace Diario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            do
            {
                GerenciadorDiario gerenciadorDiario = new GerenciadorDiario();
                Console.WriteLine("#-#-#-#- MENU -#-#-#-#");
                Console.WriteLine();

                Console.WriteLine("1) Escrever no diário");
                Console.WriteLine("2) Ler diário");
                Console.WriteLine("0) Sair");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                }

                switch (opcao)
                {
                    case 1:
                        string textoCompleto = "";
                        while (true)
                        {
                            string novoTexto = Console.ReadLine();

                            if(novoTexto == "fim")
                            {
                                break;
                            }
                            textoCompleto += novoTexto + Environment.NewLine;
                        }
                        EntradaDiario entradaDiario = new EntradaDiario(DateTime.Now, textoCompleto);
                        gerenciadorDiario.SalvarTexto(entradaDiario);
                        break;
                    case 2:
                        gerenciadorDiario.CarregarTextos();
                        break;
                    case 0:
                        break;
                }
            } while (opcao != 0);
        }

    }
}
