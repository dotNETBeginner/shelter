using System;
using System.Collections.Generic;
using System.Text;

namespace задание_4_лаба_10
{
    class Lake
    {
        public int[] StonesInLake { get; set; }

        public Lake(int[] stones) 
        {
            StonesInLake = new int[stones.Length];

            for (int i = 0; i < StonesInLake.Length; i++)
            { StonesInLake[i] = stones[i]; }
        }

        public IEnumerable<int> GetEnumerator()
        {
            for(int i=0;i<StonesInLake.Length;i++)
            {
                if(StonesInLake[i] % 2 != 0)
                { yield return StonesInLake[i]; }
            }

            for (int i = StonesInLake.Length - 1; i >= 0; i--)
            {
                if (StonesInLake[i] % 2 == 0)
                { yield return StonesInLake[i]; }
            }
        }
    }
}
