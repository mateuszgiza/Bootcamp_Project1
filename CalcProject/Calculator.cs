using System;
using System.Collections.Generic;
using System.Text;

namespace CalcProject
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public int Sub(int x, int y)
        {
            return x - y;
        }

        public float Divide(float x, float y)
        {
            if (y == 0)
            {
                throw new DivideByZeroException();
            }
            float result = x / y;
            return result;
        }
    }
}
