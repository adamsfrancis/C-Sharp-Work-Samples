using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDistance
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            VectorList thisSet = new VectorList();
            Console.WriteLine($"Shortest distances between (X,Y) Vectors:");
            Console.WriteLine($"Distance:{Math.Round(thisSet.twoVecList[0].distBetween, 5)} Vectors: ({thisSet.twoVecList[0].vecOne._X},{thisSet.twoVecList[0].vecOne._Y})/({thisSet.twoVecList[0].vecTwo._X},{thisSet.twoVecList[0].vecTwo._Y})");
            Console.WriteLine($"Distance:{Math.Round(thisSet.twoVecList[1].distBetween, 5)} Vectors: ({thisSet.twoVecList[1].vecOne._X},{thisSet.twoVecList[1].vecOne._Y})/({thisSet.twoVecList[1].vecTwo._X},{thisSet.twoVecList[1].vecTwo._Y})");
            Console.WriteLine($"Shortest distances between (X,Y,Z) Vectors:");
            Console.WriteLine($"Distance:{Math.Round(thisSet.threeVecList[0].distBetween, 5)} Vectors: ({thisSet.threeVecList[0].vecOne._X},{thisSet.threeVecList[0].vecOne._Y},{thisSet.threeVecList[0].vecOne._Z})/({thisSet.threeVecList[0].vecTwo._X},{thisSet.threeVecList[0].vecTwo._Y},{thisSet.threeVecList[0].vecTwo._Z})");
            Console.WriteLine($"Distance:{Math.Round(thisSet.threeVecList[1].distBetween, 5)} Vectors: ({thisSet.threeVecList[1].vecOne._X},{thisSet.threeVecList[1].vecOne._Y},{thisSet.threeVecList[1].vecOne._Z})/({thisSet.threeVecList[1].vecTwo._X},{thisSet.threeVecList[1].vecTwo._Y},{thisSet.threeVecList[1].vecTwo._Z})");
        }
    }
}