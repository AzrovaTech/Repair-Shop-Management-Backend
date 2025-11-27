using System.Globalization;

namespace AM.Core.Tools
{
    public static class DateTimeExtensions
    {
        public static string ToPersian(this DateTime date)
        {
            PersianCalendar pc = new PersianCalendar();
            return $"{pc.GetYear(date):0000}/{pc.GetMonth(date):00}/{pc.GetDayOfMonth(date):00}";
        }
    }
}
