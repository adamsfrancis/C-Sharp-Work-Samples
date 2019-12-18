using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VectorDistance
{
    internal class VectorList
    {
        internal List<Vector> twoList = new List<Vector>();
        internal List<Vector> threeList = new List<Vector>();
        public List<VectorSet> twoVecList = new List<VectorSet>();
        public List<VectorSet> threeVecList = new List<VectorSet>();

        internal void buildTwoVecList(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                twoList.Add(GenerateVectors.twoVector(limit));
            }
        }

        internal void buildThreeVecList(int limit)
        {
            for (int i = 0; i < limit; i++)
            {
                threeList.Add(GenerateVectors.threeVector(limit));
            }
        }

        internal void compareVectors(List<Vector> input, List<VectorSet> output)
        {
            int lenInput = input.Count();
            for (int i = 0; i < lenInput - 1; i++)
                for (int j = i + 1; j < lenInput; j++)
                    output.Add(new VectorSet(input[i], input[j]));
        }

        public VectorList()
        {
            buildTwoVecList(100);
            buildThreeVecList(1000);
            compareVectors(twoList, twoVecList);
            compareVectors(threeList, threeVecList);
            twoVecList = twoVecList.OrderBy(o => o.distBetween).ToList();
            threeVecList = threeVecList.OrderBy(o => o.distBetween).ToList();
        }
    }
}