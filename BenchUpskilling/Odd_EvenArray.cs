using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class Odd_EvenArray
    {
        public static void Main()
        {
            //declare an array
            int[] arr = new int[5];
            Console.WriteLine("Enter Array Elements");
            //read the elements
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Enter element {i + 1}:");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            //to print
            Console.WriteLine("Even Numbers");
            for(int i=0;i<arr.Length;i++)
            {
                if (arr[i] % 2 == 0)
                {
                    Console.WriteLine(arr[i]);
                }
               

                else if (arr[i]%2 !=0)
                {
                    Console.WriteLine("OddNumbers");
                    Console.WriteLine(arr[i]);
                }
            }

        }

    }
}

   
