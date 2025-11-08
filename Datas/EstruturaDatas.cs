using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datas
{
    internal class EstruturaDatas
    {
        public EstruturaDatas() { }

        public void MenuTipoDatas()
        {
            int opcao = 0;

            do
            {
                Console.WriteLine("Escolha um formato de horário: ");
                Console.WriteLine();

                Console.WriteLine($"1 - Utilizar minha configuração de sistema: ");
                Console.WriteLine($"2 - Formato simples: ");
                Console.WriteLine($"3 - Longo: ");
                Console.WriteLine($"4 - Longo Personalizado: ");
                Console.WriteLine($"5 - Formato RFC1123: ");
                Console.WriteLine();

                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();
                if (opcao < 1 || opcao > 5)
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                }
            }
            while (opcao < 1 || opcao > 5);

            Historias(opcao);
        }


        public string FormatoData(int opcao, DateTime opcaoHistoria)
        {
            string data = "";

            switch (opcao)
            {
                case 1:
                    data = opcaoHistoria.ToString();
                    break;
                case 2:
                    data = opcaoHistoria.ToShortDateString();
                    break;
                case 3:
                    data = opcaoHistoria.ToLongDateString();
                    break;
                case 4:
                    data = opcaoHistoria.ToString("dd-MM-yyyy HH:mm:ss ");
                    break;
                case 5:
                    data = opcaoHistoria.ToString("R");
                    break;
            }

            return data;
        }

        public void Historias(int opcao)
        {
            Console.WriteLine($"1 - ENIAC ");
            Console.WriteLine($"2 - RFC1 ");
            Console.WriteLine($"3 - Alan Turing ");
            Console.WriteLine();

            int opcaoHistoria = int.Parse(Console.ReadLine());

            Console.WriteLine();
            switch (opcaoHistoria)
            {
                case 1:
                    DateTime dataEniac = new DateTime(1946, 8, 15);
                    Console.WriteLine(@$"{FormatoData(opcao, dataEniac)} o dia 15 de agosto de 1946 os norte-americanos John Eckert e John Mauchly apresentaram o ENIAC, o primeiro equipamento eletrônico chamado de computador no mundo.");
                    break;
                case 2:
                    DateTime dataRFC1 = new DateTime(1969, 04, 17);
                    Console.WriteLine(@$"{FormatoData(opcao, dataRFC1)} Em 17 de abril de 1969 foi feita a publicação da RFC1, por esse motivo considera-se esse o dia da internet até hoje.");
                    break;
                case 3:
                    DateTime dataTuring = new DateTime(1912, 06, 23);
                    Console.WriteLine(@$"{FormatoData(opcao, dataTuring)}Nascimento de Alan Turing, matemático e criptoanalista britânico que é considerado o ""pai da informática"" por ter sido essencial na criação de máquinas que, mais tarde, dariam origem aos PCs que utilizamos hoje para trabalhar, estudar e realizar nossas atividades diárias. Sua genialidade e influência fundamental na história da humanidade, entretanto, foram ceifadas pelo preconceito de uma época que, felizmente, já ficou para trás.");
                    break;
            }
        }

    }
}
