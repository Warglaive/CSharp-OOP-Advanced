using System;
using System.Text;

public class Engine
{
    public void Run()
    {
        var input = ConsoleReader.ReadLine();
        var gameController = new GameController();
        var result = new StringBuilder();

        while (!input.Equals("Enough! Pull back!"))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }
            input = ConsoleReader.ReadLine();
        }

        gameController.RequestResult(result);
        ConsoleWriter.WriteLine(result.ToString());
    }
}