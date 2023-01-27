using System.Reflection.PortableExecutable;
using Tavernier;

namespace test_unitaire
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();

            //Verifier les dégâts / et les points de vie                                                                                
            Character charac_Thran = new Thran();

            double max_damage = 100;
            double min_damage = 0;

        }
    }
}