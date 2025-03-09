using System;

namespace NameReversalApp
{
    class Program
    {
        static void Main()
        {
            // Prompt the user to enter their name in lowercase
            Console.Write("Enter your name in lowercase: ");
            string name = Console.ReadLine();

            // Convert the name string to a character array
            char[] nameArray = name.ToCharArray();

            // Reverse the array of characters
            Array.Reverse(nameArray);

            // Create a new string from the reversed character array
            string reversedName = new string(nameArray);

            // Display the reversed name
            Console.WriteLine("Reversed name: " + reversedName);
        }
    }
}
