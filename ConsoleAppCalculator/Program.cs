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

                decimal selection = AskUserForNumber("what you want to do: ");
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

        static decimal AskUserForNumber(string what)
        {
            bool notNumber = true;
            string testInput;
            decimal result;

            do
            {
                testInput = AskUserFor(what);
                try
                {
                    result = decimal.Parse(testInput);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"'{testInput}' is not a number");
                }
                notNumber = !decimal.TryParse(testInput, out result);
            } while (notNumber);

            return result;
        }

        static string AskUserFor(string what)
        {
            Console.Write("\nPlease enter " + what);
            string userInput = Console.ReadLine();
            return userInput;
        }

        static decimal[] AskForMultipleNumbers()
        {
            int howMany;
            do
            {
                howMany = (int)AskUserForNumber("how many inputs (max 20) you want to use: ");
                if (howMany > 20) { howMany = 20; } else if (howMany < 0) { Console.WriteLine("Can not choose less than 0!"); }
            } while (howMany < 0);

            decimal[] userInput = new decimal[howMany];

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

                decimal addSelection = AskUserForNumber("what you want to do: ");
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
                    default:
                        Console.WriteLine("Incorrect selection");
                        ResetScreen();
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
                decimal subSelection = AskUserForNumber("what you want to do: ");
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
                    default:
                        Console.WriteLine("Incorrect selection");
                        ResetScreen();
                        break;
                }
            }
        }//End of Subtraction

        static void Division()
        {
            Console.WriteLine("~ Division ~");
            try
            {
                Console.WriteLine(Calc.Divider(AskUserForNumber("a number to be divided: "), AskUserForNumber("a number to divide with: ")));
            }
            catch (DivideByZeroException) { Console.WriteLine("Can't divide with 0"); }
        }
        static void Multiplication()
        {
            Console.WriteLine("~ Multiplication ~");
            Console.WriteLine($"the sum is: {Calc.Multplier(AskUserForNumber("the first number: "), AskUserForNumber("a number to multiply with: "))}");
        }
        static void Exponentiation()
        {
            Console.WriteLine("~ Exponentiation ~");
            Console.WriteLine("The result = " + Calc.Exponenter(AskUserForNumber("your base number: "), AskUserForNumber("your exponent number: ")));
        }
    }
}
