using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDistance
{
    internal class GenerateVectors
    {
        internal static Random randVec = new Random();

        public static Vector twoVector(int limit)
        {
            return new Vector(randVec.Next(limit), randVec.Next(limit));
        }

        public static Vector threeVector(int limit)
        {
            return new Vector(randVec.Next(limit), randVec.Next(limit), randVec.Next(limit));
        }
    }
}