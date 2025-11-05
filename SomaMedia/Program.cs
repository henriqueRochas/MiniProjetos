using System.Reflection.Metadata.Ecma335;

namespace SomaMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0;
            double media = 0.0;
            double valores = 0.0;

            List<double> n = new List<double>();

            Console.WriteLine("Informe a quantidade de números que deseja inserir (3 à 10): ");

            int qtdNumeros = int.Parse(Console.ReadLine());

            if (qtdNumeros >= 3 && qtdNumeros <= 10)
            {
                for (int i = 0; i < qtdNumeros; i++)
                { 
                    valores = double.Parse(Console.ReadLine());
                    
                    n.Add(valores);
                }

                foreach (double v in n)
                {
                    soma = Somar(soma, v);
                }

                media = Media(soma, qtdNumeros);

                Console.WriteLine(media.ToString("F1"));
            }
        }

        public static double Somar(double soma, double valores)
        {
            soma += valores;
            return soma;
        }

        public static double Media(double soma, double n)
        {
            double media = soma / n;
            return media;
        }
    }   
}
