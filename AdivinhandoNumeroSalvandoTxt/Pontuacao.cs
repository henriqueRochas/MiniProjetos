using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivinhandoNumeroSalvandoTxt
{
    internal class Pontuacao
    {
        public string Nome {  get; set; }
        public int Tentativas { get; set; }

        public Pontuacao() { }

        public Pontuacao(string nome, int tentativas)
        {
            Nome = nome;
            Tentativas = tentativas;
        }
    }
}
