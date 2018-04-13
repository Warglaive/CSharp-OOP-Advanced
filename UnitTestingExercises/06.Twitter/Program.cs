using _06.Twitter.Models;

namespace _06.Twitter
{
    public class Program
    {
        public static void Main()
        {
            var tweet = new Tweet("testMsg");
            var client = new Client();
            client.RetrieveMessage(tweet);
        }
    }
}