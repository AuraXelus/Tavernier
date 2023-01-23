namespace Tavernier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Nina Nina;
            Nina = new Nina();

            int testHpNina;
            testHpNina = Nina.getHP();

            Console.WriteLine(testHpNina);


        }
    }
}