using System;

namespace SteelManagement.Common
{
    public class SerialNoGenerator
    {
        public static string GetSerialNo()
        {
            return DateTimeFormator.DateTimeToString(DateTime.Now, DateTimeFormator.TimeFormat.Type02SerialNo);
        }

    }
}
