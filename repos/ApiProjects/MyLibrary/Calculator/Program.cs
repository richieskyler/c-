using MyLibrary;

namespace Calculator
{
    public class program
    {
        static void Main(string[] Args)
        {
            MathsOperator mathsOperator = new MathsOperator();
            double resultAdd = mathsOperator.Addition(1, 2);
            Console.WriteLine("The sum is :" + resultAdd);

            double resultSub = mathsOperator.Subtraction(1, 2);
            Console.WriteLine("The Subtraction is :" + resultSub);

            double resultMult = mathsOperator.Multiplication(1, 2);
            Console.WriteLine("The Multiplicaion is :" + resultMult);
        }
    }
}