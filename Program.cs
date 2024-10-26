using System;

namespace ConsoleApp7
{
    internal class Program
    {
        public static string RemoveSpaces(string input)
        {
            return input.Replace(" ", ""); 
        }

        static void Main()
        {
            string str = "Code Academy"; 
            Console.WriteLine("Original String: " + str);

          
            str = RemoveSpaces(str);

   
            Console.WriteLine("String without spaces: " + str);
            Console.ReadLine();
        }
    }
}
