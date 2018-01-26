using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class TextFormats
    {
        public static string HebrewLetters => GetRangeOfChers('א','ת');
        public static string EnglishLetters => GetRangeOfChers('a', 'z')+ GetRangeOfChers('A', 'Z');
        public static string Numrics => GetRangeOfChers('0', '9');
        public static string Letters => HebrewLetters + EnglishLetters;
        private static string GetRangeOfChers(char first, char end)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (char i = first; i <= end; i++)
            {
                stringBuilder.Append(i);
            }
            return stringBuilder.ToString();
        }
    }
}
