using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1_Part_2
{
    internal class Par_11
    {
        int cols = 4;
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
            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            foreach (var item in collection)
            {
                int value;
                if (dictionary.TryGetValue(item, out value))
                    dictionary[item] += 1;
                else
                    dictionary[item] = 0;
            }

            Console.WriteLine("Значения: ");
            foreach (var item in dictionary)
                if (item.Value == 0)
                    Console.Write($"{item.Key} ");
            Console.WriteLine("\n");
        }
        public Par_11()
        {
            this.collection = new int[cols, rows];
            Random rand = new Random();
            for (int i = 0; i < cols; i++)
                for (int j = 0; j < rows; j++)
                    this.collection[i, j] = rand.Next(10);
        }
    }
}

