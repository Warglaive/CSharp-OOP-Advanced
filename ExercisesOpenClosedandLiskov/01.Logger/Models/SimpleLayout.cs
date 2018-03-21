using System;
using System.Globalization;
using Logger.Models.Contracts;

namespace Logger.Models
{
    public class SimpleLayout : ILayout
    {
        private const string DateFormat = "M/d/yyyy h:mm:ss tt";
        private const string Format = "{0} - {1} - {2}";

        public string FormatError(IError error)
        {
            var dateString = error.DateTime.ToString(DateFormat
                , CultureInfo.InvariantCulture);
            var formattedError = string.Format(Format
                , dateString
                , error.Level.ToString()
                , error.Message);
            return formattedError;
        }
    }
}
