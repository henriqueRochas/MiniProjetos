using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Diario
{
    internal class EntradaDiario
    {
        public DateTime Data { get; set; }
        public string Texto { get; set; }

        public EntradaDiario() { }

        public EntradaDiario(DateTime data, string texto)
        {
            Data = data;
            Texto = texto;
        }

    }
}
