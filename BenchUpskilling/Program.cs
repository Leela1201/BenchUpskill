namespace BenchUpskilling
{
    internal class reversestring
    {
        static void Main(string[] args)
        {
        static void Main(string[] args)
        {
            Console.Write("Enter a String : ");
            string originalString = Console.ReadLine();
            Console.WriteLine("Enter String2 : ");
            string str2 = Console.ReadLine();

            string reverseString = string.Empty;
            for (int i = originalString.Length - 1; i >= 0; i--)
            {
                reverseString += originalString[i];


            }


            if (str2 == reverseString)
            {
                Console.WriteLine("Equals");
            }
            else
            {
                Console.WriteLine("Not Equals");
            }
            Console.Write($"Reverse String is : {reverseString} ");
            Console.ReadLine();


        }
    }
    }
}