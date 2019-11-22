using ClassLibrary;
using System;

namespace TryParse2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter number: ");
                string s = Console.ReadLine();

                if (!s.TryParse2().isNum)
                {
                    Console.WriteLine("Not a number");
                }
                else
                {
                    Console.WriteLine("Result is: " + s.TryParse2().num);
                }
            }
        }
    }
}
