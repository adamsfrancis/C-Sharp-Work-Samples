using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BaseConversion
{
    internal class Util
    {
        public static string baseNum = "";  //variable to hold the user input as a string
        public static int numBase = 0; //variable to hold the user input's base

        public static void getInput()
        {
            Console.Write("Enter a number: ");
            baseNum = Console.ReadLine();
            Console.Write("Which base is this number(2 | 8 | 10)?: ");
            numBase = int.Parse(Console.ReadLine());
        }

        public static Stack<int> InputToStack()
        {
            Stack<int> thisStack = new Stack<int>();
            foreach (char thing in baseNum) { thisStack.Push(int.Parse(thing.ToString())); }
            return thisStack;
        }

        public static void whichBase()
        {
            switch (numBase)
            {
                case 2:
                    Number.showNumber(Number.binBase());
                    break;

                case 8:
                    Number.showNumber(Number.octBase());
                    break;

                default:
                    Number.showNumber(Number.decBase());
                    break;
            }
        }

        public static int ToDecimal(Stack<int> inputStack, int baseCase)
        {
            int acc = 0;
            double sum = 0;
            while (inputStack.Count > 0)
            {
                sum += inputStack.Pop() * Math.Pow(baseCase, acc);
                acc++;
            }
            return Convert.ToInt32(sum);
        }

        public static int BinToOctal(Stack<int> inputStack)
        {
            int acc = 0;
            double sum = 0;
            while (inputStack.Count > 0)
            {
                sum += (inputStack.Pop() * Math.Pow(2, acc % 3)) * Math.Pow(10, acc / 3);
                acc++;
            }
            return Convert.ToInt32(sum);
        }

        public static long DecTo(int toBase, int curNum)
        {
            double resultNum = 0;
            int acc = 0;
            while (curNum > 0)
            {
                resultNum += (curNum % toBase) * Math.Pow(10, acc);
                curNum /= toBase;
                acc++;
            }
            return (long)resultNum;
        }

        public static long OctalToBin()
        {
            Stack<int> inputStack = InputToStack();
            int acc = 0;
            double resultNum = 0;
            while (inputStack.Count > 0)
            {
                resultNum += (DecTo(2, inputStack.Pop()) * Math.Pow(10, acc));
                acc += 3;
            }
            return (long)resultNum;
        }
    }
}