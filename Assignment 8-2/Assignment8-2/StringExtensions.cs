using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8_2
{
    static public class StringExtensions
    {
        public static string UppercaseFirst(this String s)
        {
            // Not the smartest way to validate for null or empty string, but we want to practice try-catch, so...
            try
            {
                char[] charArray = s.ToCharArray();
                charArray[0] = char.ToUpper(charArray[0]);
                return new string(charArray);
            }
            catch
            {
                return string.Empty;
            }

            /* The try/catch can be easily bypassed by using the following code:
             *  if (string.isNullOrEmpty(s)
             *      return string.Empty;
             */
        }

    }
}
