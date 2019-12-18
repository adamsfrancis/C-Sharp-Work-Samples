using System;

namespace VectorDistance
{
    internal class Vector
    {
        public int _X { get; set; }
        public int _Y { get; set; }
        public int _Z { get; set; }

        public Vector(int x, int y, int z = 0)
        {
            _X = x;
            _Y = y;
            _Z = z;
        }
    }

    internal class VectorSet
    {
        public Vector vecOne { get; set; }
        public Vector vecTwo { get; set; }
        public double distBetween { get; set; }

        public static double distanceCalc(Vector one, Vector two) => (Math.Sqrt(Math.Pow((one._X - two._X), 2) + Math.Pow((one._Y - two._Y), 2) + Math.Pow((one._Z - two._Z), 2)));

        public VectorSet(Vector one, Vector two)
        {
            vecOne = one; vecTwo = two; distBetween = distanceCalc(one, two);
        }
    }
}