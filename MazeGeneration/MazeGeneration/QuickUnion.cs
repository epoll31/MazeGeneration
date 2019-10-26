using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGeneration
{
    public class QuickUnion : UnionFind
    {
        public QuickUnion(int number)
            : base (number)
        {

        }

        public override void Union(int p, int q)
        {
            if (AreConnected(p, q))
            {
                return;
            }

            Data[q] = p;
        }

        public override int Find(int p)
        {
            while (p != Data[p])
            {
                p = Data[p];
            }
            return Data[p];
        }
    }
}
