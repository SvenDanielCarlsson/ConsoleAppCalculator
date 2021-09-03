using System;

namespace ConsoleAppCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("~ Calculator Menu ~\n" +
                                  "\n1. Addition" +
                                  "\n2. Subtraction" +
                                  "\n3. Division" +
                                  "\n4. Multiplication" +
                                  "\n5. Exponentiation (experimental)");

                double selection = AskUserForNumber("what you want to do: ");
                Console.Clear();
                switch (selection)
                {
                    case 1:
                        Addition();
                        break;

                    case 2:
                        Subtraction();
                        break;

                    case 3:
                        Division();
                        break;

                    case 4:
                        Multiplication();
                        break;

                    case 5:
                        Exponentiation();
                        break;

                    default:
                        Console.WriteLine("Incorrect selection");
                        break;
                }

                ResetScreen();

            }
        }

        static void ResetScreen()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey(true);
            Console.Clear();
        }

        static double AskUserForNumber(string what)
        {
            bool notNumber = true;
            string testInput;
            double result = 0;

            do
            {
                testInput = AskUserFor(what);
                notNumber = !double.TryParse(testInput, out result);

                if(notNumber == true)
                {
                    Console.WriteLine("'" + testInput + "' is not a number");
                }
            } while (notNumber);

            return result;
        }

        static string AskUserFor(string what)
        {
            Console.Write("\nPlease enter " + what);
            string userInput = Console.ReadLine();
            return userInput;
        }





        //  -   -   -   -   Mathematical methods    -   -   -   -
        
        static void Addition()
        {
            Console.WriteLine("~ Addition ~");
            double num1, num2, numSum;
            
            num1 = AskUserForNumber("your first number: ");
            num2 = AskUserForNumber("a number to add: ");

            numSum = num1 + num2;
            Console.WriteLine("\n" + num1 + " + " + num2 +" = " + numSum + "\n");            
        }


        static void Subtraction()
        {
            Console.WriteLine("~ Subtraction ~");

            double num1, num2, numSum;
            num1 = AskUserForNumber("your first number: ");
            num2 = AskUserForNumber("a number to subtract with: ");

            numSum = num1 - num2;
            Console.WriteLine("\n" + num1 + " - " + num2 + " = " + numSum + "\n");
        }

        static void Division()
        {
            Console.WriteLine("~ Division ~");
            double num1, num2, numSum;

            do
            {
                num1 = AskUserForNumber("a number to be divided: ");
                if(num1 == 0)
                {
                    Console.WriteLine(num1 + " cant be divided");
                }
            } while (num1 == 0);

            do
            {
                num2 = AskUserForNumber("a number to divide with: ");
                if(num2 == 0)
                {
                    Console.WriteLine(num1 + " can not be divided by " + num2);
                }
            } while (num2 == 0);

            numSum = num1 / num2;
            Console.WriteLine("\n" + num1 + " / " + num2 + " = " + numSum + "\n");
        }


        static void Multiplication()
        {
            Console.WriteLine("~ Multiplication ~");

            double num1, num2, numSum;
            num1 = AskUserForNumber("your first number: ");
            num2 = AskUserForNumber("a number to multiply with: ");

            numSum = num1 * num2;
            Console.WriteLine("\n" + num1 + " * " + num2 + " = " + numSum + "\n");
        }


        static void Exponentiation()
        {
            //calculations need improvement
            Console.WriteLine("~ Exponentiation ~");
            
            double num1, num2, numSum;
            num1 = AskUserForNumber("your base number: ");
            num2 = AskUserForNumber("your exponent number: ");

            /*
            double _num1 = Math.Abs(num1);
            double _num2 = Math.Abs(num2);

            numSum = Math.Pow(_num1, _num2);
            double _numSum = -(1 / numSum);
            */
            
            numSum = Math.Pow(num1, num2);
            if(num1 < 0 && num2 % 2 == 0)
            {
                numSum = numSum * -1;
            }
            
            Console.WriteLine("\n" + num1 + " ^ " + num2 + " = " + numSum + "\n");
        }
    }
}
