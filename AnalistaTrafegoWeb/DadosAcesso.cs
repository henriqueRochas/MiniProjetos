using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalistaTrafegoWeb
{
    internal class DadosAcesso
    {
        public string Ip {  get; set; }
        public string Url { get; set; }
        public int CodigoStatus { get; set; }
        public DateTime DataHora { get; set; }

        public DadosAcesso(){ }

        public DadosAcesso(string ip, string url, int codigoStatus, DateTime dataHora)
        {
            Ip = ip;
            Url = url;
            CodigoStatus = codigoStatus;
            DataHora = dataHora;
        }
    }
}
