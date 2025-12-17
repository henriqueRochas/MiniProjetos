
namespace ArenaMonstros
{
    internal class Slime : Monstro
    {
        public Slime()
        {
        }
        public override int Atacar()
        {
            Random random = new Random();
            Ataque = random.Next(0,150);
            HP *= 2;
            return Ataque;
        }
    }
}
