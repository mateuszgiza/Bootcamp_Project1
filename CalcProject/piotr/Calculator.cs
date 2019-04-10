using System;
using System.Collections.Generic;
using System.Text;



namespace Calculator.Piotr
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }
        public double Divide(double x, double y)
        {
            if (y==0)
            {
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
    }
}
