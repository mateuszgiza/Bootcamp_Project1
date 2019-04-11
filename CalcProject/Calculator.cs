using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcProject
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public float Divide(int x, int y)
        {
            if (y == 0) throw new DivideByZeroException();
            float result = (float)x / y;
            //throw new NotImplementedException();
            return result;

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

        public int Subtract(int a, int b)
        {
            //return -1;
            return a - b;
        }

        public double Divide(double a, double b)
        {
            //return new NotImplementedException();
            //return 2;
            return a / b;
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
