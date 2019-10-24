using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGeneration
{
    public class QuickFind
    {
        private int[] Data;

        public QuickFind(int number)
        {
            Data = new int[number];

            for (int i = 0; i < number; i++)
            {
                Data[i] = i;
            }
        }

        public void Union(int p, int q)
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

        public int Find(int p)
        {
            return Data[p];
        }

        public bool AreConnected(int p, int q)
        {
            return Find(p) == Find(q);
        }
    }
}
