using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalculatorLogic;

namespace CalculatorUnitTest
{
    [TestClass]
    public class CalculatorTests
    {
        [DataTestMethod]
        [DataRow(1, 2, 3)]
        [DataRow(2, 3, 5)]
        [DataRow(3, 4, 7)]
        [DataRow(4, 5, 9)]
        public void CalculatorAdditionFUnctionMustAddTwoUniqueSingleDigitNumbers(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }
    }
}
