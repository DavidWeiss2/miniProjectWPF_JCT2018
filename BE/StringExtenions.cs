using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BE
{
    static public class StringExtenions
    {
        public static (bool[] workingDays, int[][] workingHours) ParseWeekSched(this string @str, int numberOfWorkingDays = 7, int timeSlots = 1)
        {
            @str.IsNull(nameof(@str));
            timeSlots *= 2;//for start and end time
            foreach (char c in @str)
            {
                if ("0123456789._;".IndexOf(c) == -1)
                    throw new FormatException($"The format of the string in {nameof(ParseWeekSched)} is in invaild format.");
            }
            string[] weekHolder = @str.Split(';');
            if (weekHolder.Length != numberOfWorkingDays)
                throw new FormatException($"Week have excecly {numberOfWorkingDays} days thrown by: {nameof(ParseWeekSched)}.");
            List<bool> workingDays = new List<bool>(numberOfWorkingDays);
            List<int[]> workingHours = new List<int[]>(numberOfWorkingDays);
            for (int i = 0; i < numberOfWorkingDays; i++)
            {
                string dayHolder = weekHolder[i];
                string[] dayTimeHolder = dayHolder.Split('.');
                if (dayTimeHolder.Length != timeSlots)
                    throw new FormatException($"Every day most contain start and end time format. To exclude a day please write \"____\".");
                int[] workingHoursInThisDay = new int[timeSlots];
                for (int j = 0, flag = 0; j < timeSlots && flag == 0; j++)
                {
                    workingDays[i] |= dayTimeHolder[j] != "____" && dayTimeHolder[j].Length == 4;
                    if (workingDays[i])
                        workingHoursInThisDay[j] = int.Parse(dayTimeHolder[j]);
                }
            }
            return (workingDays: workingDays.ToArray(), workingHours: workingHours.ToArray());
        }

        public static bool ToBool(this string @str) => @str == "1" || @str == "0" ? @str == "1" : bool.Parse(@str);

        public static Child ToChild(this string @str) => new Child(@str.ToLong());

        public static Contract ToContract(this string @str) => new Contract(@str.ToLong());

        public static int ToInt(this string @str) => int.Parse(@str);

        public static DateTime ToDateTime(this string @string) => DateTime.Parse(@string);

        public static long ToLong(this string @str) => long.Parse(@str);

        public static Mother ToMother(this string @str) => new Mother(@str.ToLong());

        public static Nanny ToNanny(this string @str) => new Nanny(@str.ToLong());
        
        public static string Append(this string text, string addText)
        {
            if (text.IsNull(text).IsErrorOccurred)
                text = "";
            else
                text += "\n";
            return text + addText;
        }

        public static int GetInt(this string[] args, string nameOfField) => (int)GetType(args, nameOfField, typeof(int));

        public static object GetType(this string[] args, string nameOfField,Type t)
        {
            nameOfField.IsNull(nameof(nameOfField));
            string itemValue=null;
            for (int i = 1; i < args.Length; i+=2)
            {
                if (args[i]==nameOfField)
                {
                    itemValue=args[i + 1];
                    break;
                }
            }
            if (itemValue.IsNull(nameOfField).IsErrorOccurred) return null;
            if (t.Equals(typeof(string)))
                return itemValue;
            if (t.Equals(typeof(int)))
                return itemValue.ToInt();
            if (t.Equals(typeof(long)))
                return itemValue.ToInt();
            if (t.Equals(typeof(Mother)))
                return itemValue.ToMother();
            if (t.Equals(typeof(Child)))
                return itemValue.ToInt();
            if (t.Equals(typeof(Contract)))
                return itemValue.ToContract();
            if (t.Equals(typeof(Nanny)))
                return itemValue.ToNanny();
            if (t.Equals(typeof(bool)))
                return itemValue.ToBool();
            if (t.Equals(typeof(DateTime)))
                return itemValue.ToDateTime();
            throw new NotSupportedException($"Can't convert from string to {t.Name}, please ask the devs to support this opertion");
        }
    }
}

