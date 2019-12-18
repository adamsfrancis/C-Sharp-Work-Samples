using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    class Characters
    {
        public static int[] charArray = new int[26];
        public Characters()
        {
            for(int i = 0;i<charArray.Length;i++)
            {
                charArray[i] = i + 65;
            }
        }

    }
}
