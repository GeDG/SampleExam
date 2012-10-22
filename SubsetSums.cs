using System;
using System.Linq;

namespace SubsetSums
{
    class Program
    {

        static void FindNumbers(long[] list, int index, long current, long goal, ref int howMany)
        {
            if (list.Length < index)
                return;
            for (int i = index; i < list.Length; i++)
            {
                if (current + list[i] == goal)
                {
                    howMany++;
                    if (list[i] <= 0)
                    {
                        FindNumbers(list, i + 1, current + list[i], goal, ref howMany);
                    }
                }
                else if(list[i] <= 0 || current + list[i] < goal)
                {
                    FindNumbers(list, i + 1, current + list[i], goal, ref howMany);
                }
            }
        }

        static void Main()
        {
            long s = long.Parse(Console.ReadLine());
            byte n = byte.Parse(Console.ReadLine());
            long[] numbers = new long[n];
            for (int i = 0; i < n; i++)
            {
                numbers[i] = long.Parse(Console.ReadLine());
            }
            Array.Sort(numbers);
            int numberOfSubsets = 0;
            FindNumbers(numbers, 0, 0, s, ref numberOfSubsets);
            Console.WriteLine(numberOfSubsets);
        }
    }
}
