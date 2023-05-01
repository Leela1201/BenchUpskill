using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class ArmstrongNumber
    {
        public static void Main()
        {

            int number, rem, temp, sum = 0;
          
            Console.Write("Enter Your Number To Check :: ");
            number = Convert.ToInt32(Console.ReadLine());

            temp = number;
            while (number > 0)
            {
                rem = number % 10;
                sum = sum + (rem * rem * rem);
                number = number / 10;
            }

            if (temp == sum)
                Console.WriteLine(temp + " Is A Armstrong Number");
            else
                Console.WriteLine(temp + " Is Not A Armstrong Number");
            Console.ReadKey();
        }
    }
}
