using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class StringtoInteger
    {
        public static void Main()
        {
            //3 types 
            //1) Int32Parse()
            //2)Convert.ToInt32
            //3)TryParse()
            string str = "100";
            int a = Int32.Parse(str);
            Console.WriteLine(a);



            //Here, we have used TryParse() method, the difference in Parse() and TryParse() method is only that TryParse() method always return the value it will never throw an exception.

            // Taking a string2
            string l = "10000000000";
            int length = 0;

            // using the method
            Int32.TryParse(l, out length);

            // Finding the area of a square
            int aofs = length * length;

            Console.WriteLine("Area of a circle is: {0}", aofs);



            //Here, we have used Convert.ToInt32() method, the difference in Parse() and Convert.ToInt32() method is only that Convert.ToInt32() method always accept the null value return it.

            string l1 = null;
            try
            {
                int length1 = Convert.ToInt32(l1);

                // Finding the area of a square
                int aof = length1 * length1;

                Console.WriteLine("Area of a circle is: {0}", aofs);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unable to convert:Exception:" + e.Message);
            }
        }

    }


}


