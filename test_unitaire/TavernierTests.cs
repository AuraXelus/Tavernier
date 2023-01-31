using NUnit.Framework.Internal;
using System.Reflection.PortableExecutable;
using System.Threading;
using Tavernier;

namespace test_unitaire
{
    public class Tests
    {
        [Test]
        [TestCase(-1, false)]
        [TestCase(0, true)]
        [TestCase(100, true)]
        [TestCase(200, false)]
        public void attack_life(int life, bool expected)
        {
            
        }


        [Test]
        [TestCase(-1, false)]
        [TestCase(0, true)]
        [TestCase(100, true)]
        [TestCase(200, false)]
        public void attack_damage(int damage, bool expected)
        {

        }
    }
}
