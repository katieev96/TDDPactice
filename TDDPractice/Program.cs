using System;

namespace TDDPractice
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
        }

        public double addTwoNumbers(double num1, double num2)
        {
            return num1 + num2;
        }

        public double SubtractTwoNumbers(double num1, double num2)
        {
            return num1 - num2;
        }
        
        public double MultiplyTwoNumbers(double num1, double num2)
        {
            return num1 * num2;
        }

        public double DivideTwoNumbers(double num1, double num2)
        {
            if(num2 == 0)
            {
                throw new DivideByZeroException();
            }
            return num1 / num2;
        }
    }
}
