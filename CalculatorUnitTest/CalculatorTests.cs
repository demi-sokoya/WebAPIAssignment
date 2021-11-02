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
        public void CalculatorAdditionFunctionMustAddTwoUniquePositiveIntegers(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-1, -2, -3)]
        [DataRow(-2, -3, -5)]
        [DataRow(-3, -4, -7)]
        [DataRow(-4, -5, -9)]
        public void CalculatorAdditionFunctionMustAddTwoUniqueNegativeIntegers(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(2, 2, 4)]
        [DataRow(3, 3, 6)]
        [DataRow(4, 4, 8)]
        public void CalculatorAdditionFunctionMustAddAPositiveNumberToItself(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-1, -1, -2)]
        [DataRow(-2, -2, -4)]
        [DataRow(-3, -3, -6)]
        [DataRow(-4, -4, -8)]
        public void CalculatorAdditionFunctionMustAddANegativeNumberToItself(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(0.5, 1.5, 2)]
        [DataRow(1.5, 2.5, 4)]
        [DataRow(2.5, 3.5, 6)]
        [DataRow(3.5, 4.5, 8)]
        public void CalculatorAdditionFunctionMustAddTwoUniquePositiveDecimals(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(0.5, 0.5, 1)]
        [DataRow(1.5, 1.5, 3)]
        [DataRow(2.5, 2.5, 5)]
        [DataRow(3.5, 3.5, 7)]
        public void CalculatorAdditionFunctionMustAddADecimalToItself(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-0.5, -0.5, -1)]
        [DataRow(-1.5, -1.5, -3)]
        [DataRow(-2.5, -2.5, -5)]
        [DataRow(-3.5, -3.5, -7)]
        public void CalculatorAdditionFunctionMustAddANegativeDecimalToItself(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(-0.5, -1.5, -2)]
        [DataRow(-1.5, -2.5, -4)]
        [DataRow(-2.5, -3.5, -6)]
        [DataRow(-3.5, -4.5, -8)]
        public void CalculatorAdditionFunctionMustAddTwoUniqueNegativeDecimals(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, -1, 0)]
        [DataRow(2, -3, -1)]
        [DataRow(3, -7, -4)]
        [DataRow(4, -9, -5)]
        public void CalculatorAdditionFunctionMustAddOnePositiveAndOneNegativeInteger(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(0.5, -1.5, -1)]
        [DataRow(1.5, -2.5, -1)]
        [DataRow(2.5, -3.5, -1)]
        [DataRow(3.5, -4.5, -1)]
        public void CalculatorAdditionFunctionMustAddOnePositiveAndOneNegativeDecimal(double left, double right, double expected)
        {
            double result;
            result = Calc.Add(left, right);
            Assert.AreEqual(expected, result);
        }

        [DataTestMethod]
        [DataRow(1, 2, -1)]
        [DataRow(2, 3, -1)]
        [DataRow(3, 4, -1)]
        [DataRow(4, 5, -1)]
        public void CalculatorSubtractionFunctionMustSubtractTwoUniquePositiveIntegers(double left, double right, double expected)
        {
            double result;
            result = Calc.Subtract(left, right);
            Assert.AreEqual(expected, result);
        }

        
    }
}
