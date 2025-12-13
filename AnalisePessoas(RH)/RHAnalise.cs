using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisePessoas_RH_
{
    internal class RHAnalise
    {
        private List<Funcionario> _funcionarios;

        public RHAnalise()
        {
            _funcionarios = new List<Funcionario>() 
            { 
                new Funcionario { Nome = "Henrique", Departamento = "T.I", Salario = 5000, Cargo = "Junior", DataNascimento = new DateTime(1990, 10, 19) },
                new Funcionario { Nome = "Ana Silva", Departamento = "T.I", Salario = 8500, Cargo = "Pleno", DataNascimento = new DateTime(1993, 03, 12)},
                new Funcionario { Nome = "Carlos Souza", Departamento = "T.I", Salario = 12000, Cargo = "Senior", DataNascimento = new DateTime(1985, 07, 25) },
                new Funcionario { Nome = "Beatriz Costa", Departamento = "T.I", Salario = 2500, Cargo = "Estagiário", DataNascimento = new DateTime(2002, 11, 05) },
                new Funcionario { Nome = "Eduardo Santos", Departamento = "T.I", Salario = 16000, Cargo = "Gerente", DataNascimento = new DateTime(1980, 01, 30) },

                new Funcionario { Nome = "Fernanda Lima", Departamento = "RH", Salario = 4200, Cargo = "Junior", DataNascimento = new DateTime(1997, 05, 20)},
                new Funcionario { Nome = "Gabriel Pereira", Departamento = "RH", Salario = 6800, Cargo = "Pleno", DataNascimento = new DateTime(1991, 12, 10) },
                new Funcionario { Nome = "Helena Rocha", Departamento = "RH", Salario = 9500, Cargo = "Senior", DataNascimento = new DateTime(1986, 04, 03) },
                new Funcionario { Nome = "Igor Martins", Departamento = "RH", Salario = 3000, Cargo = "Assistente", DataNascimento = new DateTime(2000, 08, 14) },
                new Funcionario { Nome = "Julia Mendes", Departamento = "RH", Salario = 14000, Cargo = "Diretora", DataNascimento = new DateTime(1978, 11, 22) },

                new Funcionario { Nome = "Karina Alves", Departamento = "Financeiro", Salario = 5500, Cargo = "Pleno", DataNascimento = new DateTime(1994, 02, 17) },
                new Funcionario { Nome = "Lucas Ferreira", Departamento = "Financeiro", Salario = 3800, Cargo = "Junior", DataNascimento = new DateTime(1999, 06, 30) },
                new Funcionario { Nome = "Mariana Duarte", Departamento = "Financeiro", Salario = 11000, Cargo = "Coordenador", DataNascimento = new DateTime(1987, 09, 09) },
                new Funcionario { Nome = "Nicolas Braga", Departamento = "Financeiro", Salario = 4500, Cargo = "Analista", DataNascimento = new DateTime(1995, 01, 25) },
                new Funcionario { Nome = "Otavio Ramos", Departamento = "Financeiro", Salario = 19000, Cargo = "CFO", DataNascimento = new DateTime(1975, 03, 14) },

                new Funcionario { Nome = "Paula Ribeiro", Departamento = "Vendas", Salario = 4000, Cargo = "Junior", DataNascimento = new DateTime(1998, 12, 05) },
                new Funcionario { Nome = "Rafael Nunes", Departamento = "Vendas", Salario = 7000, Cargo = "Pleno", DataNascimento = new DateTime(1992, 10, 28) },
                new Funcionario { Nome = "Sofia Castro", Departamento = "Vendas", Salario = 10500, Cargo = "Senior", DataNascimento = new DateTime(1989, 07, 15) },
                new Funcionario { Nome = "Thiago Lopes", Departamento = "Vendas", Salario = 2800, Cargo = "Assistente", DataNascimento = new DateTime(2001, 05, 02) },
                new Funcionario { Nome = "Vitor Gomes", Departamento = "Vendas", Salario = 13500, Cargo = "Gerente Comercial", DataNascimento = new DateTime(1983, 08, 20) },
            };
        }

        public Dictionary<string, decimal> CalcularMediaSalarialSetor()
        {
            return _funcionarios
                .GroupBy(a => a.Departamento)
                .ToDictionary(b => b.Key, b => b.Average(a => a.Salario));
        }

        public List<string> SetorSalariosAltos(decimal altoValor)
        {
            return _funcionarios
                .GroupBy(a => a.Departamento)
                .Where(a => a.Sum(v => v.Salario) > altoValor)
                .Select(x => x.Key).ToList();
        }

        public List<string> RelatorioDivisaoCargos()
        {
            return _funcionarios
                .GroupBy(e => e.Departamento)
                .Select(a => $"Setor: {a.Key}  Jr: {a.Count(e => e.Cargo == "Junior")} Sr: {a.Count(e => e.Cargo == "Senior")}").ToList();
            
        }
    }
}
