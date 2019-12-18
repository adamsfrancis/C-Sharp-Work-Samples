using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class Utilities
    {
        private static string oiText;
        private static string oiSK;
        private static string oiMK;
        private static string cleanInput;
        private static string cySK;
        private static string cyMK;
        private static string cyCK;
        private static string skEncode;
        private static string mkEncode;
        private static string ckEncode;
        private static string skDecode;
        private static string mkDecode;
        private static string ckDecode;

        public static string stringClean(string input) => new string(input.Where(c => char.IsLetterOrDigit(c)).ToArray()).ToUpper();

        public static string complexCypher(string input) => input + cleanInput.Substring(0, (cleanInput.Length - input.Length)).ToUpper();

        public static string simpleCypher(string input)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < cleanInput.Length; i++) { result.Append(input[i % input.Length]); }
            return result.ToString().ToUpper();
        }

        public static void getInput()
        {
            Console.Write("Please enter a phrase to be encoded: ");
            oiText = Console.ReadLine();
            Console.Write("Please enter a single character cypher: ");
            oiSK = Console.ReadLine();
            Console.Write("Please enter a multiple character cypher: ");
            oiMK = Console.ReadLine();
        }

        public static string enCode(string input, string cypher)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int offSet = (int)(cypher[i] - 65);
                int startDex = (int)(input[i] - 65);
                result.Append((char)Characters.charArray[(startDex + offSet) % 26]);
            }
            return result.ToString();
        }

        public static string deCode(string input, string cypher)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                int offSet = 26 - (int)(cypher[i] - 65);
                int startDex = (int)(input[i] - 65);
                result.Append((char)Characters.charArray[(startDex + offSet) % 26]);
            }
            return result.ToString();
        }

        public static void codeAll()
        {
            getInput();
            cleanInput = Utilities.stringClean(oiText);
            cySK = Utilities.simpleCypher(Utilities.stringClean(oiSK));
            cyMK = Utilities.simpleCypher(Utilities.stringClean(oiMK));
            cyCK = Utilities.complexCypher(Utilities.stringClean(oiMK));
            skEncode = enCode(cleanInput, cySK);
            mkEncode = enCode(cleanInput, cyMK);
            ckEncode = enCode(cleanInput, cyCK);
            skDecode = deCode(skEncode, cySK);
            mkDecode = deCode(mkEncode, cyMK);
            ckDecode = deCode(ckEncode, cyCK);
        }

        public static void displayResults()
        {
            Console.WriteLine($"You entered {oiText} as plain text.");
            Console.WriteLine($"You entered {oiSK} as your single key.");
            Console.WriteLine($"You entered {oiMK} as your multi key.");
            Console.WriteLine();
            Console.WriteLine($"Encrypted message with single key is {skEncode}");
            Console.WriteLine($"Encrypted message with multi key is {mkEncode}");
            Console.WriteLine($"Encrypted message with continuous key is {ckEncode}");
            Console.WriteLine();
            Console.WriteLine($"Decrypted message with single key is {skDecode}");
            Console.WriteLine($"Decrypted message with multi key is {mkDecode}");
            Console.WriteLine($"Decrypted message with continuous key is {ckDecode}");
        }
    }
}