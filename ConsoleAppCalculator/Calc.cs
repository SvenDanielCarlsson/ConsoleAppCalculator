using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppCalculator
{
    public class Calc
    {
        public static double Add(double num1, double num2)
        {   
            return num1 + num2;
        }
        public static double Add(double[] multiAdd)
        {
            double result = 0;
            for(int i = 0; i < multiAdd.Length; i++)
            {
                result = result + multiAdd[i];
            }
            return result;
        }

        public static double Subtract(double num1, double num2)
        {
            return num1 - num2;
        }
        public static double Subtract(double[] multiSub)
        {
            double result = 0;
            for(int i = 0; i < multiSub.Length; i++)
            {
                result = result - multiSub[i];
            }
            return result;
        }

        public static decimal Divider(decimal num1, decimal num2)
        {
            decimal numSum = 0;
            try
            {
            return numSum = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                throw new DivideByZeroException();
            }
            //return num1 / num2;
        }

        public static double Multplier(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Exponenter(double num1, double num2)   //NEEDS IMPROVEMENT
        {
            /*
            double _num1 = Math.Abs(num1);
            double _num2 = Math.Abs(num2);

            numSum = Math.Pow(_num1, _num2);
            double _numSum = -(1 / numSum);
            */

            double numSum = Math.Pow(num1, num2);
            if (num1 < 0 && num2 % 2 == 0)
            {
                numSum = numSum * -1;
            }

            return numSum;

        }
    }
}
