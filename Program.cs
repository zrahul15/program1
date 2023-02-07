// See https://aka.ms/new-console-template for more information

using System;
namespace rahul
{
    class Paper
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Total no of Papers: ");
            int papers = Convert.ToInt32(Console.ReadLine());


            if (papers == 0)
            {
                Console.WriteLine("No Papers ");
            }
            else if (papers < 10)
            {
                Console.WriteLine("Less Papers");
            }
            else if (papers > 10)
            {
                Console.WriteLine("Ready");
            }
        }

    }
}

