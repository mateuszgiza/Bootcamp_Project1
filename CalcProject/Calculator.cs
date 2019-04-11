using System;

namespace CalcProject
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public float Divide(float x, float y)
        {
            return (float)Divide((decimal)x, (decimal)y);
        }
        public double Divide(double x, double y)
        {
            return (double)Divide((decimal)x, (decimal)y);
        }
        public float Divide(int x, int y)
        {
            return (float)Divide(x, (decimal)y);
        }

        public decimal Divide(decimal x, decimal y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }

            return x / y;
        }

        public int AddIntegers(int a, int b)
        {
            return a + b;
        }

        public int DivideIntegers(int a, int b)
        {
            return a / b;
        }
    }
}
