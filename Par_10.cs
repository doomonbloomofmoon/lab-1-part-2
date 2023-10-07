using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_10
    {
        int[,] collection;
        int cols = 3;
        int rows = 3;
        
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

            int tmpValue = collection[0, 0];
            int maxColId = 0;
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (tmpValue < collection[i, j])
                    {
                        tmpValue = collection[i, j];
                        maxColId = i;
                    }
                }
            }

            int[,] tmpItems = new int[cols - 1, rows];
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    if (i < maxColId)
                    {
                        tmpItems[i, j] = collection[i, j];
                    }
                    else if (i > maxColId)
                    {
                        tmpItems[i - 1, j] = collection[i, j];
                    }
                }
            }

            collection = tmpItems;
            cols--;
            Console.WriteLine($"Наибольший элемент: {tmpValue}\nСтолбец: {maxColId}\n");

            Console.WriteLine("Массив после работы программы: ");
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                    Console.Write($"{collection[i, j]}   ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public Par_10()
        {
            this.collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    this.collection[i, j] = rand.Next(10);
        }
    }
}
