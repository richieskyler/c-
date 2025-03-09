using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------------------1------------------------------------
            //Console.WriteLine("Enter a number in the range of 1-10: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //if (num >= 1 && num <= 10) 
            //{
            //    Console.WriteLine("Valid");
            //} else
            //{
            //    Console.WriteLine("Invalid");
            //-----------------------------------------------------------

            //--------------------2--------------------------------------
            //Console.WriteLine("Enter First Number:");
            //int num1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Second Number:");
            //int num2 = Convert.ToInt32(Console.ReadLine());

            //if (num1 > num2)
            //{
            //    Console.WriteLine("The Maximun Number is:" + num1);
            //}
            //else
            //{
            //    Console.WriteLine("The Maximun Number is:" + num2);
            //}
            //-------------------------------------------------------------

            //--------------------3----------------------------------------
            //Console.WriteLine("Enter the Width:");
            //int width = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Height:");
            //int height = Convert.ToInt32(Console.ReadLine());

            //if (width > height)
            //{
            //    Console.WriteLine("The picture is Landscape");
            //}
            //else
            //{
            //    Console.WriteLine("The picture is Portrait");
            //}
            //----------------------------------------------------------

            //---------------------4------------------------------------
            //Console.WriteLine("Enter the Speed Limit:");
            //int speedLimit = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the Speed of Car:");
            //int speedOfCar = Convert.ToInt32(Console.ReadLine());

            //if (speedOfCar < speedLimit)
            //{
            //    Console.WriteLine("Ok");
            //}
            //else
            //{
            //    double demeritsPoint = (((speedOfCar - speedLimit) / 5) * 1);
            //    if (demeritsPoint > 12)
            //        Console.WriteLine("Lincense Suspended");
            //}
            //------------------------------------------------------------

            //Question 2
            //---------------------1------------------------------------
            //int i = 0;
            //for (int j = 1; j <= 100; j++)
            //{
            //    if (j % 3 == 0)
            //    {
            //        i++;
            //    }
            //}
            //Console.WriteLine(i);

            //--------------------2-----------------
            //int sum = 0;
            //while (true)
            //{
            //    Console.WriteLine("Enter a number:");
            //    string value = Console.ReadLine();

            //    if (value.ToLower() == "ok")
            //    {
            //        break;
            //    }

            //    int num = Convert.ToInt32(value);
            //    sum += num;
            //}
            //Console.WriteLine("The sum of the numbers is: " + sum);

            //--------------------------------------------------------------

            //-----------------------3--------------------------------------
            //int factorial = 1;
            //Console.WriteLine("Enter a Number");
            //int value = Convert.ToInt32(Console.ReadLine());
            //int num = value;
            //for (int i = 1; i <= num; i++)
            //{
            //    factorial *= value;
            //    value--;
            //}
            //Console.WriteLine($"{num}!:{factorial}");
            //-------------------------------------------------------------------

            //---------------------4-----------------------------------------------
            //Random randomNumber = new Random();
            //int randomNum = randomNumber.Next(1, 10);
            //Console.WriteLine(randomNum);
            //int trial = 4;
            //while (true)
            //{
            //    Console.WriteLine("Pick a number between 1-10");
            //    int number = Convert.ToInt32(Console.ReadLine());
            //    trial--;
            //    if (trial == 0)
            //    {
            //        Console.WriteLine("You Lost. The number is " + randomNum);
            //        break;
            //    }

            //    if (number == randomNum)
            //    {
            //        Console.WriteLine("You Won");
            //        break;
            //    }
            //}
            //-------------------------------------------------------------------

            //------------------------5------------------------------------------

            //Console.WriteLine("Enter a number separated by comma");
            //string listOfNums = Console.ReadLine();
            //string[] lists = listOfNums.Split(',');
            //int[] numLists = lists.Select(int.Parse).ToArray();
            //Array.Sort(numLists);
            //int maxNum = numLists[numLists.Length - 1];
            //Console.WriteLine("The Maximum Number is : " +maxNum);

            //-------------------------------------------------------------------------

            //Question 3---------------------------------------------------------------

            //----------------------1--------------------------------------------------
            //int count = 0;
            //List<string> names = new List<string>();
            //while (true)
            //{
            //    Console.WriteLine("Enter a name: ");
            //    string name = Console.ReadLine();
            //    names.Add(name);

            //    if (name == "")
            //    {
            //        int namesLength = names.Count - 1;
            //        if (namesLength == 0)
            //        {
            //            break;
            //        } else if (namesLength == 1)
            //        {
            //            Console.WriteLine($"{names[0]} liked your post");
            //            break;
            //        } else if (namesLength == 2)
            //        {
            //            Console.WriteLine($"{names[0]} and {names[1]} liked your post");
            //            break;
            //        } else if (names.Count > 2)
            //        {
            //            int others = namesLength - 2;
            //            Console.WriteLine($"{names[0]}, {names[1]} and {others} others liked your post");
            //            break;
            //        }

            //    }
            //}
            //-------------------------------------------------------------------------------------------------

            //-------------------------------------2----------------------------------------------------------
            //Console.Write("Enter your name in lowercase: ");
            //string name = Console.ReadLine();
            //char[] nameArray = name.ToCharArray();
            //Array.Reverse(nameArray);
            //string reversedName = new string(nameArray);
            //Console.WriteLine("Reversed name: " + reversedName);
            //--------------------------------------------------------------------------------------------------

            //-------------------------------------3------------------------------------------------------------
            //List<int> numbers = new List<int>();
            //while (numbers.Count < 5)
            //{
            //    Console.Write("Enter a number: ");
            //    int number = int.Parse(Console.ReadLine());
            //    if (numbers.Contains(number))
            //    {
            //        Console.WriteLine("You've already entered this number. Please try again.");
            //    }
            //    else
            //    {
            //        numbers.Add(number);
            //    }
            //}
            //numbers.Sort();
            //Console.WriteLine("Sorted numbers:");
            //foreach (int number in numbers)
            //{
            //    Console.WriteLine(number);
            //}
            //------------------------------------------------------------------------------------------

            //---------------------------------4--------------------------------------------------------

            //List<int> numbers = new List<int>();
            //while (true)
            //{
            //    Console.Write("Enter a number or type 'Quit' to exit: ");
            //    string input = Console.ReadLine();
            //    if (input.ToLower() == "quit")
            //    {
            //        break;
            //    }
            //    int number = int.Parse(input);
            //    numbers.Add(number);
            //}
            //HashSet<int> uniqueNumbers = new HashSet<int>(numbers);
            //Console.WriteLine("Unique numbers you entered:");
            //foreach (int number in uniqueNumbers)
            //{
            //    Console.WriteLine(number);
            //}
            //----------------------------------------------------------------------------

            //------------------------------5---------------------------------------------
            //while (true)
            //{
            //    Console.Write("Enter a list of numbers separated by comma");
            //    string input = Console.ReadLine();

            //    string[] numberStrings = input.Split(',');

            //    if (numberStrings.Length < 5 || numberStrings.Length == 0)
            //    {
            //        Console.WriteLine("Invalid List. Please enter at least 5 numbers.");
            //        continue;
            //    }

            //    List<int> numbers = new List<int>();
            //    foreach (string numberString in numberStrings)
            //    {
            //        numbers.Add(int.Parse(numberString.Trim()));
            //    }

            //    List<int> smallestNumbers = numbers.OrderBy(n => n).Take(3).ToList();
            //    Console.WriteLine("The 3 smallest numbers are: " + string.Join(", ", smallestNumbers));
            //    break;
            //}
            //--------------------------------------------------------------------------------------------

            //Question 4-----------------------------------------------------------------------------------
            ///-------------------------------------------1------------------------------------------------

            //    Console.Write("Enter a few numbers separated by a hyphen: ");
            //    string input = Console.ReadLine();
            //    string[] numberStrings = input.Split('-');

            //    List<int> numbers = numberStrings.Select(n => int.Parse(n.Trim())).ToList();


            //    bool isConsecutive = AreNumbersConsecutive(numbers);


            //    if (isConsecutive)
            //    {
            //        Console.WriteLine("Consecutive");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Not Consecutive");
            //    }
            //}


            //static bool AreNumbersConsecutive(List<int> numbers)
            //{

            //    numbers.Sort();


            //    for (int i = 1; i < numbers.Count; i++)
            //    {
            //        if (numbers[i] != numbers[i - 1] + 1)
            //        {
            //            return false;
            //        }
            //    }

            //    return true;
            //}
            //----------------------------------------------------------------------------------------------------------


            //--------------------------------------------------2-------------------------------------------------------

            //Console.Write("Enter a few numbers separated by a hyphen (e.g., 5-6-7-8-9): ");
            //string input = Console.ReadLine();

            //// Exit if the input is empty
            //if (string.IsNullOrWhiteSpace(input))
            //{
            //    return;
            //}


            //string[] numberStrings = input.Split('-');

            //// Convert the string array to a list of integers
            //List<int> numbers = numberStrings.Select(n => int.Parse(n.Trim())).ToList();

            //// Check for duplicates
            //bool hasDuplicates = numbers.Count != numbers.Distinct().Count();


            //if (hasDuplicates)
            //{
            //    Console.WriteLine("Duplicate");
            //}
            //---------------------------------------------------------------------------------------------------------

            //---------------------------------------3----------------------------------------------------------------

            // Ask the user to enter a time value in 24-hour format
            //Console.Write("Enter a time value in 24-hour format (e.g., 19:00): ");
            //string input = Console.ReadLine();

            //// Check if the input is empty or invalid
            //if (string.IsNullOrWhiteSpace(input) || !IsValidTime(input))
            //{
            //    Console.WriteLine("Invalid Time");
            //}
            //else
            //{
            //    Console.WriteLine("Ok");
            //}
            //-------------------------------------------------------------------------------

            //--------------------------------4-----------------------------------------------

            // Ask the user to enter a few words separated by a space
            //Console.Write("Enter a few words separated by a space: ");
            //string input = Console.ReadLine();

            //// Convert the input to PascalCase
            //string pascalCase = ConvertToPascalCase(input);

            //// Display the result
            //Console.WriteLine("PascalCase Variable Name: " + pascalCase);
            //-------------------------------------------------------------------------------


            //------------------------------------5-------------------------------------------
            //// Ask the user to enter an English word
            //Console.Write("Enter an English word: ");
            //string word = Console.ReadLine();

            //// Count the number of vowels in the word
            //int vowelCount = CountVowels(word);

            //// Display the result
            //Console.WriteLine("Number of vowels: " + vowelCount);
            //-----------------------------------------------------------

            //Question 5--------------------------------------------------
            //----------------------------1---------------------------------
            // Ask the user to enter a text
            //Console.Write("Enter a text: ");
            //string text = Console.ReadLine();

            //// Count the number of words in the text
            //int wordCount = CountWords(text);

            //// Display the result
            //Console.WriteLine("Number of words: " + wordCount);
            //----------------------------------------------------------------

            //--------------------------------2-------------------------------
            // Ask the user to enter a text
            //Console.Write("Enter a text: ");
            //string text = Console.ReadLine();

            //// Find the longest word in the text
            //string longestWord = FindLongestWord(text);

            //// Display the result
            //if (!string.IsNullOrEmpty(longestWord))
            //{
            //    Console.WriteLine("Longest word: " + longestWord);
            //}
            //else
            //{
            //    Console.WriteLine("No words found.");
            //}
            //-------------------------------------------------------

















        }


        static bool IsValidTime(string time)
        {
            // Check if the input matches the expected format (HH:mm)
            if (time.Length != 5 || time[2] != ':')
            {
                return false;
            }

            // Split the time into hours and minutes
            string[] parts = time.Split(':');
            if (parts.Length != 2)
            {
                return false;
            }

            // Try to parse hours and minutes
            if (!int.TryParse(parts[0], out int hours) || !int.TryParse(parts[1], out int minutes))
            {
                return false;
            }

            // Validate the range of hours and minutes
            return hours >= 0 && hours <= 23 && minutes >= 0 && minutes <= 59;
        }


        static string ConvertToPascalCase(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return ""; // Return empty string if input is empty
            }

            // Split the input into words
            string[] words = input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Convert each word to PascalCase
            string pascalCase = string.Join("", words.Select(word =>
                char.ToUpper(word[0]) + word.Substring(1).ToLower()
            ));

            return pascalCase;
        }


        static int CountVowels(string word)
        {
            // Define the vowels
            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

            // Convert the word to lowercase to make the check case-insensitive
            string lowercaseWord = word.ToLower();

            // Count the vowels using LINQ
            return lowercaseWord.Count(c => vowels.Contains(c));
        }


        static int CountWords(string text)
        {
            // Split the text into words using whitespace as the delimiter
            string[] words = text.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            // Return the number of words
            return words.Length;
        }

        static string FindLongestWord(string text)
        {
            // Split the text into words based on spaces
            string[] words = text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            // Find the longest word using LINQ
            return words.OrderByDescending(word => word.Length).FirstOrDefault();
        }
























    }

        
}
