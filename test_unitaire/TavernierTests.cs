using NUnit.Framework.Internal;
using System.Reflection.PortableExecutable;
using System.Threading;
using Tavernier;

namespace test_unitaire
{
    public class Tests
    {
        [Test]
        [TestCase(-1)]
        [TestCase(0)]
        [TestCase(100)]
        [TestCase(200)]
        public virtual void receveDammage(int damage)
        {
            Character player = new Character();
            int life = player.HP;
            if (life > 0)
                Assert.That(life, Is.EqualTo(life - damage));
            else
                return;
        }

        [Test]
        public virtual void healMax()
        {
            Character player = new Character();

            Assert.IsTrue(player.HP == player.Max_HP);
        }

        [Test]
        [TestCase(100)]
        public virtual void heal(int heal)
        {
            Character player = new Character();

            if (player.HP > player.Max_HP)
                Assert.That(player.HP, Is.EqualTo(player.Max_HP));
        }

    }
}



/*
 
 Creation tests unitaires:

public virtual void attack(Character target)

public virtual void useSkill(Character target, int numberSkill)

 
 
 */