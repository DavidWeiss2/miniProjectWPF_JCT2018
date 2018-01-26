using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class MyExceptions
    {
        public static string IsNotNull(this string str, string strName)
        {
            if (string.IsNullOrEmpty(str) || string.IsNullOrWhiteSpace(str))
                throw new ArgumentNullException(strName, $"Excepted a value to be passed.");
            return str;
        }
        public static void ThrowNull(this string _nameof) => throw new ArgumentNullException(_nameof, $"{_nameof} Have a value of 'NULL' or 0."); 
        public static string IsFormated(this string str, string allowedChers, string strName)
        {
            allowedChers.IsNotNull(nameof(allowedChers));
            strName.IsNotNull(nameof(allowedChers));
            foreach (char c in str)
            {
                if (allowedChers.IndexOf(c) == -1)
                    throw new FormatException($"The String in {strName}: \'{str}\' can contain only this simboles '{allowedChers}', the char '{c}' is invaild simbole and throw the error.");
            }
            return str;
        }
        public static object IsInRange(this object item, bool compere, string itemName, string max = "", string min = "")
        {
            if (compere)
                return item;
            if (max != "" && min != "")
                throw new ArgumentOutOfRangeException(itemName, item, $"{itemName} most be between or equal to '{max}' and '{min}', {itemName} as value of {item.ToString()}.");
            if (max == "" && min != "")
                throw new ArgumentOutOfRangeException(itemName, item, $"{itemName} most be greater or equal to '{min}', {itemName} as value of {item.ToString()}.");
            if (max != "" && min == "")
                throw new ArgumentOutOfRangeException(itemName, item, $"{itemName} most be lower  or equal to '{max}', {itemName} as value of {item.ToString()}.");
            throw new ArgumentOutOfRangeException(itemName, item, $"{itemName} not have a valid value, {itemName} as value of {item.ToString()}.");
        }
        public static long IsInHumanRange(this long item, string itemName) => (long)IsInRange(item, item <= 999999999 && item >= 1, itemName, "999999999", "0");
        public static DateTime IsInDateRange(this DateTime date, DateTime min, DateTime max, string dateName) => (DateTime)IsInRange(date, date <= max && date >= min, dateName, max.ToString(), min.ToString());
    }
}
