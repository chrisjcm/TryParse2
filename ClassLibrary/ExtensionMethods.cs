using System;

namespace ClassLibrary
{
    public static class ExtensionMethods
    {
        public static bool TryParse2(this string s, out int result)
        {
            int num = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    result = 0;
                    return false;
                }

                num *= 10;
                num += c - '0';
            }
            
            result = num;
            return true;
        }

        public static (bool isNum, int num) TryParse2(this string s)
        {
            int num = 0;

            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    return (false, 0);
                }

                num *= 10;
                num += c - '0';
            }

            return (true, num);
        }
    }
}
