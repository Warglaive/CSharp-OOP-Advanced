using NUnit.Framework;
using _03.IteratorTest;

namespace _03.IteratorTests
{
    public class Tests
    {
        //testCtor
        public string[] SmallArr = { "1", "2", "3" };
        [Test]
        public void Constructor_ThrowException_WhenNullIsGiven()
        {
            Assert.That(() => new ListIterator(null)
            , Throws.ArgumentNullException);
        }
        //TestMove
        [Test]
        public void SuccessfullyMoved_Moved_MustReturnTrue()
        {
            var iterator = new ListIterator(SmallArr);
            Assert.IsTrue(iterator.Move());
        }
        [Test]
        public void UnSuccesfullMove_LastIndexReached_MustReturnFalse()
        {
            var arr = new[] { "1", "2", "3" };
            var iterator = new ListIterator(arr);
            //set to the lastIndex
            iterator.Index = arr.Length;
            Assert.IsFalse(iterator.Move());
        }
        //TestHasNext

    }
}