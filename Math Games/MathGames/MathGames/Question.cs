namespace MathGames
{
    internal class Question
    {
        public double varOne { get; set; }
        public double varTwo { get; set; }
        public double? userInput { get; set; }
        public double correctAnswer { get; set; }
        public bool isCorrect { get; set; }

        public delegate double questionSet(double a, double b);

        public static questionSet plus = delegate (double a, double b) { return a + b; };
        public static questionSet minus = delegate (double a, double b) { return a - b; };
        public static questionSet multiply = delegate (double a, double b) { return a * b; };
        public static questionSet divide = delegate (double a, double b) { return a / b; };
        public static questionSet modulus = delegate (double a, double b) { return a % b; };

        public Question(double a, double b, questionSet c)
        {
            varOne = a;
            varTwo = b;
            correctAnswer = c(a, b);
            isCorrect = false;
        }
    }
}