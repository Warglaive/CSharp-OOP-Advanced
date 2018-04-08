using NUnit.Framework;

namespace Tests
{
    public class DummyTests
    {
        [Test]
        public void Dummy_LosesHealth_WhenAttacked()
        {
            var dummyHealth = 10;
            var dummyXP = 10;
            var dummy = new Dummy(dummyHealth, dummyXP);
            dummy.TakeAttack(5);
            Assert.That(dummy.Health, Is.EqualTo(5));
        }

        [Test]
        public void DeadDummy_ThrowException_WhenAttacked()
        {
            var axeAttack = 20;
            var axeDurability = 20;

            var dummyHealth = 10;
            var dummyXP = 10;

            var attacker = new Axe(axeAttack, axeDurability);
            var dummy = new Dummy(dummyHealth, dummyXP);

            attacker.Attack(dummy);
            Assert.IsTrue(dummy.IsDead(), "Can't Attack dead dummy!");
        }

        [Test]
        public void DeadDummy_CanGive_Experience()
        {
            var axeAttack = 20;
            var axeDurability = 20;

            var dummyHealth = 1;
            var dummyXP = 10;

            var attacker = new Axe(axeAttack, axeDurability);
            var dummy = new Dummy(dummyHealth, dummyXP);

            attacker.Attack(dummy);
            Assert.IsTrue(dummy.IsDead());
            dummy.GiveExperience();
        }

        [Test]
        public void AliveDummy_CantGive_Experience()
        {
            var axeAttack = 9;
            var axeDurability = 20;

            var dummyHealth = 10;
            var dummyXP = 10;

            var attacker = new Axe(axeAttack, axeDurability);
            var dummy = new Dummy(dummyHealth, dummyXP);
            attacker.Attack(dummy);
            Assert.IsFalse(dummy.IsDead(),
                "alive dummy can't give xp");
        }
    }
}