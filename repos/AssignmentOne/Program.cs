using System;

namespace NumberValidationApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter a number in the range of 1-10: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num >= 1 && num <= 10)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}

