using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar
{
    internal class Matricula
    {
        public Guid Id { get; set; }

        [ForeignKey (nameof(Aluno))]
        public Guid AlunoId { get; set; }
        public Aluno Aluno { get; set; }

        [ForeignKey (nameof(Curso))]
        public Guid CursoId { get; set; }
        public Curso Curso { get; set; }

        public double NotaFinal { get; set; }
        public int Frequencia { get; set; }

        public Matricula() { }

        public Matricula(Guid id, Guid alunoId, Guid cursoId, double notaFinal, int frequencia)
        {
            Id = id;
            AlunoId = alunoId;
            CursoId = cursoId;
            NotaFinal = notaFinal;
            Frequencia = frequencia;
        }

 


    }
}
