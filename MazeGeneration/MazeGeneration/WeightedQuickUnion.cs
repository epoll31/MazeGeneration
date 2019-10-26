using System;
using System.Collections.Generic;
using System.Text;

namespace MazeGeneration
{
    public class WeightedQuickUnion : QuickUnion
    {
        private Dictionary<int, int> Lengths;

        public WeightedQuickUnion(int number)
            : base (number)
        {
            Lengths = new Dictionary<int, int>(number);
            for (int i = 0; i < number; i++)
            {
                Lengths.Add(i, 1);
            }
        }

        public override void Union(int p, int q)
        {
            if (AreConnected(p, q))
            {
                return;
            }

            if (Lengths[p] < Lengths[q])
            {
                Data[p] = q;
            }
            else
            {
                Data[q] = p;
            }
        }
    }
}
