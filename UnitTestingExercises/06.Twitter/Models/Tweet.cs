namespace _06.Twitter.Models
{
    public class Tweet
    {
        public string Message { get; set; }

        public Tweet(string message)
        {
            this.Message = message;
        }
    }
}