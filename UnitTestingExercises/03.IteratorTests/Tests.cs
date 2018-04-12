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
        //HasNextTests
        [Test]
        public void HasNextIndex_TrueTest()
        {
            var iterator = new ListIterator(SmallArr);
            var oldIndex = iterator.Index;
            iterator.Move();
            var newIndex = iterator.Index;
            Assert.Less(oldIndex, newIndex);
        }

        [Test]
        public void HasNextIndex_FalseTest()
        {
            var iterator = new ListIterator(new[] { "1" });
            var oldIndex = iterator.Index;
            iterator.Move();
            var newIndex = iterator.Index;
            Assert.AreEqual(oldIndex, newIndex);
        }

        //MoveTests
        [Test]
        public void SuccessfullyMoved_Moved_MustReturnTrue()
        {
            var iterator = new ListIterator(SmallArr);
            Assert.IsTrue(iterator.Move());
        }
        [Test]
        public void UnSuccesfullMove_LastIndexReached_MustReturnFalse()
        {
            var iterator = new ListIterator(SmallArr);
            //set to the lastIndex
            iterator.Index = SmallArr.Length;
            Assert.IsFalse(iterator.Move());
        }

    }
}