using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar
{
    internal class Aluno
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }

        public Aluno() { }

        public Aluno(Guid id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
}
