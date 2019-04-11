using System;
using System.Collections.Generic;
using System.Text;

namespace CalcProject
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
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
    }
}
