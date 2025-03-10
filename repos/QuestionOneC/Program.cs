using System;

namespace PictureOrientationApp
{
    class Program
    {
        static void Main()
        {
            //Ask User to in the width of a picture
            Console.WriteLine("Enter the Width:");
            int width = Convert.ToInt32(Console.ReadLine());

            //Ask user to input the height of a picture
            Console.WriteLine("Enter the Height:");
            int height = Convert.ToInt32(Console.ReadLine());

            //Checks the Width and Height then displays if its a Landscape or Portrait picture
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
