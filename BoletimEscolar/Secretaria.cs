using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar
{
    internal class Secretaria
    {
        List<Aluno> _alunos;
        List<Curso> _cursos;
        List<Matricula> _matricula;

        public Secretaria()
        {
            new List<Aluno>();
            new List<Curso>();
            new List<Matricula>();
        }

        public void CadastrarAlunos(string nome)
        {
            Aluno aluno = new Aluno();

            aluno.Nome = nome;
            _alunos.Add(aluno);
        }
        public void CadastrarCursos(string nomeMateria)
        {
            Curso curso = new Curso();
            curso.NomeMateria = nomeMateria;
            _cursos.Add(curso);
        }
        public List<Aluno> ObterAlunos()
        {
            foreach (var listaAlunos in _alunos)
            {
                Console.WriteLine(listaAlunos.Nome);
            }
            return _alunos;
        }

        public List<Curso> ObterCursos()
        {
            foreach (var listaCursos in _cursos)
            {
                Console.WriteLine(listaCursos.NomeMateria);
            }
            return _cursos;
        }

        public MatricularAluno(Guid idAluno, Guid idCurso)
        {
            try
            {
                if(_matricula.Any(a => a.Id == idAluno))
                {
                    // PAREI AQUI NA VERIFICAÇÃO DO ALUNO E DO CURSO NA MATRICULA;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROOOO!!!!!");
                Console.WriteLine(e.Message);
            }
        }
        public void LancarNota(Guid alunoId, Guid cursoId, double nota)
        {
            var procuraMatricula = _matricula.FirstOrDefault(a => a.Id == alunoId);

        }
        public List<string> GerarBoletim(Guid alunoId)
        {
            try
            {
                var bucarMatricula = _matricula.FirstOrDefault(a => a.CursoId == alunoId);
                foreach(var listaMatricula in _matricula)
                {
                    Console.WriteLine($"{listaMatricula.Curso}: {listaMatricula.NotaFinal}");
                }
                return _matricula;
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROOOO!!");
                Console.WriteLine(e.Message);
            }

        }
    }
}
