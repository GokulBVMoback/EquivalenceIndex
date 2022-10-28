using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EquivalenceNumber
{
    public class EquiInd
    {
        public int Find(int[] numbers)
        {
            for (int i = 1; i < numbers.Length; i++)
            {
                int lsum = 0;
                int rsum = 0;
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    rsum = rsum + (numbers[j]);

                }
                for (int k = 0; k < i; k++)
                {
                    lsum = lsum + (numbers[k]);
                }
                if (lsum == rsum)
                {
                    return i;
                }
            }
            //TODO - add solution here
            return -1;
        }
    }
}
