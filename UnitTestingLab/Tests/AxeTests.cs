using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class AxeTests
    {
        private const int AxeAttack = 2;
        private const int AxeDurability = 2;
        private const int DummyHealth = 20;
        private const int DummyXP = 20;
        private Axe axe;
        private Dummy dummy;

        [Test]
        public void Axe_DecreaseDurabilityAfterEachAttack_Istrue()
        {
            //Arrange
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXP);

            //Act
            axe.Attack(dummy);
            //Assert
            Assert.That(axe.DurabilityPoints, Is.EqualTo(1),
                "Axe Durability dosen't change after attack.");
        }
        [SetUp]
        [Test]
        public void AttackWithBrokenAxe()
        {
            this.axe = new Axe(AxeAttack, AxeDurability);
            this.dummy = new Dummy(DummyHealth, DummyXP);

            axe.Attack(dummy);
            axe.Attack(dummy);

            Assert.That(() => axe.Attack(dummy)
                , Throws.InvalidOperationException
                    .With.Message.EqualTo("Axe is broken."));
        }
    }
}
