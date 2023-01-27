using System.Net;
using System.Security.Cryptography;

namespace Tavernier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nina Nina = new Nina();
            Thran Thran = new Thran();
            Goblin Goblin = new Goblin();
            Fight_State FirstFight= new Fight_State();
            FirstFight.run(Thran, Goblin);
        }
    }
}