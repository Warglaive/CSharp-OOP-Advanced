using Logger.Models.Contracts;

namespace Logger.Models.Factories
{
    public class FileAppender : IAppender
    {
        private LogFile logFile;
        public FileAppender(ILayout layout, ErrorLevel errorLevel, LogFile logFile)
        {
            this.Layout = layout;
            this.Level = errorLevel;
            this.logFile = logFile;
            this.MessagesAppended = 0;
        }

        public ErrorLevel Level { get; }

        public ILayout Layout { get; }

        public int MessagesAppended { get; private set; }

        public void Append(IError error)
        {
            var formattedError = this.Layout.FormatError(error);
            this.logFile.WriteToFile(formattedError);
            this.MessagesAppended++;
        }

        public override string ToString()
        {
            var result = $"Appender type: {this.GetType().Name}" +
                         $", Layout type: {this.Layout.GetType().Name}" +
                         $", Report level: {Level}" +
                         $", Messages appended: {this.MessagesAppended}" +
                         $", File size: {this.logFile.Size}";
            return result;
        }
    }
}