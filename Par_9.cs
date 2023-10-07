using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_9
    {
        int colOfMaxValue;
        int rowOfMaxValue;
        int maxFromMin;
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
            colOfMaxValue = rowOfMaxValue = 0;
            maxFromMin = int.MinValue;
            int tmpValue;
            int tmpRow = 0;
            for (int i = 0; i < cols; i++)
            {
                tmpValue = collection[i, 0];
                for (int j = 0; j < rows; j++)
                    if (tmpValue > collection[i, j])
                    {
                        tmpValue = collection[i, j];
                        tmpRow = j;
                    }
                if (maxFromMin < tmpValue)
                {
                    maxFromMin = tmpValue;
                    colOfMaxValue = i;
                    rowOfMaxValue = tmpRow;
                }
            }
            Console.WriteLine($"Строка: {this.colOfMaxValue}\n" +
                $"Столбец: {this.rowOfMaxValue}\n" +
                $"Максимальное число из минимальных: {this.maxFromMin}");
        }
        public Par_9()
        {
            this.collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    collection[i, j] = rand.Next(10);
        }
    }
}


