using System;
using NUnit.Framework;
using Moq;

namespace _07.HackTests
{
    public class Tests
    {
        [Test]
        public void MathAbsTest()
        {
            var value = -5;
            var mathAbsContainer = new Mock<MathAbsCustom>();

            mathAbsContainer.Setup(x => x.MathAbs(value))
                .Returns(Math.Abs(value));
        }

        [Test]
        public void MathFloorTest()
        {
            var value = 0.9;
            var mathFloorContainer = new Mock<MathFloorCustom>();
            mathFloorContainer.Setup(f => f.MathFloorValue(value))
                .Returns(Math.Floor(value));
        }
    }
}
