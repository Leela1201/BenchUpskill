using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class CountofRepeatedChars
    {
        public static void Main()
        {
            string str = "leelaPadmaja";
            Console.WriteLine("String: " + str);
            //Remove the empty spaces from the message
            //str = str.Replace(" ", string.Empty);
            while (str.Length > 0)
            {
                Console.Write(str[0] + " = ");
                int cal = 0;
                for (int j = 0; j < str.Length; j++)
                {
                    if (str[0] == str[j])
                    {
                        cal++;
                    }
                }
                Console.WriteLine(cal);
                str = str.Replace(str[0].ToString(), string.Empty);
            }
            Console.ReadLine();
        }
    }
}
//Here in the following program, we take the input from Console and then remove the blank spaces from the input if any. Check the length of the input message and if it is greater than 0, then using for loop we calculate the number of occurrences of each character,


