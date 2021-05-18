using System;
using System.Collections.Generic;

namespace BreakCamelCase
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(BreakCamelCase("HelloWorld"));
        }

        private const string Separator = " ";
        public static List<char> alpha = new() { "A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P",
                                                    "Q","R","S","T","U","V","W","X","Y","Z" };
        public static string BreakCamelCase(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                
                if (str == "")
                {
                    return str;
                }
                else if (alpha.C str[i].Equals(alpha))
                {
                    str.Split(separator: Separator, count: i);
                    
                }
                else
                {
                    return str;
                }
            }
            return str;
        }
    }
}
