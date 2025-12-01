using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorPersonagensRPG
{
    internal class Atributos
    {
        public int Forca {  get; set; }
        public int Destreza { get; set; }
        public int Inteligencia { get; set; }

        public Atributos() { }

        public Atributos(int forca, int destreza, int inteligencia)
        {
            Forca = forca;
            Destreza = destreza;
            Inteligencia = inteligencia;
        }
    }
}
