using System;
using System.Collections.Generic;
using System.Text;

namespace ASM_BT573_De2.util
{
    class Utils
    {
        public static DateTime ConvertStringToDatetime(string datetime)
        {
            return DateTime.ParseExact(datetime, "dd-MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
        }

        public static string ConvertDatetimeToString(DateTime dateTime)
        {
            return dateTime.ToString("dd-MM-yyyy");
        }
    }
}
