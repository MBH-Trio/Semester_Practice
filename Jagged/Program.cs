using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jagged
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][][] array = new int[2][][];

            array[0] = new int[2][];
            array[0][0] = new int []{ 1,3,5,66,2,4,3,2,2323,2,1};
            array[0][1] =  new int[]{ 1,2,3,45,6,7};

            array[1] = new int[3][];
            array[1][0] = new int[] { 1, 3, 5, 6 };
            array[1][1] = new int[] { 1, 2, 3, 45, 6, 7 };

            foreach(int[][] two_2 in array)
            {
                foreach(int[] one_d in two_2)
                {
                    foreach(int num in one_d)
                    {
                        Console.Write(num+" ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine("\n\n");
            }


        }
    }
}
