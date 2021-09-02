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
                                  "\n4. Multiplication");

                double selection = AskUserForNumber("what you want to do: ");
                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        Addition();
                        break;

                    case 2:
                        break;

                    case 3:
                        break;

                    case 4:
                        break;

                    default:
                        Console.WriteLine("\nIncorrect selection");
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



        //      Mathematical methods
        
        static void Addition()
        {
            Console.WriteLine("~ Addition ~");
            double num1, num2, numSum;
            
            num1 = AskUserForNumber("your first number: ");
            num2 = AskUserForNumber("your second number: ");

            numSum = num1 + num2;
            Console.WriteLine("\n" + num1 + " + " + num2 +" = " + numSum);
            
        }
    }
}
