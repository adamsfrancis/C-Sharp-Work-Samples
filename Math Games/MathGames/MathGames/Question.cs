using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGames
{
    internal class Question
    {
        public decimal varOne { get; set; }
        public decimal varTwo { get; set; }
        public decimal? userInput { get; set; }
        public decimal correctAnswer { get; set; }
        public bool isCorrect { get; set; }

        public delegate decimal questionSet(int a, int b);

        public static questionSet plus = delegate (int a, int b) { return a + b; };
        public static questionSet minus = delegate (int a, int b) { return a - b; };
        public static questionSet multiply = delegate (int a, int b) { return a * b; };
        public static questionSet divide = delegate (int a, int b) { return a / b; };
        public static questionSet modulus = delegate (int a, int b) { return a % b; };

        public Question(int a, int b, questionSet c)
        {
            varOne = a;
            varTwo = b;
            correctAnswer = c(a, b);
            isCorrect = false;
        }
    }
}