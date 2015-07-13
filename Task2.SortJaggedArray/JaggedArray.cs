using System;
using System.Linq;

namespace Task2.SortJaggedArray
{
    public static class JaggedArray
    {
        public enum TypeSort { ByMaxElement, ByMinElement, BySumElements };
        public enum OrderSort { Asc, Desc };

        delegate int GetComparisonValue(int[] array);
        delegate bool Compare(int a, int b);
        
        // без изменеия логики добавить еще 1 тип сортировки
        public static void Sort(int[][] array, TypeSort typeSort, OrderSort orderSort)
        {
            GetComparisonValue getComparisonValue;
            switch (typeSort)
            {
                case TypeSort.ByMaxElement:
                    getComparisonValue = (int[] a) => a.Max();
                    break;
                case TypeSort.ByMinElement:
                    getComparisonValue = (int[] a) => a.Min();
                    break;
                case TypeSort.BySumElements:
                    getComparisonValue = (int[] a) => a.Sum();
                    break;
                default:
                    throw new ArgumentException("Unkown element enumeration", "typeSort");
            }

            int[] comparisonValues = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                comparisonValues[i] = getComparisonValue(array[i]);
            }

            Compare less;
            switch (orderSort)
            {
                case OrderSort.Asc:
                    less = (int a, int b) => a < b;
                    break;
                case OrderSort.Desc:
                    less = (int a, int b) => a > b;
                    break;
                default:
                    throw new ArgumentException("Unkown element enumeration", "orderSort");
            }

            for (int i = 0; i < comparisonValues.Length - 1; i++)
            {
                int indexMin = i;
                for (int j = i + 1; j < comparisonValues.Length; j++)
                {
                    if (less(comparisonValues[j], comparisonValues[indexMin]))
                    {
                        indexMin = j;
                    }
                }
                int buffer = comparisonValues[i];
                comparisonValues[i] = comparisonValues[indexMin];
                comparisonValues[indexMin] = buffer;

                int[] bufferReference = array[i];
                array[i] = array[indexMin];
                array[indexMin] = bufferReference;
            }
        }       
    }
}
