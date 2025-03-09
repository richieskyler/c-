using System;

namespace NumberComparisonApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter First Number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second Number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("The Maximum Number is: " + num1);
            }
            else
            {
                Console.WriteLine("The Maximum Number is: " + num2);
            }
        }
    }
}
