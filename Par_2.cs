using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_2
    {
        int cols = 5;
        int rows = 5; 
        int[] sum;
        int[,] collection;
        public void Start()
        {
            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write($"{collection[i, j]}   ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 1; j < rows; j++)
            {
                for (int i = 0; i < cols; i++)
                {
                    if (i + j < rows)
                    {
                        Console.Write($"{this.collection[i, i + j]}      ");
                        this.sum[j - 1] += this.collection[i, i + j];
                    }
                }
                for (int k = 0; k < j*7; k++)
                    Console.Write(" ");
                Console.Write($"({this.sum[j - 1]})");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public Par_2()
        {
            this.collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    collection[i, j] = rand.Next(10);
            this.sum = new int[rows - 1];
        }
    }
}


