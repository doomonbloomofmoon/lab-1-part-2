using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_6
    {
        int cols = 5;
        int rows = 6;
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
            if (cols % 2 != 0)
            {
                for (int i = 0; i < cols / 2; i++)
                    for (int j = 0; j < rows; j++)
                    {
                        int tmp = collection[i, j];
                        collection[i, j] = collection[cols - 1 - i, j];
                        collection[cols - 1 - i, j] = tmp;
                    }
                Console.WriteLine();
                Console.WriteLine("Массив после работы программы: ");
                for (int i = 0; i < cols; i++)
                {
                    for (int j = 0; j < rows; j++)
                        Console.Write($"{collection[i, j]}   ");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
        public Par_6()
        {
            collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    collection[i, j] = rand.Next(10);
        }
    }
}


