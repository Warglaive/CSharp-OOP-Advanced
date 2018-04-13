using System;
using NUnit.Framework;
using _06.Twitter.Models;

namespace _06.TwitterTests
{
    public class Tests
    {
        //print on console test
        [Test]
        public void CreateMessageTest()
        {
            var message = new Tweet("created");
            var expactedMsg = "created";
            Assert.AreEqual(message.Message, expactedMsg);
        }

        [Test]
        public void ReceivingMessageByClientTest()
        {
            var client = new Client();
            var message = new Tweet("ReceiveIt");
            client.RetrieveMessage(message);
            Assert.IsTrue(client.Server.Contains(message));
        }
    }
}