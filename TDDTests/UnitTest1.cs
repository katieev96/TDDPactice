using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TTDDTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AdditionTest()
        {
            double num1 = 5, num2 = 10;
            double expectedValue = 15;
            double actualValue = addTwoNumbers(num1, num2);

        }
    }
}
