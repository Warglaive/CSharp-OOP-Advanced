using _06.Twitter.Models;

namespace _06.Twitter.Interfaces
{
    public interface IClient
    {
        void WriteTweetOnConsole(Tweet message);
        void SendTweetToServer(Tweet message);
    }
}