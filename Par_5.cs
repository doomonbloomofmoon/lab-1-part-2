using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_5
    {
        int cols = 6;
        int rows = 5;
        int[,] collection;
        public void Start()
        {
            Console.WriteLine("Значения массива: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{collection[i, j]}   ");
                Console.WriteLine();
            }
            Console.WriteLine();
            if (rows % 2 != 0)
            {
                for (int i = 0; i < rows / 2; i++)
                {
                    for (int j = 0; j < cols; j++)
                    {
                        int tmp = collection[j, i];
                        collection[j, i] = collection[j, rows - 1 - i];
                        collection[j, rows - 1 - i] = tmp;
                    }
                }
                Console.WriteLine("Массив после работы программы: ");
                for (int i = 0; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                        Console.Write($"{collection[i, j]}   ");
                    Console.WriteLine();
                }
            }
        }
        public Par_5()
        {
            collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    collection[i, j] = rand.Next(10);
        }
    }
}


