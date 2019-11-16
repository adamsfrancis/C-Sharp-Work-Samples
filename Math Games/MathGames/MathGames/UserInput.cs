using System;

namespace MathGames
{
    internal class UserInput
    {
        internal static int numberofQuestions { get; set; }

        public UserInput()
        {
            Console.WriteLine("Welcome to Math Games!");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
            numQuestions();
            getOperator();
        }

        internal void getOperator()
        {
            Console.Write("Please choose an operator to test: ");
            switch (Console.ReadLine())
            {
                case ("1"):
                    {
                        new questionBank(numberofQuestions, "plus");
                        RunGame.currentOperator = "+";
                        break;
                    }
                case ("2"):
                    {
                        new questionBank(numberofQuestions, "minus");
                        RunGame.currentOperator = "-";
                        break;
                    }
                case ("3"):
                    {
                        new questionBank(numberofQuestions, "multiply");
                        RunGame.currentOperator = "x";
                        break;
                    }
                case ("4"):
                    {
                        new questionBank(numberofQuestions, "divide");
                        RunGame.currentOperator = "/";
                        break;
                    }
                case ("5"):
                    {
                        new questionBank(numberofQuestions, "modulus");
                        RunGame.currentOperator = "%";
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid selection, please try again.");
                        new UserInput();
                        break;
                    }
            }
        }

        internal static void numQuestions()
        {
            Console.Write("How many questions would you like to answer?: ");
            numberofQuestions = int.Parse(Console.ReadLine());
        }
    }
}