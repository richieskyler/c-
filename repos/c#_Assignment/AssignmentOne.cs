using System;

public class Class1
{
	public Class1()
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
