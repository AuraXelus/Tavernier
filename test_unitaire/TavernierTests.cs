using NUnit.Framework.Internal;
using System.Reflection.PortableExecutable;
using System.Threading;
using Tavernier;
using Tavernier.Characters;
using Tavernier.Characters.Player;

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
            Balfis balfis = new Balfis();

            balfis = 100;
            Assert.That(result, Is.EqualTo(expected));
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
