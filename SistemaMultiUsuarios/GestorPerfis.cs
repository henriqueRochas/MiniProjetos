using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaMultiUsuarios
{
    internal class GestorPerfis
    {
        public void Login(string usuario)
        {
            PerfilUsuario perfilUsuario = new PerfilUsuario();

            string pastaUsuario = @"C:\Users\henri\OneDrive\Documents\GitHub\MiniProjetos\SistemaMultiUsuarios\DadosUsuarios";
            string usuarioArquivo = usuario + ".json";
            string caminhoCompleto = Path.Combine(pastaUsuario, usuarioArquivo);
            if (!Directory.Exists(pastaUsuario))
            {
                Directory.CreateDirectory(pastaUsuario);
            }

            if (File.Exists(caminhoCompleto))
            {
                string conteudoJson = File.ReadAllText(caminhoCompleto);
            }
            else
            {
                new List<PerfilUsuario>();
            }

            perfilUsuario.UltimoAcesso = DateTime.Now;
            string salvandoJson = JsonSerializer.Serialize(perfilUsuario);
        }

        public void Salvar(string usuario, string novoTema)
        {

        }

        public List<string> ListarTodosUsuarios()
        {
            return new List<string>();
        }
    }
}
