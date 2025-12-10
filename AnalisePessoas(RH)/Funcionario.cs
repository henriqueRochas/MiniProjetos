using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalisePessoas_RH_
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string Departamento {  get; set; }
        public decimal Salario { get; set; }
        public string Cargo { get; set; }
        public DateTime DataNascimento { get; set; }

        public Funcionario() { }

        public Funcionario(string nome, string departamento, decimal salario, string cargo, DateTime dataNascimento)
        {
            Nome = nome;
            Departamento = departamento;
            Salario = salario;
            Cargo = cargo;
            DataNascimento = dataNascimento;
        }
    }
}
