namespace ArenaMonstros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Arena arena = new Arena();
            Vampiro vampiro = new Vampiro();
            Slime slime = new Slime();

            Console.Write("Nome do Vampiro: ");
            vampiro.Nome = Console.ReadLine();
            Console.Write("Nivel de vida do Vampiro: ");
            vampiro.HP = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Nome do Slime: ");
            slime.Nome = Console.ReadLine();
            Console.Write("Nivel de vida do Slime: ");
            slime.HP = int.Parse(Console.ReadLine());
            Console.WriteLine();
            arena.Batalhas(vampiro, slime);
            
        }
    }
}
