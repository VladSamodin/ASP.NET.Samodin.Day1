using System;
using Task2.SortJaggedArray;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(@"5\/6 = {0}", Task1.Math.NthRoot(20000, 2, 0.0000001));
            Console.WriteLine(@"5\/6 = {0}", System.Math.Pow(20000, 1.0 / 2));
            //System.Math.Pow()
            //Task1.Math.NthRoot(5, 2, 4)

            int[][] array = new int[5][] {new int[3] {2, 5, 3}, 
                                          new int[4] {0, -5, 3 , 1},
                                          new int[2] {10, 16},
                                          new int[3] {1, 2, 3},
                                          new int[4] {4, -3, 1, 2}};

            Console.WriteLine("Source array:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write("{0, 3} ", array[i][j]);
                Console.WriteLine();
            }
            JaggedArray.Sort(array, JaggedArray.TypeSort.BySumElements, JaggedArray.OrderSort.Desc);
            Console.WriteLine("Sorted array:");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                    Console.Write("{0, 3} ", array[i][j]);
                Console.WriteLine();
            }
        }
    }
}
