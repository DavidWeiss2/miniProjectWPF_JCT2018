using System;

namespace BE
{
    //will check if thare a need for exception, if so, return error massage and leave object
    /// <summary>
    /// Defines the <see cref="MyExceptionsAvoider" />
    /// </summary>
    public static class MyExceptionsAvoider
    {
        #region Methods

        public static Result<string> IsFormated(this string @str, string allowedChars, string strName)
        {
            Result<string> result = allowedChars.IsNull(nameof(allowedChars));
            result += strName.IsNull(nameof(allowedChars));
            foreach (char c in @str)
            {
                if (allowedChars.IndexOf(c) == -1)
                    result += new FormatException($"The String in {strName}: \'{@str}\' can contain only this simboles '{allowedChars}', the char '{c}' is invaild simbole and throw the error.");
            }
            return result;
        }

        public static Result<DateTime> IsInDateRange(DateTime date, DateTime min, DateTime max, string dateName) => (Result<DateTime>)IsInRange(date, date <= max && date >= min, dateName, max.ToString(), min.ToString());

        public static Result<long> IsInHumanRange(long item, string itemName) => (Result<long>)IsInRange(item, item <= 999999999 && item >= 1, itemName, "999999999", "0");

        public static Result<object> IsInRange(this object item, bool compere, string itemName, string max = "", string min = "")
        {
            if (compere)
                return new Result<object>(item);
            if (!string.IsNullOrEmpty(max) && !string.IsNullOrEmpty(min))
                return new Result<object>(item, new ArgumentOutOfRangeException(itemName, item, $"{itemName} most be between or equal to '{max}' and '{min}', {itemName} as value of {item.ToString()}."));
            if (string.IsNullOrEmpty(max) && !string.IsNullOrEmpty(min))
                return new Result<object>(item, new ArgumentOutOfRangeException(itemName, item, $"{itemName} most be greater or equal to '{min}', {itemName} as value of {item.ToString()}."));
            if (!string.IsNullOrEmpty(max) && string.IsNullOrEmpty(min))
                return new Result<object>(item, new ArgumentOutOfRangeException(itemName, item, $"{itemName} most be lower  or equal to '{max}', {itemName} as value of {item.ToString()}."));
            return new Result<object>(item, new ArgumentOutOfRangeException(itemName, item, $"{itemName} not have a valid value, {itemName} as value of {item.ToString()}."));
        }

        public static Result<object> IsNull(this object @object, string strName)
        {
            if (@object == null)
                return new Result<object>(@object, new ArgumentNullException(strName, $"Exccapted a value to be passed."));
            return new Result<object>(@object);
        }

        public static Result<string> IsNull(this string @string, string strName)
        {
            if (string.IsNullOrEmpty(@string) || string.IsNullOrWhiteSpace(@string))
                return new Result<string>(@string, new ArgumentNullException(strName, $"Excepted a value to be passed."));
            return new Result<string>(@string);
        }

        public static Result<string> ThrowNull(this string nameof) => new Result<string>(nameof, new ArgumentNullException(nameof, $"{nameof} Have a value of 'NULL' or 0."));

        #endregion
    }
}
