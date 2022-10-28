using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Reflection;

namespace HRIS.Provider.Helpers
{
    public static class Helper
    {
        public static string FormatDate(DateTime date)
        {
            return date.ToString("dd MMM yyyy", CultureInfo.CreateSpecificCulture("id-ID"));
        }

        /// <summary>
        /// Mendapatkan seluruh properties dari sebuah object
        /// </summary>
        /// <param name="instance">object yang ingin di check</param>
        /// <returns>properties in array</returns>
        public static PropertyInfo[] GetProperties(object instance)
        {
            return instance.GetType().GetProperties();
        }

        /// <summary>
        /// Fungsi ini berperan sebagai object mapper yang memindahkan values dari seluruh properties yang ada dari object from ke object to.
        /// </summary>
        /// <param name="from">object from</param>
        /// <param name="to">object to</param>
        public static void CopyProperties(object from, object to)
        {
            var fromProperties = GetProperties(from);
            var toProperties = GetProperties(to);

            foreach (var fromProperty in fromProperties)
            {
                var propertyName = fromProperty.Name;
                var propertyValue = fromProperty.GetValue(from);
                var propertyType = fromProperty.PropertyType;

                foreach (var toProperty in toProperties)
                {
                    if (toProperty.Name == propertyName && toProperty.PropertyType == propertyType)
                    {
                        toProperty.SetValue(to, propertyValue);
                        break;
                    }
                }
            }
        }
    }
}
