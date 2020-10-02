using System;
using System.Linq;

namespace InsertionSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int[] array = Enumerable.Repeat(0, 5000).Select(i => randNum.Next(0, 10000)).ToArray();


            array = InsertionSort(array);

            Console.WriteLine("Array sorted");
            foreach (int x in array)
            {
                Console.WriteLine(x);
            }

        }

        /// <summary>
        /// Not optimised version, complexity of O(n²)
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        static int[] InsertionSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {

                int currentNumberToSort = array[i];
                int j = i;

                while (j > 0 && (array[j - 1] > currentNumberToSort))
                {
                    int temp = array[j - 1];
                    array[j - 1] = array[j];
                    array[j] = temp;
                    j--;
                }
            }
            return array;
        }
    }
}
