using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MiniAgenda
{
    internal class Contato
    {
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public Contato() { }

        public Contato(string nome, string telefone, string email)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }

        List<Contato> contatos = new List<Contato>();
        public void MenuPrincipal()
        {
            int opcao;

            do
            {
                Console.WriteLine("--------MENU DE OPÇÕES--------");
                Console.WriteLine();
                Console.WriteLine("1 - Adicionar Contato");
                Console.WriteLine("2 - Listar todos os contatos");
                Console.WriteLine("3 - Buscar Contato por Nome");
                Console.WriteLine("4 - Remover Contatos");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("==============================");
                Console.WriteLine();

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida. Tente novamente");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarContatos();
                        break;
                    case 2:
                        ListarContatos();
                        break;
                    case 3:
                        BuscarContatos();
                        break;
                    case 4:
                        RemoverContatos();
                        break;
                    case 0:
                        break;
                }
            } while (opcao != 0);
        }

        public void AdicionarContatos()
        {
            Contato contato = new Contato();

            Console.Write("Nome de Contato: ");
            contato.Nome = Console.ReadLine();

            Console.Write("Telefone de Contato: ");
            contato.Telefone = Console.ReadLine();

            Console.Write("Email de Contato: ");
            contato.Email = Console.ReadLine();
            Console.WriteLine();

            foreach (var verificarContato in contatos)
            {
                if (contato.Nome == verificarContato.Nome || contato.Telefone == verificarContato.Telefone || contato.Email == verificarContato.Email)
                {
                    Console.WriteLine($"{verificarContato.Nome} {verificarContato.Telefone} {verificarContato.Email}");
                    Console.WriteLine("Contato já existe");
                    return;
                }

            }

            contatos.Add(contato);

        }

        public void ListarContatos()
        {
            if (contatos.Count == 0)
            {
                Console.WriteLine("Lista de contatos vazia");
            }
            else
            {
                foreach (var item in contatos)
                {
                    Console.WriteLine($"{item.Nome} | {item.Telefone} | {item.Email}");
                }
            }
        }

        public void BuscarContatos()
        {
            Console.WriteLine("Informe o Nome, Telefone ou Email que deseja pesquisar: ");
            string pesquisar = Console.ReadLine();

            foreach (var itemPesquisar in contatos)
            {
                if (itemPesquisar.Nome.Contains(pesquisar) || itemPesquisar.Telefone.Contains(pesquisar) || itemPesquisar.Email.Contains(pesquisar))
                {
                    Console.WriteLine($"{itemPesquisar.Nome} {itemPesquisar.Telefone} {itemPesquisar.Email}");
                }
            }
        }

        public void RemoverContatos()
        {
            Contato removerLista = null;
            Console.WriteLine("Informe o contato que deseja excluir:");
            string removerPesquisar = Console.ReadLine();
            foreach (var removerContato in contatos)
            {
                if (removerContato.Nome.Contains(removerPesquisar) || removerContato.Telefone.Contains(removerPesquisar) || removerContato.Email.Contains(removerPesquisar))
                {
                    Console.WriteLine($"{removerContato.Nome} {removerContato.Telefone} {removerContato.Email}");
                    Console.WriteLine($"Esse é o item que deseja remover? (S/N)");
                    string decisao = Console.ReadLine();
                    if (decisao.Contains("S"))
                    {
                        removerLista = removerContato;
                        break;
                    }
                }
            }
            if(removerLista == null)
            {
                Console.WriteLine("Contato não encontrado");
            }
            else
            {
                contatos.Remove(removerLista);
            }
        }
    }
}
