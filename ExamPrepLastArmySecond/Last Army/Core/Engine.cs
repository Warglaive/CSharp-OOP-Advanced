﻿using System;
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
        var gameController = new GameController();
        var result = new StringBuilder();

        while (!input.Equals(EnoughtPullBack))
        {
            try
            {
                gameController.GiveInputToGameController(input);
            }
            catch (ArgumentException arg)
            {
                result.AppendLine(arg.Message);
            }
            input = reader.ReadLine();
        }

        //gameController.RequestResult(result);
        this.writer.AppendLine(result.ToString());
    }
}