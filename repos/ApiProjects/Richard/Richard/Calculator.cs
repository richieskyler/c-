using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Calculator
    {
        public double FirstNumber;
        public double SecondNumber;
        public char OperatorSign;
        public Calculator(double firstName, double secondName, char operatorSign)
        {
            FirstNumber = firstName;
            SecondNumber = secondName;
            OperatorSign = operatorSign;
        }

        public void calculate()
        {
            if (OperatorSign == '+')
            {
                Console.WriteLine(FirstNumber + SecondNumber);
            } else if (OperatorSign == '-')
            {
                Console.WriteLine(FirstNumber - SecondNumber);
            } else if (OperatorSign == '/')
            {
                Console.WriteLine(FirstNumber / SecondNumber);
            }
            else
            {
                Console.WriteLine("Invalid Operator");
            }
        }
    }
}
