
namespace ArenaMonstros
{
    internal abstract class Monstro
    {

        public string Nome { get; set;}
        public int HP { get; set;}

        public int Ataque { get; set;}

        public Monstro () { }

        public Monstro(string nome, int hp)
        {
            Nome = nome; 
            HP = hp;
        }

        public int Dano(int dano)
        {
            return HP -= dano;
        }

        public abstract int Atacar();

    }
}
