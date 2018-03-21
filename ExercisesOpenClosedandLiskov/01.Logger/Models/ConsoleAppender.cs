using System;
using System.Collections.Generic;
using System.Text;
using Logger.Models.Contracts;

namespace Logger.Models
{
    public class ConsoleAppender : IAppender
    {
        public ConsoleAppender(ILayout layout, ErrorLevel level)
        {
            this.Layout = layout;
            this.Level = level;
            this.MessagesAppended = 0;
        }

        public ErrorLevel Level { get; }

        public int MessagesAppended { get; private set; }

        public ILayout Layout { get; }

        public void Append(IError error)
        {
            string formatedError = this.Layout.FormatError(error);
            this.MessagesAppended++;
            Console.WriteLine(formatedError);
        }

        public override string ToString()
        {
            var result = $"Appender type: {this.GetType().Name}" +
                         $", Layout type: {this.Layout.GetType().Name}" +
                         $", Report level: {Level}" +
                         $", Messages appended: {this.MessagesAppended}";
            return result;
        }
    }
}
