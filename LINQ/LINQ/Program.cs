using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] n1 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] n2 = new int[] { 1, 3, -2, -4, -7, -3, -8, 12, -19, 6, 9, 10, 14 };
            var arr1 = new[] { 3, 9, 2, 8, 6, 5 };
            var arr2 = new[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            string inputQ5 = "";
            string[] dayWeek = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            Console.WriteLine("Question #1:");
            n1.Where(c => c % 2 == 0).Select(c => c).ToList().ForEach(c => Console.Write($"{c} "));

            Console.WriteLine("Question #2:");
            n2.Where(c => c > 0 && c < 12).Select(c => c).ToList().ForEach(c => Console.Write($"{c} "));

            Console.WriteLine("Question #3:");
            arr1.Where(c => (c * c) > 20).Select(c => c).ToList().ForEach(c => Console.WriteLine($"Number = {c}, SqrNo = {c * c} "));

            Console.WriteLine("Question #4:");
            arr2.Select(c => c).Distinct().ToArray().ToList().ForEach(c => Console.WriteLine($"Number {c} appears {arr2.Count(d => d == c)} times "));

            Console.WriteLine("Question #5:");
            Console.Write("Please enter a sentence: ");
            inputQ5 = Console.ReadLine();
            inputQ5.Select(c => c).Distinct().OrderBy(c => c).ToList().ForEach(c => Console.WriteLine($"Character {c}: {inputQ5.Count(d => d == c)} times "));

            Console.WriteLine("Question #6:");
            dayWeek.ToList().ForEach(c => Console.WriteLine(c));

            Console.WriteLine("Question #7:");
            Console.WriteLine($"Number\tFrequency\tNumber*Frequency");
            arr2.Select(c => c).Distinct().ToArray().ToList().ForEach(c => Console.WriteLine($"{c}\t{arr2.Count(d => d == c)}\t\t{c * arr2.Count(d => d == c)}"));

            Console.WriteLine("Question #8:");
            Console.WriteLine("The cities are:");
            Console.Write("Input the starting character for the city: ");
            string start = Console.ReadLine();
            Console.Write("Input the ending character for the city: ");
            string end = Console.ReadLine();
            cities.Where(c => c.StartsWith(start.ToUpper()) && c.EndsWith(end.ToUpper())).ToList().ForEach(c => Console.WriteLine($"The city is: {c}"));

            Console.WriteLine("Question #9:");
            Console.Write("Enter the number of members on the list: ");
            List<int> memberList = new List<int>();
            int limit = int.Parse(Console.ReadLine());
            for (int i = 0; i < limit; i++)
            {
                Console.Write($"Member {i}: ");
                memberList.Add(int.Parse(Console.ReadLine()));
            }
            Console.Write("Input the floor value to display numbers on the list: ");
            int floor = int.Parse(Console.ReadLine());
            memberList.Where(c => c > floor).Select(c => c).ToList().ForEach(c => Console.WriteLine(c));

            
            Console.WriteLine($"\nQuestion 10");
            Console.WriteLine($"The members of the list are:");
            memberList.ForEach(x => Console.WriteLine(x));
            Console.Write($"How many records do you want to display: ");
            int ammount = int.Parse(Console.ReadLine());
            Console.WriteLine($"The top {ammount} values from the list are:");
            memberList.OrderByDescending(x => x).Select(x => x).Take(ammount).ToList().ForEach(x => Console.WriteLine($"{x}"));

        }
    }
}