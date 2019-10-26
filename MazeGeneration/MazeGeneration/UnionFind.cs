using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGeneration
{
    public abstract class UnionFind
    {
        protected int[] Data;

        public UnionFind(int number)
        {
            Data = new int[number];
            for (int i = 0; i < number; i++)
            {
                Data[i] = i;
            }
        }

        public abstract void Union(int p, int q);
        public abstract int Find(int p);

        public bool AreConnected(int p, int q)
        {
            return Find(p) == Find(q);
        }
    }
}
