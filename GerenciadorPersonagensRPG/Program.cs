namespace GerenciadorPersonagensRPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GestorFicha gestorFicha = new GestorFicha();
            Personagem personagem1 = new Personagem();
            Console.WriteLine("Criando Personagens");
            gestorFicha.CriarPersonagem(personagem1);

        }
    }
}
