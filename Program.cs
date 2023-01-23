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
            testHpNina = Nina.getHP();
            do {
                Thran.attack(Nina);
                testHpNina = Nina.getHP();
                Console.WriteLine("PV : {int}", testHpNina);
            } while (testHpNina > 0);



            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("");
            //Console.WriteLine("        _   ,_,   _\r\n       / `'=) (='` \\\r\n      /.-.-.\\ /.-.-.\\ \r\n      `      \"      `");

        }
    }
}