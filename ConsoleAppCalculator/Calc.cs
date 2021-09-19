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

        public static double Subtract(double num1, double num2)//Make an array overload for multiple inputs
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

        public static double Divider(double num1, double num2)
        {
            return num1 / num2;
        }

        public static double Multplier(double num1, double num2)
        {
            return num1 * num2;
        }

        public static double Exponenter(double num1, double num2)   //NEEDS IMPROVEMENT
        {
            double numSum = Math.Pow(num1, num2);
            if (num1 < 0 && num2 % 2 == 0)
            {
                numSum = numSum * -1;
            }

            return numSum;

        }
    }
}
