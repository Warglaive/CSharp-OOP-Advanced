using System.Collections.Generic;

namespace BubbleSort
{
    public class Bubble
    {
        public List<int> integersToSort;
        public Bubble(List<int> integers)
        {
            this.integersToSort = new List<int>(integers);
        }

        public void Sort()
        {
            var length = this.integersToSort.Count;

            int temp = this.integersToSort[0];
            for (int i = 0; i < length; i++)
            {
                for (int j = i + 1; j < length; j++)
                {
                    if (this.integersToSort[i] > this.integersToSort[j])
                    {
                        temp = this.integersToSort[i];
                        this.integersToSort[i] = this.integersToSort[j];
                        this.integersToSort[j] = temp;
                    }
                }
            }
        }
    }
}