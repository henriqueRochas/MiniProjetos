using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPersonagensRPG
{
    internal class Item
    {
        public string Nome {  get; set; }
        public double Peso { get; set; }
        public int Valor { get; set; }

        public Item() { }

        public Item(string nome, double peso, int valor)
        {
            Nome = nome;
            Peso = peso;
            Valor = valor;
        }
    }
}
