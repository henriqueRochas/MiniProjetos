using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Diario
{
    internal class GerenciadorDiario
    {
        List<EntradaDiario> entradaLista = new List<EntradaDiario>();
        public void SalvarTexto(EntradaDiario entrada)
        {
            string caminhoArquivo = @"\Diario\file\diario.txt";

            try
            {

                using (StreamWriter sw = new StreamWriter(caminhoArquivo, append: true))
                {

                        sw.WriteLine($"{entrada.Data} - {entrada.Texto}");

                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erroooo!!!");
                Console.WriteLine(e.Message);
            }
        }

        public void CarregarTextos()
        {
            string caminhoArquivo = @"\Diario\file\diario.txt";

            try
            {
                using (StreamReader sr = File.OpenText(caminhoArquivo))
                {
                    while (!sr.EndOfStream)
                    { 
                        EntradaDiario entradaDiario = new EntradaDiario();
                        string[] lerConteudo = sr.ReadLine().Split(" - ");

                        if (lerConteudo.Length > 1)
                        {
                            entradaDiario.Data = DateTime.Parse(lerConteudo[0].Trim());
                            entradaDiario.Texto = lerConteudo[1].Trim();
                            entradaLista.Add(entradaDiario);
                        }
                        else
                        {
                            entradaLista[entradaLista.Count - 1].Texto += lerConteudo[0] + Environment.NewLine;
                        }
                    }

                    foreach (var item in entradaLista)
                    {
                        Console.WriteLine($"{item.Data} \n{item.Texto}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Erroooooo!!");
                Console.WriteLine(e.Message);

            }
        }
    }
}
