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
    }
}
