using System;
using System.Text;

public class Engine
{
    private readonly ConsoleReader reader;
    private readonly ConsoleWriter writer;
    private const string EnoughtPullBack = "Enough! Pull back!";

    public Engine()
    {
        this.reader = new ConsoleReader();
        this.writer = new ConsoleWriter();
    }
    public void Run()
    {
        var input = reader.ReadLine();
        var gameController = new GameController(this.writer);
        var result = new StringBuilder();

        while (!input.Equals(EnoughtPullBack))
        {
            try
            {
                result.AppendLine(gameController.GiveInputToGameController(input));
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }
            input = reader.ReadLine();
        }

        this.writer.AppendLine(result.ToString());
        Console.WriteLine(this.writer.WriteAllLines());
    }
}