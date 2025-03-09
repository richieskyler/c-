using System;

namespace PictureOrientationApp
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the Width:");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Height:");
            int height = Convert.ToInt32(Console.ReadLine());

            if (width > height)
            {
                Console.WriteLine("The picture is Landscape");
            }
            else
            {
                Console.WriteLine("The picture is Portrait");
            }
        }
    }
}
