using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_3
    {
        int cols = 5;
        int rows = 5;
        int maxValue;
        int colOfMaxValue;
        int[,] collection;
        public Par_3()
        {
            collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    collection[i, j] = rand.Next(10);
        }
        public void Start()
        {
            maxValue = 0;
            colOfMaxValue = 0;
            Console.WriteLine("Элементы массива: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{collection[i, j]}  ");
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine("Средние значения столбцов:");
            for (int i = 0; i < cols; i++)
            {
                int temp = 0;
                for (int j = 0; j < rows; j++)
                    temp += collection[i, j];
                int colAvg = temp / cols;
                Console.Write($"{colAvg}  ");
                if (colAvg > maxValue)
                {
                    maxValue = colAvg;
                    colOfMaxValue = i;
                }
            }
            Console.WriteLine();
            Console.WriteLine($"\nНаибольшее значение: {maxValue}\n" + $"Номер столбца: {colOfMaxValue}");
        }
    }
}


