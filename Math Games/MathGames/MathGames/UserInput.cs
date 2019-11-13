using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGames
{
    internal class UserInput
    {
        internal int numberofQuestions { get; set; }

        public UserInput()
        {
            Console.WriteLine("Welcome to Math Games!");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine("5. Modulus");
        }

        internal void getOperator()
        {
            Console.Write("Please choose an operator to test: ");
            switch (Console.ReadLine())
            {
                case ("1"):
                    {
                        new questionBank(numberofQuestions, "plus");
                        break;
                    }
                case ("2"):
                    {
                        new questionBank(numberofQuestions, "minus");
                        break;
                    }
                case ("3"):
                    {
                        new questionBank(numberofQuestions, "multiply");
                        break;
                    }
                case ("4"):
                    {
                        new questionBank(numberofQuestions, "divide");
                        break;
                    }
                case ("5"):
                    {
                        new questionBank(numberofQuestions, "modulus");
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
    }
}