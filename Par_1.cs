using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    class Par_1
    {
        int volue_1;
        int volue_2;
        double maxLength;
        int[,] collection =
        {
            { 2, 8 },
            { 3, -1 },
            { 0,  2 },
            { 5, 5 },
            { 9, 4 },
            { -1, 4 }
        };
        public void Start()
        {
            Console.Write("Значения (x и y соответственно): ");
            for (int i = 0; i < collection.GetLength(0); i++)
            {
                Console.Write($"({collection[i, 0]}, {collection[i, 1]}) ");
            }
            Console.WriteLine();
            for (int i = 0; i < collection.GetLength(0); i++)
            {
                for (int j = i; j < collection.GetLength(0); j++)
                {
                    if (i != j)
                    {
                        double length = CalcLength(collection[i, 0], collection[i, 1], collection[j, 0], collection[j, 1]);

                        if (length > maxLength)
                        {
                            maxLength = length;
                            volue_1 = i;
                            volue_2 = j;
                        };
                    }
                }
            }
            Console.WriteLine($"Максимальная длина от ({collection[volue_1, 0]}, {collection[volue_1, 1]}) к ({collection[volue_2, 0]}, {collection[volue_2, 1]}) равна {maxLength}");
            double CalcLength(int x1, int y1, int x2, int y2)
            {
                return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            }
        }
    }
}


