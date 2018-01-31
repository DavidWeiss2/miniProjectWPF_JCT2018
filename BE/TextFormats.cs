using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public static class TextFormats
    {
        public static string HebrewLetters => GetRangeOfChars('א','ת');
        public static string EnglishLetters => GetRangeOfChars('a', 'z')+ GetRangeOfChars('A', 'Z');
        public static string Numrics => GetRangeOfChars('0', '9');
        public static string Letters => HebrewLetters + EnglishLetters;
        public static string GetRangeOfChars(char first, char end)
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
