using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorNotasAlunos
{
    internal class NotasAlunos
    {
        List<Alunos> turma = new List<Alunos>();

        public void AdicionarAlunos()
        {
            
            Alunos alunos = new Alunos();
            Console.WriteLine("}}}} INSERIR ALUNOS {{{{");
            Console.WriteLine();

            Console.Write("Nome: ");
            alunos.Nome = Console.ReadLine();
            alunos.Notas = new List<double>();


            for (int i = 0; i < 3; i++)
            {
                double notas;
                Console.WriteLine("Notas: ");
                while (!double.TryParse(Console.ReadLine(), CultureInfo.InvariantCulture, out notas))
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                }
                alunos.Notas.Add(notas);
            }
            turma.Add(alunos);

        }

        public void MediaAluno() 
        {
            Console.WriteLine("}}}} MEDIA ALUNO {{{{");
            Console.WriteLine();

            string nome = Console.ReadLine();
            var buscarAluno = turma.FirstOrDefault(aluno => aluno.Nome == nome);

            if (buscarAluno != null)
            {
               var mediaAluno =  buscarAluno.Notas.Average();
               Console.WriteLine($"Nome: {nome} Média: {mediaAluno.ToString("F2", CultureInfo.InvariantCulture )}");
            }

        }

        public void AlunosAprovados()
        {

           var aprovados =  turma.Where(aluno => aluno.Notas.Average() >= 7);
            foreach (var aprovadosLista in aprovados)
            {
                Console.WriteLine($"Nome: {aprovadosLista.Nome} Média: {aprovadosLista.Notas.Average().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }

        public void MediaTurma()
        {

            double mediaGeral = turma.SelectMany(aluno => aluno.Notas).Average();
            Console.WriteLine(mediaGeral.ToString("F2", CultureInfo.InvariantCulture));
        }

        public void MaiorMenorNota()
        {
           var maiorNota = turma.SelectMany(aluno  => aluno.Notas).Max();
           var menorNota = turma.SelectMany(aluno  => aluno.Notas).Min();
           Console.WriteLine($"Nota mais alta: {maiorNota.ToString("F2")}  Nota mais baixa: {menorNota.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
