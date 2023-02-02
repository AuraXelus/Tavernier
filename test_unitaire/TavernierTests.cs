using NUnit.Framework.Internal;
using System.Reflection.PortableExecutable;
using System.Threading;
using Tavernier;

namespace test_unitaire
{
    public class Tests
    {
        [Test]
        [TestCase(1, 99)]
        [TestCase(100, 0)]
        [TestCase(200, 0)]
        public void receveDammage(int damage, int expected)
        {
            Balfis player = new Balfis();

            player.receveDammage(damage);

            Assert.That(player.HP, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(50, 10, 60)]
        [TestCase(60, 20, 60)]
        [TestCase(20, 50, 100)]

        public void HealTest(int damage, int heal, int expected)
        {
            Balfis player = new Balfis();

            player.receveDammage(damage);
            player.heal(heal);
            Assert.That(player.HP, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(99, 1)]
        [TestCase(0, 100)]
        [TestCase(0, 200)]
        public void chekAttack(int damage, int expected)
        {
            Balfis player = new Balfis();
            Dragon target = new Dragon();
            Dragon target_test = new Dragon();

            double result = (player.Phys_Atk + player.First_Weapon.Phy_Atk) - target.Phys_Def;
            target.receveDammage((int)result);
            player.attack(target_test);

            Assert.IsTrue(target.HP == target_test.HP);
        }

    }
}