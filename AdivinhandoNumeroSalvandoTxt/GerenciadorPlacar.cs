using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.CompilerServices;

namespace AdivinhandoNumeroSalvandoTxt
{
    internal class GerenciadorPlacar
    {
        private string caminhoArquivo = @"C:\Users\henri\OneDrive\Documents\GitHub\MiniProjetos\AdivinhandoNumeroSalvandoTxt\files\ranking_jogadores.txt";


        public List<Pontuacao> CarregarPlacar()
        {

            List<Pontuacao> placar = new List<Pontuacao>();
            try
            {
                if (File.Exists(caminhoArquivo) != false)
                {
                    FileInfo fileInfo = new FileInfo(caminhoArquivo);
                    string[] conteudoArquivo = File.ReadAllLines(caminhoArquivo);

                    foreach (var listaRanking in conteudoArquivo)
                    {
                        if (listaRanking == null || listaRanking == "")
                        {
                            continue;
                        }

                        Pontuacao pontuacao = new Pontuacao();

                        string[] dividir = listaRanking.Split(" | ");
                        pontuacao.Nome = dividir[0].Trim();

                        if (dividir.Length > 1)
                        {
                            pontuacao.Tentativas = int.Parse(dividir[1].Trim());
                        }

                        placar.Add(pontuacao);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROOOOOOOOOOO!");
                Console.WriteLine(e.Message);
            }
            return placar;

        }

        public void SalvarPlacar(List<Pontuacao> placar)
        {
            List<string> listaPlacar = new List<string>();

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoArquivo);

                foreach (var salvarPlacar in placar)
                {
                    string juntar = salvarPlacar.Nome + " | " + salvarPlacar.Tentativas;
                    listaPlacar.Add(juntar);
                }
                File.WriteAllLines(caminhoArquivo, listaPlacar);
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROOOO!!");
                Console.WriteLine(e.Message);
            }
        }
    }
}
