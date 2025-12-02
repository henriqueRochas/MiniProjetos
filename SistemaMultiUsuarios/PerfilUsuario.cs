using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaMultiUsuarios
{
    internal class PerfilUsuario
    {
        public string NomeUsuario {  get; set; }
        public string Tema {  get; set; }
        public DateTime UltimoAcesso { get; set; }

        public PerfilUsuario() { }
        public PerfilUsuario(string nomeUsuario, string tema, DateTime ultimoAcesso) 
        {
            NomeUsuario = nomeUsuario;
            Tema = tema;
            UltimoAcesso = ultimoAcesso;
        }

    }
}
