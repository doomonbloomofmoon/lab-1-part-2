using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_12
    {
        int[,] collection;
        int colsAndRows = 10;
        public void Start()
        {
            Console.WriteLine("Значения массива: ");
            for (int i = 0; i < colsAndRows; i++)
            {
                for (int j = 0; j < colsAndRows; j++)
                    Console.Write($"{collection[i, j]}   ");
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < colsAndRows; i++)
            {

            }

            Console.WriteLine("Значения массива: ");
            for (int i = 0; i < colsAndRows; i++)
            {
                for (int j = 0; j < colsAndRows; j++)
                    Console.Write($"{collection[i, j]}   ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        public Par_12()
        {
            this.collection = new int[colsAndRows, colsAndRows];
            Random rand = new Random();
            for (int i = 0; i < colsAndRows; i++)
                for (int j = 0; j < colsAndRows; j++)
                    collection[i, j] = rand.Next(10);
        }
    }
}
