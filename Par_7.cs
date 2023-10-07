using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_7
    {
        int[,] collection;
        int cols = 5;
        int rows = 5;
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
            int temp;
            for (int i = 0; i < cols - 1; i++)
            {
                for (int j = 0; j < rows - i - 1; j++)
                {
                    temp = collection[i, j];
                    collection[i, j] = collection[cols - j - 1, rows - i - 1];
                    collection[cols - j - 1, rows - i - 1] = temp;
                }
            }
            Console.WriteLine("Массив после работы программы: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{collection[i, j]}   ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public Par_7()
        {
            this.collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    collection[i, j] = rand.Next(10);
        }
    }
}


