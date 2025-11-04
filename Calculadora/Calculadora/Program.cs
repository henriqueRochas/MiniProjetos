using System.Runtime.Serialization;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            

            while (true)
            {
                int result = 1;

                Console.WriteLine("1 - SOMAR");
                Console.WriteLine("2 - SUBTRAIR");
                Console.WriteLine("3 - MULTIPLICAR");
                Console.WriteLine("4 - DIVIDIR");
                Console.WriteLine("5 - RESTO DA DIVISÃO");
                Console.WriteLine("6 - EXPONENCIAR");
                Console.WriteLine("0 - SAIR");
                Console.WriteLine();

                int operacao = int.Parse(Console.ReadLine());

                switch (operacao)
                {
                    case 0:
                        break;
                    case 1:
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        int somar = n1 + n2;
                        Console.WriteLine($"{n1} + {n2} = {somar}");
                        break;
                    case 2:
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        int subtrair = n1 - n2;
                        Console.WriteLine($"{n1} - {n2} = {subtrair}");
                        break;
                    case 3:
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        int multiplicar = n1 * n2;
                        Console.WriteLine($"{n1} * {n2} = {multiplicar}");
                        break;
                    case 4:
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());

                        if (n2 != 0)
                        {
                            int dividir = n1 / n2;
                            Console.WriteLine($"{n1} / {n2} = {dividir}");
                        }
                        else
                        {
                            Console.WriteLine("Não é possivel dividir por 0");
                        }

                        break;
                    case 5:
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());
                        int resto = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {resto}");
                        break;
                    case 6:
                        n1 = int.Parse(Console.ReadLine());
                        n2 = int.Parse(Console.ReadLine());

                        for (int i = 0; i < n2; i++)
                        {
                            result *= n1;
                        }

                        Console.WriteLine($"{n1} * {n2} = {result}");
                        break;
                }
                Console.WriteLine();

                if (operacao == 0)
                {
                    break;
                }
            }
        }
    }
}
