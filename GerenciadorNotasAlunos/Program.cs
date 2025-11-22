namespace GerenciadorNotasAlunos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao;
            NotasAlunos notasAlunos = new NotasAlunos();

            do
            {
                Console.WriteLine("}}}} MENU {{{{");
                Console.WriteLine();

                Console.WriteLine("1) Adicionar aluno");
                Console.WriteLine("2) Média do aluno");
                Console.WriteLine("3) Alunos aprovados");
                Console.WriteLine("4) Média da Turma");
                Console.WriteLine("5) Notas mais alta e mais baixa da turna");
                Console.WriteLine("0) Sair");

                while (!int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.WriteLine("Opção inválida, tente novamente");
                }

                switch (opcao)
                {
                    case 1:
                        notasAlunos.AdicionarAlunos();
                        break;
                    case 2:
                        notasAlunos.MediaAluno();
                        break;
                    case 3:
                        notasAlunos.AlunosAprovados();
                        break;
                    case 4:
                        notasAlunos.MediaTurma();
                        break;
                    case 5:
                        notasAlunos.MaiorMenorNota();
                        break;
                    case 0:
                        break;
                }
            }while(opcao != 0);
        }
    }
}
