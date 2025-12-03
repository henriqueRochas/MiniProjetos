using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace GerenciadorPersonagensRPG
{
    internal class GestorFicha
    {


        public void CriarPersonagem(Personagem personagem)
        {
            List<Personagem> carregarJson;
            string caminho = @"GerenciadorPersonagensRPG\personagens.json";

            if (File.Exists(caminho))
            {
                string lerJson = File.ReadAllText(@"GerenciadorPersonagensRPG\personagens.json");
                carregarJson = JsonSerializer.Deserialize<List<Personagem>>(lerJson);
            }
            else
            {
               carregarJson = new List<Personagem>();
            }

            carregarJson.Add(personagem);
            string conteudoJson = JsonSerializer.Serialize(carregarJson);
            File.WriteAllText(caminho, conteudoJson);
        }

        public void AdicionarInventario(string nomePersonagem, Item novoItem)
        {
            string caminhoArquivo = @"GerenciadorPersonagensRPG\personagens.json";
            string lerJson = File.ReadAllText(@"GerenciadorPersonagensRPG\personagens.json");
            var carregarJson = JsonSerializer.Deserialize<List<Personagem>>(lerJson);

            foreach (var item in carregarJson)
            {
                if(item.Nome == nomePersonagem)
                {
                    item.Inventario.Add(novoItem);
                }
            }
            string conteudoJson = JsonSerializer.Serialize(carregarJson);
            File.WriteAllText(caminhoArquivo, conteudoJson);
        }

        public Personagem CarregarPersonagem(string nome)
        {
            string caminhoArquivo = @"GerenciadorPersonagensRPG\personagens.json";
            string lerJson = File.ReadAllText(@"GerenciadorPersonagensRPG\personagens.json");
            var carregarJson = JsonSerializer.Deserialize<List<Personagem>>(lerJson);

            foreach (var item in carregarJson)
            {
                if(item.Nome == nome)
                {
                  return  item;
                }
            }
                return null;
        }
    }
}
