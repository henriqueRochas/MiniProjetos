using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AnalistaTrafegoWeb
{
    internal class ControleAcesso
    {
        private List<DadosAcesso> _dadosAcesso;

        public ControleAcesso()
        {
            _dadosAcesso = new List<DadosAcesso>()
            { 
                new DadosAcesso { Ip = "192.168.1.105", Url = "/index.html", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 08, 01, 15) },
                new DadosAcesso { Ip = "192.168.1.105", Url = "/css/style.css", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 08, 01, 16) },
                new DadosAcesso { Ip = "201.55.102.30", Url = "/login", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 08, 15, 00) },
                new DadosAcesso { Ip = "201.55.102.30", Url = "/dashboard", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 08, 15, 45) },
                new DadosAcesso { Ip = "10.0.0.55", Url = "/sobre-nos", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 09, 20, 10) },
                new DadosAcesso { Ip = "10.0.0.55", Url = "/contato", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 09, 21, 30) },
                new DadosAcesso { Ip = "172.16.50.99", Url = "/api/produtos", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 09, 30, 05) },
                new DadosAcesso { Ip = "172.16.50.99", Url = "/api/produtos/123", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 09, 30, 06) },
                new DadosAcesso { Ip = "192.168.1.105", Url = "/logout", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 09, 45, 00) },
                new DadosAcesso { Ip = "200.100.50.25", Url = "/home", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 10, 00, 12) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/admin", CodigoStatus = 403, DataHora = new DateTime(2024, 01, 15, 10, 05, 01) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/admin/login", CodigoStatus = 401, DataHora = new DateTime(2024, 01, 15, 10, 05, 02) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/wp-admin", CodigoStatus = 404, DataHora = new DateTime(2024, 01, 15, 10, 05, 02) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/config.php", CodigoStatus = 404, DataHora = new DateTime(2024, 01, 15, 10, 05, 03) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/.env", CodigoStatus = 403, DataHora = new DateTime(2024, 01, 15, 10, 05, 03) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/db_backup.sql", CodigoStatus = 404, DataHora = new DateTime(2024, 01, 15, 10, 05, 04) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/shell.php", CodigoStatus = 404, DataHora = new DateTime(2024, 01, 15, 10, 05, 04) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/root", CodigoStatus = 403, DataHora = new DateTime(2024, 01, 15, 10, 05, 05) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/api/v1/secret", CodigoStatus = 500, DataHora = new DateTime(2024, 01, 15, 10, 05, 06) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/login", CodigoStatus = 401, DataHora = new DateTime(2024, 01, 15, 10, 05, 07) },
                new DadosAcesso { Ip = "201.55.102.30", Url = "/perfil", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 11, 10, 20) },
                new DadosAcesso { Ip = "201.55.102.30", Url = "/configuracoes", CodigoStatus = 500, DataHora = new DateTime(2024, 01, 15, 11, 12, 00) },
                new DadosAcesso { Ip = "88.14.202.11", Url = "/blog/artigo-novo", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 13, 40, 00) },
                new DadosAcesso { Ip = "88.14.202.11", Url = "/blog/imagem.png", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 13, 40, 01) },
                new DadosAcesso { Ip = "123.45.67.89", Url = "/busca?q=tenis", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 14, 55, 30) },
                new DadosAcesso { Ip = "123.45.67.89", Url = "/favicon.ico", CodigoStatus = 404, DataHora = new DateTime(2024, 01, 15, 14, 55, 31) },
                new DadosAcesso { Ip = "192.168.1.200", Url = "/app/v2", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 15, 00, 10) },
                new DadosAcesso { Ip = "45.22.19.111", Url = "/retry-attack", CodigoStatus = 401, DataHora = new DateTime(2024, 01, 15, 16, 20, 00) },
                new DadosAcesso { Ip = "10.0.0.12", Url = "/carrinho", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 18, 10, 05) },
                new DadosAcesso { Ip = "10.0.0.12", Url = "/checkout/sucesso", CodigoStatus = 200, DataHora = new DateTime(2024, 01, 15, 18, 15, 00) }
            };
        }
        public List<string> UrlMaisVisitadas(int top)
        {
            var grupo = _dadosAcesso.GroupBy(a => a.Url);
            var pares = grupo.Select(b => new { Url = b.Key, Count = b.Count() });
            var ordenando = pares.OrderByDescending(p => p.Count);
            var topUrls = ordenando.Take(top).Select(p => p.Url).ToList();
            return topUrls;
                
        }

                
                 
        

        public List<string> IpsSuspeitos()
        {

        }

        public int MaiorVolumeAcesso()
        {

        }
    }
}
