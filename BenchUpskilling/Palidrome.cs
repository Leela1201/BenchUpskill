using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class Palidrome
    {
        public static void Main()
        {
            Console.WriteLine("Enter a num");
            int n = Convert.ToInt32(Console.ReadLine());

            int rem, sum, n2;
            n2 = n;
            sum = 0;
            while (n > 0)
            {
                rem = n % 10;
                sum = sum * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reverse of Num:" + sum);
            if (n2 == n)
            {
                Console.WriteLine("The given num is palindrome");
            }
            else
            {
                Console.WriteLine("The given is not palindrome");
            }


        }
    }
}
