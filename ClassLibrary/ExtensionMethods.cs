using System;

namespace ClassLibrary
{
    public static class ExtensionMethods
    {
        public static bool TryParse2(this string s, out int result)
        {
            bool isNum = false;
            int num = 0;

            foreach (char c in s)
            {
                if (char.IsDigit(c))
                {
                    num *= 10;
                    num += c - '0';
                    isNum = true;

                    continue;
                }
                num = 0;
                break;
            }
            
            result = num;

            return isNum;
        }

        public static (bool isNum, int num) TryParse2(this string s)
        {
            bool isNum = true;
            int num = 0;

            foreach (char c in s)
            {
                if (!char.IsDigit(c))
                {
                    isNum = false;
                    num = 0;
                    break;
                }

                num *= 10;
                num += c - '0';
            }

            return (isNum, num);
        }
    }
}
