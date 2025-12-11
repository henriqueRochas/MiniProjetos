namespace AnalisePessoas_RH_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RHAnalise rHAnalise = new RHAnalise();
            Funcionario funcionario = new Funcionario();

            var calcular = rHAnalise.CalcularMediaSalarialSetor();
            foreach (var item in calcular)
            {
                Console.WriteLine($"Setor: {item.Key} Média salarial: {item.Value}");
            }
            Console.WriteLine();

            var salariosAltos = rHAnalise.SetorSalariosAltos(funcionario.Salario);
            foreach (var item in salariosAltos)
            {
                Console.WriteLine($"Setores:{item}");
            }
            Console.WriteLine();

            var relatorio = rHAnalise.RelatorioDivisaoCargos();
            foreach(var item in relatorio)
            {
                Console.WriteLine(item);
            }

        }
    }
}
