using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryDigitsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            char b;
            string[] numbers;

            b = char.Parse(Console.ReadLine());
            n = int.Parse(Console.ReadLine());
            
            numbers = new string[n];

            for (int i = 0; i < n; i++)
            {
                numbers[i] = Convert.ToString(uint.Parse(Console.ReadLine()), 2);
            }

            int count;

            for (int i = 0; i < n; i++)
            {
                count = 0;
                for (int j = 0; j < numbers[i].Length; j++)
                {
                    if (numbers[i][j] == b)
                        count++;
                }
                Console.WriteLine(count);
            }
        }
    }
}
