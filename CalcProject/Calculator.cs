using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator1
{
    public class Calculator
    {
        int a;
        int b;


        public int Add(int a, int b)
        {
            int result = a + b;
            //throw new NotImplementedException();
            return result;

        }
        public double Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }
    }
}
