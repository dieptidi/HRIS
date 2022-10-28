using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace HRIS.Provider.Helpers
{
    public static class Helper
    {
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd MMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        public static string FormatName(string firstName, string lastName, string gender)
        {
            if (gender.ToUpper() == "M")
            {
                string title = "Mr";
                return $"{title}. {firstName} {lastName}";
            }
            else
            {
                string title = "Ms";
                return $"{title}. {firstName} {lastName}";
            }
        }

        public static string FormatRupiah(decimal money) 
        {
            return money.ToString("c", CultureInfo.CreateSpecificCulture("id-ID"));
        }
    }
}
