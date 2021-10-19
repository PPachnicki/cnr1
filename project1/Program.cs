using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("What is your name?");
            string ans = Console.ReadLine();
            Console.WriteLine($"Hello {ans}!");

            Console.WriteLine("Are you OK today?");

            string myday = Console.ReadLine();

            if(myday.ToLower().StartsWith("y")) //alternative to the line blow 
            //if(myday == "Yes" || myday =="yes" || myday == "Yes" || myday == "YES" || myday =="y" || myday == "Y")
            {
                Console.WriteLine("Lovely!");
            }
            else{
                Console.WriteLine("Grink some cofee than!");
            }
            /* random questions not completed */

        }
    }
}
