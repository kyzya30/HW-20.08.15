using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = {6, 8, 2, 4, 9, 1, 3};
            Console.WriteLine("Массив до сортировки:");
            foreach (var val in array)
            {
                Console.WriteLine(val);
            }
            array.UpSort();
            Console.WriteLine("Массив после сортировки:");
            foreach (var val in array)
            {
                Console.WriteLine(val);
            }
        }
    }

    public static class MyExtensions
    {
        public static int[] UpSort(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int z = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = z;
                    }
                }
            }
            return array;
        }
    }
}
