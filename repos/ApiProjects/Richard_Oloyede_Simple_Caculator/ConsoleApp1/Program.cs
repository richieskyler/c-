// See https://aka.ms/new-console-template for more information

// Algorithm: Perform simple operations (-, *, +, /) for n numbers
// 1. Start
// 2. Set listOfOperations = ["-", "*", "+", "/"]
// 3. Set n = number of values to use
// 4. value1 = Input first value
// 5. operator1 = Input an operator
// 6. Check if operator is in listOfOperations, else print error
// 7. value2 = Input second value
// 8. operator2 = Input second operator
// 9. Check if operator is in listOfOperations, else print error
// 10. valueN = Input n-th value
// 11. check if operator is / and nextvalue is 0, else print error
// 12. Calculate result step by step
// 13. Print final result
// 14. End

using System;

namespace MyNamespace
{
    class SimpleCalculator
    {
        static void Main()
        {
            string[] listOfOperations = { "-", "*", "+", "/" };
            Console.Write("Enter number of values: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("You need at least two values to perform operations.");
                return;
            }

            Console.Write("Enter first value: ");
            double result = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i < n; i++)
            {
                Console.Write("Enter operator (+, -, *, /): ");
                string op = Console.ReadLine();

                if (!Array.Exists(listOfOperations, element => element == op))
                {
                    Console.WriteLine("Cannot perform this operation. Exiting.");
                    return;
                }

                Console.Write("Enter next value: ");
                double nextValue = Convert.ToDouble(Console.ReadLine());

                switch (op)
                {
                    case "+": result += nextValue; break;
                    case "-": result -= nextValue; break;
                    case "*": result *= nextValue; break;
                    case "/":
                        if (nextValue == 0)
                        {
                            Console.WriteLine("Error: Division by zero is not allowed. Exiting.");
                            return;
                        }
                        result /= nextValue;
                        break;
                }
            }

            Console.WriteLine($"Your result is: {result}");
        }
    }
}

