using System;

namespace ConsoleAppCalculator
{
    public class Program
    {

        static void Main(string[] args)
        {
            Calc calculate = new Calc();
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.WriteLine("~ Calculator Menu ~\n" +
                                  "\n1. Addition" +
                                  "\n2. Subtraction" +
                                  "\n3. Division" +
                                  "\n4. Multiplication" +
                                  "\n5. Exponentiation (experimental)" +
                                  "\n6. Experiement");

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

                    case 6:
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

            // REPLACE WITH A TRY/CATCH         !!!!!           !!!!!
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

        static double[] AskForMultipleNumbers()
        {
            int howMany = (int)AskUserForNumber("how many numbers you want to use: ");
            double[] userInput = new double[howMany];

            for (int i = 0; i < userInput.Length; i++)
            {
                userInput[i] = AskUserForNumber($"enter input Nr.{i + 1}: ");
            }
            return userInput;
        }


        //  -   -   -   -   Mathematical methods    -   -   -   -

        static void Addition()
        {
            bool addLoop = true;
            while (addLoop)
            {
                Console.WriteLine("~ Addition Menu ~\n" +
                                    "\nPress '1' for two inputs" +
                                    "\nPress '2' for several inputs" +
                                    "\nPress '3' to go back to Main menu");

                double addSelection = AskUserForNumber("what you want to do: ");
                Console.Clear();
                switch (addSelection)
                {
                    case 1:
                        Console.WriteLine(Calc.Add(AskUserForNumber("your first number: "), AskUserForNumber("your second number: ")) + "\n");
                        ResetScreen();
                        break;
                    case 2:
                        Console.WriteLine(Calc.Add(AskForMultipleNumbers()) + "\n");
                        ResetScreen();
                        break;
                    case 3:
                        addLoop = false;
                        break;
                }
            }
        }//End of Addition

        static void Subtraction()
        {
            bool subLoop = true;
            while (subLoop)
            {
                Console.WriteLine("~ Subtraction Menu ~\n" +
                                    "\nPress '1' for two inputs" +
                                    "\nPress '2' for several inputs" +
                                    "\nPress '3' to go to Main Menu");
                double subSelection = AskUserForNumber("what you want to do: ");
                Console.Clear();
                switch (subSelection)
                {
                    case 1:
                        Console.WriteLine(Calc.Subtract(AskUserForNumber("the first number: "), AskUserForNumber("a number to subtract with: ")) + "\n");
                        ResetScreen();
                        break;
                    case 2:
                        Console.WriteLine(Calc.Subtract(AskForMultipleNumbers()) + "\n");
                        ResetScreen();
                        break;
                    case 3:
                        subLoop = false;
                        break;
                }
            }
        }//End of Subtraction

        static void Division()
        {
            Console.WriteLine("~ Division ~");
            double num1, num2;
            //numSum;
            //throw DivideByZeroException(num1, num2) // this way?

            do
            {
                num1 = AskUserForNumber("a number to be divided: ");
                if(num1 == 0)
                {
                    Console.WriteLine(num1 + " cant be divided");
                    //throw Exception(num1 + " can't be divided");
                    //throw DivideByZeroException(num1 + "can't be divided")    <-- CREATE A CORRECT EXCEPTION  !!
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

            Console.WriteLine($"the result is: { Calc.Divider(num1, num2)}");
            //numSum = num1 / num2;
            //Console.WriteLine("\n" + num1 + " / " + num2 + " = " + numSum + "\n");
        }


        static void Multiplication()
        {
            Console.WriteLine("~ Multiplication ~");
            Console.WriteLine($"the sum is: {Calc.Multplier(AskUserForNumber("the first number: "), AskUserForNumber("Number to multiply with: "))}");

            //double num1, num2;
            //numSum;
            /*num1 = AskUserForNumber("your first number: ");
            num2 = AskUserForNumber("a number to multiply with: ");

            numSum = num1 * num2;
            Console.WriteLine("\n" + num1 + " * " + num2 + " = " + numSum + "\n");*/
        }


        static void Exponentiation()
        {
            Console.WriteLine("~ Exponentiation ~");
            Console.WriteLine("The result = " + Calc.Exponenter(AskUserForNumber("your base number: "), AskUserForNumber("your exponent number: ")));

            //double num1, num2;
            //numSum;
            //num1 = AskUserForNumber("your base number: ");
            //num2 = AskUserForNumber("your exponent number: ");

            /*
            double _num1 = Math.Abs(num1);
            double _num2 = Math.Abs(num2);

            numSum = Math.Pow(_num1, _num2);
            double _numSum = -(1 / numSum);
            */
            
            /*numSum = Math.Pow(num1, num2);
            if(num1 < 0 && num2 % 2 == 0)
            {
                numSum = numSum * -1;
            }
            
            Console.WriteLine("\n" + num1 + " ^ " + num2 + " = " + numSum + "\n");*/
        }
    }
}
