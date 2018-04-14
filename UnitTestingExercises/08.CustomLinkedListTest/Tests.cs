using System;
using System.Collections.Generic;
using CustomLinkedList;
using NUnit.Framework;

namespace _08.CustomLinkedListTest
{
    public class Tests
    {
        [Test]
        public void Constructor_CreateObjectValue_Test()
        {
            var dynamicList = new LinkedListNode<int>(1);
            Assert.IsTrue(dynamicList.Value == 1);
        }

        [Test]
        public void CountFieldIntReturnTest()
        {
            var dynamic = new DynamicList<int>();
            var countDefaultValue = 0;
            Assert.AreEqual(countDefaultValue, dynamic.Count);
        }

        [Test]
        public void DynamicListInvalidIndexExceptionTest()
        {
            var dynamicList = new DynamicList<int>();

            Assert.That(() => dynamicList[1],
                Throws.Exception);
        }
        //Add Tests
        [Test]
        public void DynamicListAddTest()
        {
            var dynamicList = new DynamicList<int>();
            dynamicList.Add(0);
            var expectedCount = dynamicList.Count;
            Assert.AreEqual(dynamicList.Count, expectedCount);
        }
    }
}