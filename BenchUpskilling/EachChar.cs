using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class EachChar
    {
        public static void Main()
        {
            string str = "Leela";

            foreach (char c in str)
            {
                Console.WriteLine("." + c);
            }

        }
    }
}
