using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class SmallestSumofConsecutive_Nums
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[5];
            int i;
            int[] j = new int[4];
            Console.WriteLine("Enter Elements Into an Array:");
            for (i = 0; i < arr.Length; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine($"Sum of all the elements in the array was {arr.Sum()}");
            for (i = 0; i < arr.Length - 1; i++)
            {
                j[i] = arr[i] + arr[i + 1];
            }
            Console.WriteLine($"Smallest Sum Of Consecutive Numbers In An Array Was: {j.Min()} ");
        }
    }
}
