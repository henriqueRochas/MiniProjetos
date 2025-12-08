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
           _alunos = new List<Aluno>();
           _cursos = new List<Curso>();
           _matricula = new List<Matricula>();
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

        public string MatricularAluno(Guid idAluno, Guid idCurso)
        {
            Matricula matricula = new Matricula();
            try
            {
                if (_matricula.Any(a => a.Id == idAluno) && (_matricula.Any(b => b.Id == idCurso)))
                {
                    matricula.Id = idAluno;
                    matricula.CursoId = idCurso;
                    matricula.Frequencia = 100;
                    matricula.NotaFinal = 0;
                    _matricula.Add(matricula);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("ERROOOO!!!!!");
                Console.WriteLine(e.Message);
            }
            return ("Aluno matriculado com sucesso.");
        }
        public string LancarNota(Guid alunoId, Guid cursoId, double nota)
        {

            var verifMatriculaAluno = _matricula.FirstOrDefault(a => a.AlunoId == alunoId &&  a.CursoId == cursoId);
            verifMatriculaAluno.NotaFinal = nota;
            return ($"Nota lançada {verifMatriculaAluno.NotaFinal}");
        }

        public List<string> GerarBoletim(Guid alunoId)
        {
            List<string> boletim = new List<string>();
            try
            {
                var bucarMatricula = _matricula.Where(a => a.AlunoId == alunoId);

                foreach(var listaMatricula in bucarMatricula)
                {
                    var buscarMateria = _cursos.FirstOrDefault(a => a.Id == listaMatricula.CursoId);
                    boletim.Add($"Matéria: {buscarMateria.NomeMateria} | Nota: {listaMatricula.NotaFinal} | Frequência: {listaMatricula.Frequencia}%");
                }
                    var somandoNotas = bucarMatricula.Average(a => a.NotaFinal);
                boletim.Add($"Média Geral: {somandoNotas}");

            }
            catch (Exception e)
            {
                Console.WriteLine("ERROOOO!!");
                Console.WriteLine(e.Message);
            }
                return boletim;

        }
    }
}
