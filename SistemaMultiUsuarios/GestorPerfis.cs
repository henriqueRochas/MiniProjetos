using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SistemaMultiUsuarios
{
    internal class GestorPerfis
    {
        private string Perfil(string usuario)
        {
            string pastaUsuario = @"SistemaMultiUsuarios\DadosUsuarios";
            string usuarioArquivo = usuario + ".json";
            string caminhoCompleto = Path.Combine(pastaUsuario, usuarioArquivo);

            if (!Directory.Exists(pastaUsuario))
            {
                Directory.CreateDirectory(pastaUsuario);
            }

            return caminhoCompleto;
        }
        public PerfilUsuario Login(string usuario)
        {
            PerfilUsuario perfilUsuario = new PerfilUsuario();

            if (File.Exists((Perfil(usuario))))
            {
                string conteudoJson = File.ReadAllText((Perfil(usuario)));
                perfilUsuario = JsonSerializer.Deserialize<PerfilUsuario>(conteudoJson);
            }
            else
            {
                perfilUsuario.NomeUsuario = usuario;
            }

            perfilUsuario.UltimoAcesso = DateTime.Now;
            string salvandoJson = JsonSerializer.Serialize(perfilUsuario);
            File.WriteAllText((Perfil(usuario)), salvandoJson);
            return perfilUsuario;
        }

        public void Salvar(string usuario, string novoTema)
        {
            PerfilUsuario perfilUsuario = new PerfilUsuario();

            string salvarConteudoJson = File.ReadAllText((Perfil(usuario)));
            perfilUsuario = JsonSerializer.Deserialize<PerfilUsuario>(salvarConteudoJson);
            perfilUsuario.Tema = novoTema;
            string savandoTemaJason = JsonSerializer.Serialize(perfilUsuario);
            File.WriteAllText(Perfil(usuario), savandoTemaJason);
        }

        public List<string> ListarTodosUsuarios()
        {
           var lendoArquivos = Directory.GetFiles(@"SistemaMultiUsuarios\DadosUsuarios");
           var novaLista = new List<string>();
           
            foreach (var item in lendoArquivos)
            {
               var guardandoLista = Path.GetFileNameWithoutExtension(item);
               novaLista.Add(guardandoLista);
            }
            return novaLista;
        }
    }
}
