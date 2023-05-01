using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class Uniquechar
    {

        public static void Main()
        {
            Console.WriteLine("Enter any String");
            String str = Console.ReadLine();

            for (int i = 0; i < str.Length; i++)
            {

                int flag = 0;
                for (int j = 0; j < str.Length; j++)
                {

                    // checking if two characters are equal
                    if (str[i] == str[j] && i != j)
                    {
                        flag = 1;
                        break;
                    }
                }

                if (flag == 0)
                    Console.Write(str[i]);
            }



        }
    }
}
//to sort this logic we use two for loops ,  Outer loop will be used to select a character and initialize variable count by 1.
//than we use logical and condition the array of outer loop should be eqal to aaray of inner for loop,,inner for loop is used to compare the charcters in the outer for loop ,if characters doest match than flag should be equal to 1,
    


