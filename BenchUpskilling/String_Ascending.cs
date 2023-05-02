using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class String_Ascending
    {
        public static void Main(string[] args)
        {
            //to read the name and print the letters in ascending order
            Console.WriteLine("enter the name: ");
            string s = Console.ReadLine();
            char[] name = s.ToCharArray();
            Array.Sort(name);
            string newS1 = new string(name);
            Console.WriteLine("letters in ascending order");
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine(newS1[i]);
            }



        }

    }
}
