using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        public static void Main()
        {
            var unSortedInts = new List<int>();
            for (int i = 9; i > 0; i--)
            {
                unSortedInts.Add(i);
            }
            var bubble = new Bubble(unSortedInts);
            bubble.Sort();
        }
    }
}
