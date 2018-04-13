using System;
using System.Collections.Generic;
using _06.Twitter.Interfaces;

namespace _06.Twitter.Models
{
    public class Client : ITweet, IClient
    {
        public List<Tweet> Server;
        public void RetrieveMessage(Tweet message)
        {
            this.Server = new List<Tweet>();
            WriteTweetOnConsole(message);
            SendTweetToServer(message);
        }

        public void WriteTweetOnConsole(Tweet message)
        {
            Console.WriteLine(message.Message);
        }

        public void SendTweetToServer(Tweet message)
        {
            this.Server.Add(message);
        }
    }
}