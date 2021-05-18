using System;
using System.Collections.Generic;
using System.Linq;

namespace BitCounting
{
    class Program
    {
        static void Main(string[] args)
        {
            CountBits(6);
        }


        public static int CountBits(int n)
        {
            var count = n.ToString().Count();
            count += 1;
            Console.WriteLine(count);
            return count;
        }
       
    }
}
