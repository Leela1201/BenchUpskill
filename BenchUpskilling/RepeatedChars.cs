using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class RepeatedChars
    {
        public static void Main()
        {
            Console.Write("Enter Any String :");
            String str = Console.ReadLine();
            int count;

            //Converts given string into character array  
            char[] string1 = str.ToCharArray();

            Console.WriteLine("Duplicate characters in a given string: ");
            //Counts each character present in the string  
            for (int i = 0; i < string1.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < string1.Length; j++)
                {
                    if (string1[i] == string1[j] && string1[i] != ' ')
                    {
                        count++;
                        //Set string1[j] to 0 to avoid printing visited character  
                        string1[j] = '0';
                    }
                }
                //A character is considered as duplicate if count is greater than 1  
                if (count > 1 && string1[i] != '0')
                    Console.WriteLine(string1[i]);
            }
        }
    }
}
//Define a string.
//Define a string.
//Two loops will be used to find the duplicate characters. Outer loop will be used to select a character and initialize variable count by 1.
//Inner loop will compare the selected character with rest of the characters present in the string.
//If a match found, it increases the count by 1 and set the duplicates of selected character by '0' to mark them as visited.
//After inner loop, if count of character is greater than 1, then it has duplicates in the string.




