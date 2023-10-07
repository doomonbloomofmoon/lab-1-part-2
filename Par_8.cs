using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_8
    {
        int[,] collection;
        int cols = 7;
        int rows = 6;
        int colOfMaxValue;
        int rowOfMaxValue;
        int maxFromMin;
        public void Start()
        {
            colOfMaxValue = rowOfMaxValue = maxFromMin = int.MinValue;
            Console.WriteLine("Значения массива: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{collection[i, j]}   ");
                Console.WriteLine();
            }
            Console.WriteLine();
            for (int j = 0; j < rows; j++)
            {
                int min = this.collection[0, j];
                int tmp = 0;
                for (int i = 0; i < cols; i++)
                    if (min > this.collection[i, j])
                    {
                        min = this.collection[i, j];
                        tmp = i;
                    }
                if (min > maxFromMin)
                {
                    this.maxFromMin = min;
                    this.colOfMaxValue = tmp;
                    this.rowOfMaxValue = j;
                }
            }
            Console.WriteLine($"Строка: {this.colOfMaxValue},\n" +
                $"Стобец: {this.rowOfMaxValue}\n" +
                $"Максимальное число из минимальных: {this.maxFromMin}\n");
        }
        public Par_8()
        {
            this.collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    collection[i, j] = rand.Next(10);
        }
    }
}


