using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar
{
    internal class MenuPrincipal
    {
        public MenuPrincipal() { }

        Secretaria secretaria = new Secretaria();
        Aluno aluno = new Aluno();
        Curso curso = new Curso();
        public void Menu()
        {
            int opcao;
            do
            {
                Console.WriteLine("MENU");
                Console.WriteLine();

                Console.WriteLine("1) Cadastrar Aluno");
                Console.WriteLine("2) Cadastrar Curso");
                Console.WriteLine("3) Fazer matrícula");
                Console.WriteLine("4) Lançar notas");
                Console.WriteLine("5) Ver boletim completo");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }

                switch (opcao)
                {
                    case 1:
                        CadastrarAlunos();
                        break;
                    case 2:
                        CadastrarCursos();
                        break;
                    case 3:
                        RealizarMatricula();
                        break;
                    case 4:
                        LancarNotas();
                        break;
                    case 5:
                        Boletim();
                        break;
                }
            } while (opcao != 0);
        }

        public void CadastrarAlunos()
        {
            string nomeAluno = Console.ReadLine();
            secretaria.CadastrarAlunos(nomeAluno);
        }
        public void CadastrarCursos()
        {
            string nomeCurso = Console.ReadLine();
            secretaria.CadastrarCursos(nomeCurso);
        }

        public void RealizarMatricula()
        {
            foreach (var listaAlunos in secretaria.ObterAlunos())
            {
                Console.WriteLine(listaAlunos);
            }

            foreach (var listaCursos in secretaria.ObterCursos())
            {
                Console.WriteLine(listaCursos.NomeMateria);
            }
            Guid idAluno = Guid.Parse(Console.ReadLine());
            Guid idCurso = Guid.Parse(Console.ReadLine());
            secretaria.MatricularAluno(idAluno, idCurso);

            //secretaria.MatricularAluno(aluno.Id, curso.Id);
        }
        public void LancarNotas()
        {
            Guid idAluno = Guid.Parse(Console.ReadLine());
            Guid idCurso = Guid.Parse(Console.ReadLine());
            double notas = double.Parse(Console.ReadLine());
            secretaria.LancarNota(idAluno, idCurso, notas);
        }

        public void Boletim()
        {
            Guid idAluno = Guid.Parse(Console.ReadLine());
            var boletim = secretaria.GerarBoletim(idAluno);

            foreach (var listaNotas in boletim)
            {
                Console.WriteLine(listaNotas);
            }
        }
    }
}
