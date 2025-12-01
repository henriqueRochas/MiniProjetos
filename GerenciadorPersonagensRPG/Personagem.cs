using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPersonagensRPG
{
    internal class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public string Classe { get; set; }
        public List<Atributos> Estatistica { get; set; }
        public List<Item> Inventario { get; set; }

        public Personagem() { }

        public Personagem(string nome, int nivel, string classe, List<Atributos> estatistica, List<Item> inventario)
        {
            Nome = nome;
            Nivel = nivel;
            Classe = classe;
            Estatistica = estatistica;
            Inventario = inventario;
        }
        
    }
}
