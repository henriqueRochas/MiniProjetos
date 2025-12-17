

namespace ArenaMonstros
{
    internal class Vampiro : Monstro
    {
   
        public Vampiro() { }


        public override int Atacar()
        {
            Random random = new Random();
            Ataque = random.Next(0,150);
            HP += 5;
            return Ataque;
        }
    }
}
