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
        
        
    }
}
