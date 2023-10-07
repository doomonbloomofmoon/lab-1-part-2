using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_4
    {
        int cols = 4;
        int rows = 4;
        int[,] collection;
        public Par_4()
        {
            collection = new int[cols, rows];
        }
        public void Start()
        {
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    this.collection[i, j] = rand.Next(10);
            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{this.collection[i, j]}  ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int i = 0; i < cols; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    int temp = this.collection[j, i];
                    this.collection[j, i] = this.collection[i, j];
                    this.collection[i, j] = temp;
                }
            }
            Console.WriteLine("Элементы после работы программы: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{this.collection[i, j]}  ");
                Console.WriteLine();
            }
        }
    }
}


