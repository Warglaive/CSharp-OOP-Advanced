using NUnit.Framework;

namespace DatabaseTests.cs
{
    public class DatabaseTests
    {
        private readonly int[] InvalidSizeArray = new int[20];
        private readonly int[] ValidSizeArray = new int[16];
        private readonly int[] EmptyArray = new int[0];
        private int arrayExactLength = 16;

        [Test]
        public void ExactLength_MustBe_16Integers()
        {
            //Test length
            var db = new Database(ValidSizeArray);
            Assert.That(() => db.IntegersDB.Length.Equals(arrayExactLength));
        }

        [Test]
        public void ThrowException_WhenMoreThan_ArrayExactLength()
        {
            //check if exception is thrown when > 16 ints

            Assert.That(() => new Database(InvalidSizeArray)
                , Throws.InvalidOperationException);
        }

        //[Test]
        //public void AddElement_AtTheNextFreeCell_Only()
        //{
        //    var numbers = new int[15] { 1, 0, 3, 2, 1, 3, 4, 5, 2, 3, 4, 5, 8, 9, 1 };
        //    var db = new Database(numbers);
        //    db.Add(77);
        //}

        [Test]
        public void ThrowException_WhenAddMoreElementsThan_ArrayCapacity()
        {
            Assert.That(() => new Database(ValidSizeArray)
                .Add(1), Throws.InvalidOperationException);
        }

        //[Test]
        //public void Remove_RemovingLastElement_FromArray()
        //{
        //    var emptyDatabase = new Database(ValidSizeArray);
        //    //remove 16 elements
        //    for (int i = 0; i < ValidSizeArray.Length; i++)
        //    {
        //        emptyDatabase.Remove();
        //    }
        //    //try to remove element from empty db;
        //    Assert.That(() => emptyDatabase.Remove(),
        //        Throws.InvalidOperationException);
        //}

        [Test]
        public void Remove_Element_FromEmptyDB()
        {
            var emptyDatabase = new Database(ValidSizeArray);
            //remove 16 elements
            for (int i = 0; i < ValidSizeArray.Length; i++)
            {
                emptyDatabase.Remove();
            }
            //try to remove element from empty db;
            //emptyDatabase.Remove();
            Assert.That(() => emptyDatabase.Remove(),
                Throws.InvalidOperationException);
        }
    }
}