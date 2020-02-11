using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace MailSender.lib.Service
{
    /// <summary>
    /// Шифр Цезаря - распространяется только на буквы латинского алфавита
    /// </summary>
    public static class TextEncoder
    {
        public static string Encode(this string source, int key = 1)
        {
            if (key < 0)
                return Decode(source, Math.Abs(key));

            string result = new string(source.Select(c =>
            {
                if (!char.IsLetter(c))
                    throw new ArgumentNullException();

                char symbol = (char)(c + key);

                char startSymbol = char.IsUpper(c) ? 'A' : 'a';
                char stopSymbol = char.IsUpper(c) ? 'Z' : 'z';

                return !char.IsLetter(symbol) ? (char)(startSymbol + (key - (stopSymbol - c) - 1)) : symbol;
            }).ToArray());

            return result;
        }

        public static string Decode(this string source, int key = 1)
        {
            if (key < 0)
                return Encode(source, Math.Abs(key));

            string result = new string(source.Select(c =>
            {
                if (!char.IsLetter(c))
                    throw new ArgumentNullException();

                char symbol = (char)(c - key);
                
                char startSymbol = char.IsUpper(c) ? 'A' : 'a';
                char stopSymbol = char.IsUpper(c) ? 'Z' : 'z';

                return !char.IsLetter(symbol) ? (char)(stopSymbol - (key - (c - startSymbol) - 1)) : symbol;
            }).ToArray());

            return result;
        }
    }
}
