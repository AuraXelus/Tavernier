using System.Net;
using System.Security.Cryptography;

namespace Tavernier
{
    public class Program
    {
        static void Main(string[] args)
        {
            Nina Nina = new Nina();
            Thran Thran = new Thran();
            WarriorGoblin Goblin = new WarriorGoblin();
            Fight_State FirstFight= new Fight_State();
            FirstFight.run(Thran, Goblin);
        }
    }
}

//Utilisation des faiblesses
//Ajout de la magie
//Objet (armes) potions vie, mana,
//Niveau
//System d'argent
//Spécificité des compétence