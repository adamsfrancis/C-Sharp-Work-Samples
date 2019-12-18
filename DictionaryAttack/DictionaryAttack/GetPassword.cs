using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryAttack
{
    internal class GetPassword
    {
        public static string passWord { get; set; }

        public GetPassword()
        {
            Console.Write("Please enter a password: ");
            passWord = Console.ReadLine();
        }
    }
}