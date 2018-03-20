using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            var progressInfo = new StreamProgressInfo(new File("Cigansko", 100, 1000));
            var progressInfo2 = new StreamProgressInfo(new Music("Azis", "Churulike", 15, 100));
        }
    }
}
