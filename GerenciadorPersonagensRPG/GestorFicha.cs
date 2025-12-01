using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Text.Json;

namespace GerenciadorPersonagensRPG
{
    internal class GestorFicha
    {
     

        public void CriarPersonagem(Personagem personagem)
        {
            var a = JsonSerializer.Deserialize<List<Personagem>>(personagem.Nome);
            personagem = new Personagem
            {
                Nome = personagem.Nome,
                Nivel = personagem.Nivel,
                Classe = personagem.Classe,
                Estatistica = personagem.Estatistica,
                Inventario = personagem.Inventario
            };
            string conteudoJson = JsonSerializer.Serialize(personagem);
        }

        public void AdicionarInventario(string nomePersonagem, Item novoItem)
        {
           
        }

        public Personagem CarregarPersonagem(string nome)
        {
            Personagem personagem = new Personagem();
            nome = JsonSerializer.Deserialize<Personagem>(personagem);
        }
    }
}
