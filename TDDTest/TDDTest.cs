using System;
using Xunit;
using TDDPractice;


namespace TDDTest
{
    public class TDDTest
    {
        [Fact]
        public void addNumbersTest()
        {
            double num1 = 5, num2 = 10;
            double expectedVal = 15;
            Program p = new Program();
            double actualVal = p.addTwoNumbers(num1, num2);

            Assert.Equal(expectedVal, actualVal);
        }

        [Fact]
        public void subtractNumbersTest()
        {
            double num1 = 5, num2 = 10;
            double expectedVal = -5;
            Program p = new Program();
            double actualVal = p.SubtractTwoNumbers(num1, num2);

            Assert.Equal(expectedVal, actualVal);
        }

        [Fact]
        public void multiplyNumberTest()
        {
            double num1 = 5, num2 = 10;
            double expectedVal = 50;
            Program p = new Program();
            double actualVal = p.MultiplyTwoNumbers(num1, num2);

            Assert.Equal(expectedVal, actualVal);
        }

        [Fact]
        public void divideNumbersTest()
        {
            double num1 = 20, num2 = 10;
            double expectedVal = 2;
            Program p = new Program();
            double actualVal = p.DivideTwoNumbers(num1, num2);

            Assert.Equal(expectedVal, actualVal);
        }

        [Fact]
        public void divideByZeroTest()
        {
            double num1 = 20, num2 = 0;
            Program p = new Program();
            
            Assert.Throws<DivideByZeroException>(() => p.DivideTwoNumbers(num1, num2));
        }
    }
}
