using System;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Threading;

namespace DictionaryAttack
{
    internal class BuildDictionary
    {
        internal static char[] validCharacters = new char[94];
        public static int passNumber { get; set; }
        private long passLength => ((long)Math.Pow(94, GetPassword.passWord.Length));
        private long attempts = 0;

        internal static void BuildCharacters()
        {
            for (int i = 0; i < 94; i++) { validCharacters[i] = (char)(i + 33); }
        }

        internal static string BuildString(long baseNumber)
        {
            long ogNum = baseNumber;
            StringBuilder currentString = new StringBuilder();
            while (baseNumber != 0)
            {
                currentString.Insert(0, validCharacters[baseNumber % 94]);
                baseNumber /= 94;
                if (ogNum > 93) { baseNumber--; }
            }
            return currentString.ToString();
        }

        public BuildDictionary()
        {
            BuildCharacters();
            for (long i = 0; i < 150; i++) { string result = BuildString(i); Console.WriteLine($"{i}. {result}, "); }
            //string result = "";
            //BuildCharacters();
            //Stopwatch stopWatch = new Stopwatch();
            //stopWatch.Start();
            //Parallel.For(0, passLength, (i, state) =>
            //    {
            //        attempts += 1;
            //        string currentPass = BuildString(this.attempts);
            //        //Console.Write($"\r Attempt: {attempts}");
            //        if (currentPass.Equals(GetPassword.passWord))
            //        {
            //            state.Stop();
            //            stopWatch.Stop();
            //            TimeSpan ts = stopWatch.Elapsed;
            //            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            //            result = currentPass;
            //            Console.WriteLine($"Entered Password: {GetPassword.passWord} // Cracked: {result} in {elapsedTime}. Attempts: {attempts}.");
            //        }
            //    });
        }
    }
}