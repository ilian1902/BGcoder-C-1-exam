using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForestRoad
{
    class ForestRoad
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int mapHeight = (2 * n) - 1;
            char asterick = '*';
            char dot = '.';
            for (int row = 1; row <= n-1; row++)
            {
                Console.Write(new string(dot, row - 1));
                Console.Write(asterick);
                Console.WriteLine(new string(dot, n-row));
            }
            Console.Write(new string(dot, n - 1));
            Console.WriteLine(asterick);
            for (int row = n-1; row > 0; row--)
            {
                Console.Write(new string(dot, row - 1));
                Console.Write(asterick);
                Console.WriteLine(new string(dot, n - row));
            }
        }
    }
}
