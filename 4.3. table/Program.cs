using System;

namespace mynamespase
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[,] array = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 } };
            foreach(var itm in array)
            {
                Console.Write(itm + " ");
            }
            Console.WriteLine("\nДлина массива: {0}", array.Length);

            Console.Write("Кол-во строк: ");
            Console.WriteLine(array.GetUpperBound(0) + 1 + " ");

            Console.Write("Кол-во колонок: ");
            Console.WriteLine(array.GetUpperBound(1) + 1 + " ");

            for(int i = 0; i < array.GetUpperBound(0) + 1; i++)
            {
                for(int k = 0; k < array.GetUpperBound(1) + 1; k++)
                {
                    Console.Write(array[i, k] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}