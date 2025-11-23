using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditorFinanceiro
{
    internal class Resumo
    {
        public string DataResumida {  get; set; }
        public string Tipo {  get; set; }
        public Resumo()
        {
        }

        public Resumo(string dataResumida, string tipo)
        {
            DataResumida = dataResumida;
            Tipo = tipo;
        }
    }
}
