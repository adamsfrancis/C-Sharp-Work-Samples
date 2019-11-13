using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MathGames.Question;

namespace MathGames
{
    internal class questionBank
    {
        internal static int numQuestions { get; set; }
        internal questionSet questionOperator { get; set; }

        internal delegate int nextNumber();

        public static Random newRandom = new Random();
        private nextNumber _Next = delegate () { return newRandom.Next(1, 12); };
        private Question[] qBank { get; set; }

        public questionBank(int numQs, string qOperator)
        {
            numQuestions = numQs;
            qBank = new Question[numQuestions];
            assignOperator(qOperator);
            generateQuestions(questionOperator);
        }

        internal void assignOperator(string qOperator)
        {
            switch (qOperator)
            {
                case ("plus"):
                    {
                        questionOperator = plus;
                        break;
                    }
                case ("minus"):
                    {
                        questionOperator = minus;
                        break;
                    }
                case ("multiply"):
                    {
                        questionOperator = multiply;
                        break;
                    }
                case ("divide"):
                    {
                        questionOperator = divide;
                        break;
                    }
                default:
                    {
                        questionOperator = modulus;
                        break;
                    }
            }
        }

        internal void generateQuestions(questionSet c)
        {
            for (int i = 0; i < numQuestions; i++)
            {
                int varOne = _Next();
                int varTwo = _Next();
                qBank[i] = new Question(varOne, varTwo, c);
            }
        }
    }
}