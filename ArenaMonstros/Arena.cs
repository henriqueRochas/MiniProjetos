
namespace ArenaMonstros
{
    internal class Arena
    {
        public void Batalhas(Monstro monstro1, Monstro monstro2)
        {
            while(monstro1.HP > 0 && monstro2.HP > 0)
            {
                int ataqueVampiro = monstro1.Atacar();
                Console.WriteLine($"Ataque do Vampiro {ataqueVampiro}. Slime tem {monstro2.Dano(ataqueVampiro)} de HP restante");
                if(monstro2.HP > 0)
                {
                    int ataqueSlime = monstro2.Atacar();
                    Console.WriteLine($"Ataque do Slime {ataqueSlime}. Vampiro tem {monstro1.Dano(ataqueSlime)} de HP restante");
                    Console.WriteLine();
                }
            }

            if(monstro1.HP <= 0)
            {
                Console.WriteLine($"O vencedor é {monstro2.Nome} {monstro2.HP}");
            }
            else
            {
                Console.WriteLine($"O vencedor é {monstro1.Nome} {monstro1.HP}");
            }
        }
    }
}
