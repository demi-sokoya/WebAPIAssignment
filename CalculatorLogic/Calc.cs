using System;

namespace CalculatorLogic
{
    public static class Calc
    {
        public static double Add(double left, double right)
        {
            return left + right;
        }

        public static double Subtract(double left, double right)
        {
            return left - right;
        }

        public static double Multiply(double left, double right)
        {
            return left * right;
        }

        public static double Divide(double left, double right)
        {
            return Math.Round(left / right, 2);
        }
    }
}
