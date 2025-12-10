namespace AnalisePessoas_RH_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RHAnalise rHAnalise = new RHAnalise();
            Funcionario funcionario = new Funcionario();
            rHAnalise.CalcularMediaSalarialSetor();
            rHAnalise.SetorSalariosAltos(funcionario.Salario);

        }
    }
}
