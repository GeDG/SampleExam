using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class Program
    {
        static void Main(string[] args)
        {
            int judges = int.Parse(Console.ReadLine());
            int[] catVotes = new int[10];
            int max = 0, bestCat = 0;

            for (int counter = 0; counter < judges; counter++)
            {
                if (++catVotes[int.Parse(Console.ReadLine()) - 1] > max)
                {
                    max++;
                }
            }

            for (int counter = 0; counter < 10; counter++)
            {
                if (catVotes[counter] == max)
                {
                    bestCat = counter + 1;
                    break;
                }
            }
            Console.WriteLine(bestCat);
        }
    }
}
