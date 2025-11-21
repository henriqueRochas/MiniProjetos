using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ToDoListPersistencia
{
    internal class Tarefas
    {
        public string Descricao { get; set; }
        public bool Completa { get; set; }

        public Tarefas()
        {
            Completa = false;
        }
        public Tarefas(string descricao, bool completo)
        {
            Descricao = descricao;
            Completa = completo;
        }

        List<Tarefas> listaTarefas = new List<Tarefas>();

        public void Menu()
        {
            int opcao;

            CarregarArquivos();

            do
            {
                Console.WriteLine("*-*-*-*-*-* MENU *-*-*-*-*-*");
                Console.WriteLine();

                Console.WriteLine("1 - Adicionar tarefa(s)");
                Console.WriteLine("2 - Listar tarefa(s) pendente(s)");
                Console.WriteLine("3 - Marcar tarefa(s) como concluída(s)");
                Console.WriteLine("4 - Lista tarefa(s) concluída(s)");
                Console.WriteLine("5 - Remover tarefa(s)");
                Console.WriteLine("0 - Sair");
                Console.WriteLine();

                if (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida, tente novamente.");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarTarefa();
                        break;
                    case 2:
                        ListarTarefasPendentes();
                        break;
                    case 3:
                        MudarStatusTarefas();
                        break;
                    case 4:
                        ListarTarefasConcluidas();
                        break;
                    case 5:
                        RemoverTarefas();
                        break;
                    case 0:
                        SalvarArquivos();
                        break;
                }
            } while (opcao != 0);
        }

        public void AdicionarTarefa()
        {
            int quantidade;

            Console.Write("Informe quantas tarefas você quer inserir: ");
            while (!int.TryParse(Console.ReadLine(), out quantidade) || quantidade < 0 || quantidade > 10)
            {
                Console.WriteLine("Valor inválido. Tente novamente com um valor entre 0 e 10");
                continue;
            }

            for (int i = 0; i < quantidade; i++)
            {
                Tarefas tarefas = new Tarefas();

                Console.Write("Descrição da tarefa: ");
                tarefas.Descricao = Console.ReadLine();
                listaTarefas.Add(tarefas);
            }
        }
        public void ListarTarefasPendentes()
        {
            Console.WriteLine("*-*-*-*-*-* TAREFAS PENDENDES *-*-*-*-*-*");
            Console.WriteLine();

            for (int i = 0; i < listaTarefas.Count; i++)
            {
                if (listaTarefas[i].Completa == false)
                {
                    Console.WriteLine($"{i + 1} - {listaTarefas[i].Descricao}");
                }
            }
            Console.WriteLine();
        }

        public void MudarStatusTarefas()
        {
            int idTarefa;
            Console.WriteLine("*-*-*-*-*-* MUDAR STATUS PARA CONCLUÍDO *-*-*-*-*-*");
            Console.WriteLine();

            Console.Write("Informe o número da tarefa que foi concluída: ");

            while (!int.TryParse(Console.ReadLine(), out idTarefa))
            {
                Console.WriteLine("Tarefa não encontrada. Tente novamente");
                continue;
            }

            idTarefa--;
            listaTarefas[idTarefa].Completa = true;
            Console.WriteLine($"{listaTarefas[idTarefa].Descricao} - Foi Concluída com sucesso!");
        }
        public void ListarTarefasConcluidas()
        {
            Console.WriteLine("*-*-*-*-*-* TAREFAS CONCLUÍDAS *-*-*-*-*-*");
            Console.WriteLine();

            for (int i = 0; i < listaTarefas.Count; i++)
            {
                if (listaTarefas[i].Completa == true)
                {
                    Console.WriteLine($"{i + 1} - {listaTarefas[i].Descricao}");
                }
            }
            Console.WriteLine();
        }

        public void RemoverTarefas()
        {
            int numExcluir;
            Console.WriteLine("*-*-*-*-*-* REMOVER TAREFAS *-*-*-*-*-*");

            Console.Write("Informe o número da tarefa que deseja excluir: ");

            while (!int.TryParse(Console.ReadLine(), out numExcluir))
            {
                Console.WriteLine("Valor invalido, tente novamente");
                continue;
            }

            if (numExcluir <= 0 || numExcluir > listaTarefas.Count)
            {
                Console.WriteLine("Esse indice não existe, tente novamente");
            }
            else
            {
                int inicioLista = numExcluir - 1;
                listaTarefas.RemoveAt(inicioLista);
                Console.WriteLine("Removida com sucesso!");
                Console.WriteLine();
            }
        }

        public void CarregarArquivos()
        {
            string caminhoArquivo = @"ToDoListPersistencia\Files\file1.txt";

            try
            {
                if (File.Exists(caminhoArquivo) != false)
                {
                    FileInfo fileInfo = new FileInfo(caminhoArquivo);
                    string[] conteudoArquivo = File.ReadAllLines(caminhoArquivo);
                    foreach (var line in conteudoArquivo)
                    {
                        Tarefas tarefas = new Tarefas();
                        string[] dividir = line.Split(',');
                        tarefas.Descricao = dividir[0];
                        tarefas.Completa = bool.Parse(dividir[1]);
                        listaTarefas.Add(tarefas);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu erro, agora arruma!!!!)");
                Console.WriteLine(e.Message);
            }
        }

        public void SalvarArquivos()
        {
            string caminhoArquivo = @"ToDoListPersistencia\Files\file1.txt";

            List<string> salvarLinhas = new List<string>();

            try
            {
                FileInfo fileInfo = new FileInfo(caminhoArquivo);

                foreach (var lines in listaTarefas)
                {
                    string juntar = lines.Descricao + "," + lines.Completa;
                    salvarLinhas.Add(juntar);
                }
                File.WriteAllLines(caminhoArquivo, salvarLinhas);
            }
            catch (Exception e)
            {
                Console.WriteLine("Deu erro, agora arruma!!!!)");
                Console.WriteLine(e.Message);
            }
        }
    }
}

