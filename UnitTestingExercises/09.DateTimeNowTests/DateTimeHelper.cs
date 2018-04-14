using System;

namespace _09.DateTimeNow
{
    public class DateTimeHelper : IGetDateTime
    {
        public DateTime GetDateTimeNow()
        {
            return DateTime.Now;
        }
    }
}