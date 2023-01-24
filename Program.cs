using System.Net;

namespace Tavernier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Nina Nina = new Nina();

            Thran Thran = new Thran();
            int testHpNina;
            testHpNina = Nina.Max_HP;

            int atkThran = Thran.Phys_Atk + Thran.First_Weapon.Atk_Phy;
            do {
                Console.WriteLine("Attaque Thran {0}", atkThran);
                Thran.attack(Nina);
                testHpNina = Nina.HP;
                Console.ReadKey(true);
            } while (testHpNina > 0);



            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("        _   ,_,   _\r\n       / `'=) (='` \\\r\n      /.-.-.\\ /.-.-.\\ \r\n      `      \"      `");

        }
    }
}