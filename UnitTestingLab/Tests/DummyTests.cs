using NUnit.Framework;

namespace Tests
{
    public class DummyTests
    {
        [Test]
        public void Dummy_LosesHealth_WhenAttacked()
        {
            var dummy = new Dummy(10, 10);
            dummy.TakeAttack(5);
            Assert.That(dummy.Health, Is.EqualTo(5));
        }

        [Test]
        public void DeadDummy_ThrowException_WhenAttacked()
        {
            var attacker = new Axe(20, 20);
            var dummy = new Dummy(10, 10);
            attacker.Attack(dummy);
            Assert.IsTrue(dummy.IsDead(), "Can't Attack dead dummy!");
        }

        [Test]
        public void DeadDummy_CanGive_Experience()
        {
            var attacker = new Axe(20, 20);
            var dummy = new Dummy(1, 10);
            attacker.Attack(dummy);
            Assert.IsTrue(dummy.IsDead());
            dummy.GiveExperience();
        }

        [Test]
        public void AliveDummy_CantGive_Experience()
        {
            var attacker = new Axe(9, 20);
            var dummy = new Dummy(10, 10);
            attacker.Attack(dummy);
            Assert.IsFalse(dummy.IsDead(),
                "alive dummy can't give xp");
        }
    }
}