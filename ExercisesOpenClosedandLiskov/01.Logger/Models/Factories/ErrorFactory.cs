using System;
using System.Globalization;
using Logger.Models.Contracts;

namespace Logger.Models.Factories
{
    public class ErrorFactory
    {
        private const string DateFormat = "M/d/yyyy h:mm:ss tt";

        public IError CreateError(string dateTimeString, string errorLevelString, string message)
        {
            var dateTime = DateTime.ParseExact(dateTimeString, DateFormat, CultureInfo.InvariantCulture);
            ErrorLevel errorLevel = ParseErrorLevel(errorLevelString);
            IError error = new Error(dateTime, errorLevel, message);


            return error;
        }

        private ErrorLevel ParseErrorLevel(string levelString)
        {
            try
            {
                object levelObject = Enum.Parse(typeof(ErrorLevel), levelString);
                return (ErrorLevel)levelObject;
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Invalid ErrorLevelType", e);
            }
        }
    }
}