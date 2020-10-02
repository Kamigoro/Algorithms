using System;
using System.Linq;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            Random randNum = new Random();
            int[] array = Enumerable.Repeat(0, 5000).Select(i => randNum.Next(0, 10000)).ToArray();

            array = BubbleSort(array);

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
        static int[] BubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j + 1] < array[j])
                    {
                        int temp = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = temp;
                    }
                }
            }

            return array;
        }

    }
}
