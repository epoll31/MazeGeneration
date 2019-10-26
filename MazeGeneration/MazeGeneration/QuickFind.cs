using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGeneration
{
    public class QuickFind : UnionFind
    {
        public QuickFind(int number)
            : base(number)
        {
            
        }

        public override void Union(int p, int q)
        {
            if (AreConnected(p, q))
            {
                return;
            }

            int pValue = Find(p);
            int qValue = Find(q);
            for (int i = 0; i < Data.Length; i++)
            {
                if (Find(i) == pValue)
                {
                    Data[i] = qValue;
                }
            }
        }

        public override int Find(int p)
        {
            return Data[p];
        }
    }
}
