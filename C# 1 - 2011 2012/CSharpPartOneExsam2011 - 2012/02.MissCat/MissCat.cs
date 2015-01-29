using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MissCat
{
    class MissCat
    {
        static void Main()
        {
            int catNumber = int.Parse(Console.ReadLine());
            int[] cat = new int[11];
            for (int i = 0; i < catNumber; i++)
            {
                int vote = int.Parse(Console.ReadLine());
                cat[vote]++;
            }
            int bestCat = 0;
            int bestCatVote = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (cat[i] > bestCatVote)
                {
                    bestCat = i;
                    bestCatVote = cat[i];
                }
            }
            Console.WriteLine(bestCat);
        }
    }
}
