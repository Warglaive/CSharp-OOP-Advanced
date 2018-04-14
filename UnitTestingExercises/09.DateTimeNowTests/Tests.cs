using Moq;
using NUnit.Framework;
using _09.DateTimeNow;

namespace _09.DateTimeNowTests
{
    public class Tests
    {
        [Test]
        public void DatetimeNowTest()
        {
            var dtMock = new Mock<IGetDateTime>();
        }
    }
}