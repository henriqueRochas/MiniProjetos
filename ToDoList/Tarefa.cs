using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Reflection.Metadata.Ecma335;

namespace ToDoList
{
    internal class Tarefa
    {
        public string Descricao { get; set; }
        public bool Completo { get; set; }

        public Tarefa()
        {
            Completo = false;
        }

        public Tarefa(string descricao, bool completo)
        {
            Descricao = descricao;
            Completo = completo;
        }

        List<Tarefa> listaTarefas = new List<Tarefa>();

        public void MenuTarefas()
        {
            int opcao;
            do
            {
                Console.WriteLine("=-=-=-=-=-=- MENU -=-=-=-=-=-=");
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
                    Console.WriteLine("Opção invalida, tente novamente");
                    continue;
                }

                switch (opcao)
                {
                    case 1:
                        AdicionarTrefas();
                        break;
                    case 2:
                        ListarTarefasPendentes();
                        break;
                    case 3:
                        StatusConcluido();
                        break;
                    case 4:
                        ListarTarefasConcluidas();
                        break;
                    case 5:
                        RemoverTarefas();
                        break;
                    case 0:
                        break;
                }
            } while (opcao != 0);
        }

        public void AdicionarTrefas()
        {
            Console.Write("Digite a quantidade de tarefas que deseja inserir: ");
            int qtdTarefas = int.Parse(Console.ReadLine());

            for (int i = 1; i <= qtdTarefas; i++)
            {
                Tarefa tarefa = new Tarefa();

                Console.Write($"Insira a descrição da tarefa: ");
                tarefa.Descricao = Console.ReadLine();
                listaTarefas.Add(tarefa);
            }
        }

        public void ListarTarefasPendentes()
        {
            Console.WriteLine("=-=-=-=-=- Tarefas Pendentes -=-=-=-=-=");
            Console.WriteLine();

            for (int i = 0; i < listaTarefas.Count; i++)
            {
                if (listaTarefas[i].Completo == false)
                {
                    Console.WriteLine($"{i + 1} - {listaTarefas[i].Descricao}");
                }
            }
            Console.WriteLine();

        }

        public void StatusConcluido()
        {
            Console.Write("Informe o número da tarefa que foi concluída: ");
            int numTarefa = int.Parse(Console.ReadLine());
            numTarefa = numTarefa - 1;
            listaTarefas[numTarefa].Completo = true;
            Console.WriteLine($"{listaTarefas[numTarefa].Descricao} - Foi Concluída com sucesso!");
                
        }

        public void ListarTarefasConcluidas()
        {
            Console.WriteLine("=-=-=-=-=- Tarefas Concluídas -=-=-=-=-=");
            Console.WriteLine();

            for (int i = 0; i < listaTarefas.Count; i++)
            {
                if (listaTarefas[i].Completo == true)
                {
                    Console.WriteLine($"{i + 1} - {listaTarefas[i].Descricao}");
                }
            }
            Console.WriteLine();
        }

        public void RemoverTarefas()
        {
            Console.Write("Informe o número da tarefa que deseja excluir: ");
            int numExcluir = int.Parse(Console.ReadLine());

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

        
    }
}
