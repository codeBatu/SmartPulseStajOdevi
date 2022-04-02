using System;

namespace Batu.Exam.SmartpulseInternship.RepositoryLayer.Util
{
    public class DateTimeConvertString
    {
        public static string StringParser(string data)
        {
            string dataReplace = data.Replace("PH22", "2022");
            string YourOutput = DateTime.ParseExact(dataReplace, "yyyyMMddH", System.Globalization.CultureInfo.InvariantCulture).ToString("dd.MM.yyyy HH:mm", System.Globalization.CultureInfo.InvariantCulture);
            return YourOutput;
        }
    }
}
