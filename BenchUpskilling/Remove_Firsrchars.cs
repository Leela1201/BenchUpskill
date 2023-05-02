using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class Remove_Firsrchars
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("enter the two strings");
            string s1 = Console.ReadLine();
            string s2 = Console.ReadLine();
            string result = "";
            foreach (char c in s1)
            {
                if (!s2.Contains(c))
                {
                    result += c;
                }
            }
            Console.WriteLine("characters are :" + result);


        }
    }
}
