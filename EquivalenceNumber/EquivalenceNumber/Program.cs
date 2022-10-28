using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquivalenceNumber
{
    internal class Program
    {
        //int[] num;
       
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 3, 2, 3, 3, 3 };
            int[] num2={ 1, 2, 3, 4, 5, 7, 8, 10, 12 };
            int[] num3 = { 2, 2, 3, 4, 3, 74, 8, 10, 12 };
            int[] num4 = { 10, 11, 3, 1, 1, 1, 9, 9 };
            int[] num5 = { 4, 3, 5, 6, 7, 5, 10, 15 };
            EquiInd equiInd = new EquiInd();
            Console.WriteLine(equiInd.Find(num));
            Console.WriteLine(equiInd.Find(num2));
            Console.WriteLine(equiInd.Find(num3));
            Console.WriteLine(equiInd.Find(num4));
            Console.WriteLine(equiInd.Find(num5));  
        }

    }
}
