using System;
using System.IO;

namespace MazeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lines = File.ReadAllLines("Data.txt");
            QuickFind uf = new QuickFind(int.Parse(lines[0]));
            for (int i = 1; i < lines.Length; i++)
            {
                uf.Union(int.Parse(lines[i].Split(" ")[0]), int.Parse(lines[i].Split(" ")[1]));
            }
            ;
        }
    }
}
