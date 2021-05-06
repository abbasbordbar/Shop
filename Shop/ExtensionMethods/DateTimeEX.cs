using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;

namespace Shop.ExtensionMethods
{
    public static class DateTimeEX
    {
        public enum PersianMonth {فروردین=1,اردیبهشت,خرداد,تیر ,مرداد ,شهریور ,مهر ,ابان ,اذر ,دی ,بهمن ,اسفند};
        public static string GetMonthPersian(this DateTime dt)
        {
            PersianCalendar pc = new PersianCalendar();
            string Month = ((PersianMonth)pc.GetMonth(dt)).ToString();
            return pc.GetDayOfMonth(dt) + "" + Month + "" + pc.GetYear(dt);

        }
    }
}
