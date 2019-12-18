using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseConversion
{
    internal class Number
    {
        public int decNum { get; set; }
        public long binNum { get; set; }
        public int octNum { get; set; }

        public Number(long bin, int oct, int dec)
        {
            binNum = bin; octNum = oct; decNum = dec;
        }

        public static Number binBase()
        {
            int decNum = Util.ToDecimal(Util.InputToStack(), Util.numBase);
            long binNum = int.Parse(Util.baseNum);
            int octNum = Util.BinToOctal(Util.InputToStack());
            return new Number(binNum, octNum, decNum);
        }

        public static Number decBase()
        {
            int decNum = int.Parse(Util.baseNum);
            long binNum = Util.DecTo(2, decNum);
            int octNum = (int)Util.DecTo(8, decNum);
            return new Number(binNum, octNum, decNum);
        }

        public static Number octBase()
        {
            int octNum = int.Parse(Util.baseNum);
            int decNum = Util.ToDecimal(Util.InputToStack(), Util.numBase);
            long binNum = Util.OctalToBin();
            return new Number(binNum, octNum, decNum);
        }

        public static void showNumber(Number input)
        {
            Console.WriteLine($"For your input: Base Number:{Util.baseNum}, Base:{Util.numBase} \nThe number can be represented as\n\tBinary:{input.binNum}\n\tOctal: {input.octNum}\n\tDecimal: {input.decNum}");
        }
    }
}