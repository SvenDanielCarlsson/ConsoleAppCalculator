using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCalculator
{
    public class Calc
    {
        public static decimal Add(decimal num1, decimal num2)
        {   
            return num1 + num2;
        }
        public static decimal Add(decimal[] multiAdd)
        {
            decimal result = 0;
            for(int i = 0; i < multiAdd.Length; i++)
            {
                result = result + multiAdd[i];
            }
            return result;
        }// END OF ADD

        public static decimal Subtract(decimal num1, decimal num2)
        {
            return num1 - num2;
        }
        public static decimal Subtract(decimal[] multiSub)
        {
            //if (multiSub.Length < 1)
            //{ throw (IndexOutOfRangeException); }
            try { decimal testrResult = multiSub[0]; } catch (IndexOutOfRangeException){ return 0; }
            decimal result = multiSub[0];
                for (int i = 1; i < multiSub.Length; i++)
                {
                    result = result - multiSub[i];
                }
                return result;

        }// END OF SUBTRACT

        public static decimal Divider(decimal num1, decimal num2)
        {
            try
            {
            return num1 / num2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException();
            }
        }

        public static decimal Multplier(decimal num1, decimal num2)
        {
            return num1 * num2;
        }

        public static double Exponenter(decimal num1, decimal num2)   //NEEDS IMPROVEMENT
        {
            /*
            double _num1 = Math.Abs(num1);
            double _num2 = Math.Abs(num2);

            numSum = Math.Pow(_num1, _num2);
            double _numSum = -(1 / numSum);
            */

            double numSum = Math.Pow((double)num1, (double)num2);
            if (num1 < 0 && num2 % 2 == 0)
            {
                numSum = numSum * -1;
            }

            return numSum;

        }
    }
}
