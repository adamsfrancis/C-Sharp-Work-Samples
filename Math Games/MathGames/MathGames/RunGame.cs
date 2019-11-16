using System;
using System.Linq;

namespace MathGames
{
    internal class RunGame
    {
        public static string currentOperator { get; set; }

        public RunGame()
        {
            foreach (Question thing in questionBank.qBank)
            {
                double result = 0.0;
                Console.Write($"{thing.varOne} {currentOperator} {thing.varTwo}: ");
                double.TryParse(Console.ReadLine(), out result);
                thing.userInput = result;
                if (currentOperator == "/")
                {
                    if (Math.Abs(result - thing.correctAnswer) <= 0.06) { Console.WriteLine("Correct!"); thing.isCorrect = true; }
                    else { Console.WriteLine("NO! Who said that?!?!"); }
                }
                else if (currentOperator != "/" && result == thing.correctAnswer) { Console.WriteLine("Correct!"); thing.isCorrect = true; }
                else { Console.WriteLine("NO! Who said that?!?!"); }
            }
            DisplayScore();
        }

        internal void DisplayScore()
        {
            double correctPercentage = 0.0;
            correctPercentage += questionBank.qBank.Where(c => c.isCorrect == true).Count();
            correctPercentage /= questionBank.qBank.Count();
            Console.WriteLine($"Percentage correct: {(correctPercentage * 100).ToString("F")}");
        }
    }
}