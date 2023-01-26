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