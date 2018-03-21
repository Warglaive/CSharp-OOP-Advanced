using System;
using System.Collections;
using System.Collections.Generic;
using Logger.Models;
using Logger.Models.Contracts;
using Logger.Models.Factories;

namespace Logger
{
    public class StartUp
    {
        public static void Main()
        {
            ILogger logger = initializeLogger();
            var errorFactory = new ErrorFactory();
            Engine engine = new Engine(logger, errorFactory);
            engine.Run();
        }

        static ILogger initializeLogger()
        {
            ICollection<IAppender> appenders = new List<IAppender>();
            var layoutFactory = new LayoutFactory();
            var appenderFactory = new AppenderFactory(layoutFactory);

            var appenderCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < appenderCount; i++)
            {
                var args = Console.ReadLine().Split();
                var appenderType = args[0];
                var layoutType = args[1];
                var errorLevel = "INFO";
                if (args.Length == 3)
                {
                    errorLevel = args[2];
                }
                IAppender appender = appenderFactory.CreateAppender(appenderType, errorLevel, layoutType);
                appenders.Add(appender);
            }
            ILogger logger = new Models.Logger(appenders);
            return logger;
        }
    }
}