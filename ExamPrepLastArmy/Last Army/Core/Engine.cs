using System;
using System.Text;

public class Engine
{
    private const string EnoughtPullBack = "Enough! Pull back!";
    private IReader Reader;
    private IWriter Writer;
    public Engine(IReader reader, IWriter writer)
    {
        this.Reader = reader;
        this.Writer = writer;
    }
    public void Run()
    {
        var input = this.Reader.ReadLine();
        var gameController = new GameController(this.Writer);

        while (!input.Equals(EnoughtPullBack))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                Writer.AppendLine(arg.Message);
            }
            input = this.Reader.ReadLine();
        }

        gameController.RequestResult();
        Writer.WriteLineAll();
    }
}