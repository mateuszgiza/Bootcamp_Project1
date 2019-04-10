﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdamS.Calculator
{
    public class Calculator
    {
        public int Add(int x, int y)
        {
            return x + y;
        }

        public double Divide(int x, int y)
        {
            if (y == 0)
                throw new DivideByZeroException();

            return (double)x / (double)y;
        }
    }
}
