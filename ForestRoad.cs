using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int height = 2 * width - 1;
            char[,] map = new char[height,width];
            int i, j;

            for (i = 0; i < height / 2 + 1; i++)
            {
                for (j = 0; j < width; j++)
                {
                    if (j != i)
                    {
                        map[i, j] = '.';
                    }
                    else
                    {
                        map[i, j] = '*';
                    }
                }
            }

            for (; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    if (j != width - (i - height / 2) - 1)
                    {
                        map[i, j] = '.';
                    }
                    else
                    {
                        map[i, j] = '*';
                    }
                }
            }

            for(i = 0; i < height; i++)
            {
                for (j = 0; j < width; j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }
        }
    }
}
