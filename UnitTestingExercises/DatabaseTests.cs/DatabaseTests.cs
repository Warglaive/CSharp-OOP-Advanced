using System;
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
            Assert.That(() => new Database(InvalidSizeArray)
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

        //[Test]
        //public void Remove_LastElement_FromEmpty_DB()
        //{
        //    var emptyDB = new Database(ValidSizeArray);
        //    //remove 16 elements
        //    for (int i = 0; i < ValidSizeArray.Length; i++)
        //    {
        //        emptyDB.Remove();
        //    }
        //    //not possible to test, im too dumb
        //    Assert.That(emptyDB.Remove()
        //        , Throws.InvalidOperationException);
        //}

        [Test]
        public void Remove_LastElement_FromDB()
        {
            var nonEmptyDB = new Database(ValidSizeArray);
            Assert.IsTrue(nonEmptyDB.Remove());
        }

        [Test]
        public void FetchMethod_ShouldReturn_Array()
        {
            var db = new Database(ValidSizeArray);
            Assert.That(() => db.Fetch(), Is.TypeOf(typeof(int[])));
        }
    }
}