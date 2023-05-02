using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class Permutationof_String
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter a string");
            string str = Console.ReadLine();
            int n = str.Length;
            permute(str, 0, n - 1);
        }

        public static void permute(string str, int l, int r)
        {
            int i;
            if (l == r)
                Console.WriteLine(str);
            else
            {
                for (i = 1; i <= r; i++)
                {
                    str = Swap(str, l, i);
                    permute(str, l + 1, r);
                    str = Swap(str, l, i);
                }
            }
        }



        public static string Swap(string a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            string s = new string(charArray);
            return s;
        }
    }
}
