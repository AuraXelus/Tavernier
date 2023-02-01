using NUnit.Framework.Internal;
using System.Reflection.PortableExecutable;
using System.Threading;
using Tavernier;
using Tavernier.Characters;
using Tavernier.Characters.Player;
using Tavernier.Characters.Ennemy;

namespace test_unitaire
{
    public class Tests
    {
        [Test]

        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(200)]
        public void receveDammage(int damage)
        {
            Character player = new Character();
            int life = player.HP;

            player.receveDammage(damage);

            Assert.That(player.HP, Is.EqualTo(life-damage));
        }
    }
}
