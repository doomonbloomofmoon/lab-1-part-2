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
        int currentNumber = 1;
        public void Start()
        {
            int rowStart = 0;
            int rowEnd = colsAndRows - 1;
            int colStart = 0;
            int colEnd = colsAndRows - 1;
            while (currentNumber <= colsAndRows * colsAndRows)
            {
                // Fill top row
                for (int i = colStart; i <= colEnd; i++)
                    collection[rowStart, i] = currentNumber++;
                rowStart++;
                // Fill right column
                for (int i = rowStart; i <= rowEnd; i++)
                    collection[i, colEnd] = currentNumber++;
                colEnd--;
                // Fill bottom row
                for (int i = colEnd; i >= colStart; i--)
                    collection[rowEnd, i] = currentNumber++;
                rowEnd--;
                // Fill left column
                for (int i = rowEnd; i >= rowStart; i--)
                    collection[i, colStart] = currentNumber++;
                colStart++;
            }
            Console.WriteLine("Значения массива: ");
            for (int i = 0; i < colsAndRows; i++)
            {
                for (int j = 0; j < colsAndRows; j++)
                    Console.Write($"{collection[i, j]}\t");
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        public Par_12()
        {
            this.collection = new int[colsAndRows, colsAndRows];
        }
    }
}

