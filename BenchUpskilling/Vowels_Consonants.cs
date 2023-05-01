using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BenchUpskilling
{
    internal class Vowels_Consonants
    {
        public static void Main()
        {
            Console.WriteLine("Enter Any String  :");
            string str = Console.ReadLine();
            int i, len, vowels, consonants;


            vowels = 0;
            consonants = 0;


            // Iterating the string from left to right
            for (i = 0; i < str.Length; i++)
            {

                // Check if the character is a vowel
                if (str[i] == 'a' || str[i] == 'e' ||
                    str[i] == 'i' || str[i] == 'o' ||
                    str[i] == 'u' || str[i] == 'A' ||
                    str[i] == 'E' || str[i] == 'I' ||
                    str[i] == 'O' || str[i] == 'U')
                {

                    // Increment the vowels
                    vowels++;
                }

                // Check if the character is a alphabet
                // other than vowels
                else if ((str[i] >= 'a' && str[i] <= 'z') ||
                         (str[i] >= 'A' && str[i] <= 'Z'))
                {

                    // Increment the consonants
                    consonants++;
                }
            }

            // Display the count of vowels and consonant
            Console.WriteLine("count of vowel = " + vowels);
            Console.WriteLine("count of consonant = " + consonants);
        }
    }
}
//Store the string using string datatype.
//Declare two variables to count the number of vowels and consonants.
//Now using the length property find the length of the given string
//Now iterate the string from left to right and check if the character is either vowel or a consonant.
//If the character encountered is a vowel increase the count of vowel else increases the count of consonant.



