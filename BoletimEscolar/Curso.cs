using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoletimEscolar
{
    internal class Curso
    {
        public Guid Id { get; set; }
        public string NomeMateria { get; set; }

        public Curso() { }

        public Curso(Guid id, string nomeMateria)
        {
            Id = id;
            NomeMateria = nomeMateria;
        }
    }
}
