using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class Difference_equals
    {
        public static void Main()
        {
            //equalto
            int i, count = 1;
            Console.WriteLine("Enter Any Number");
            int n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= n / 2; i++)
            {
                //equals
                if (n % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("PrimeNumber");
            }
            else
            {
                Console.WriteLine("Not Prime");
            }

        }
    }
}


