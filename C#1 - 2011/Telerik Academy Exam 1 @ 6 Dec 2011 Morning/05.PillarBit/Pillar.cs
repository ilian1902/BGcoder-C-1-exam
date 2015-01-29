using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PillarBit
{
    class Pillar
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = (number >> col) & 1;
                }
            }
            int pillarIndex = 7;
            int countBitsLeft = 0;
            int countBitRight = 0;
            bool founSolution = false;

            while (pillarIndex >= 0)
            {
                countBitRight = 0;
                countBitsLeft = 0;
                for (int col = 0; col < pillarIndex; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {
                        if (matrix[row, col] == 1)
                        {
                            countBitsLeft++;
                        }

                    }
                }
                for (int col = pillarIndex +1; col < 8; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {
                        if (matrix[row, col] == 1)
                        {
                            countBitRight++;
                        }

                    }
                }
                if (countBitRight == countBitsLeft)
                {
                    founSolution = true;
                    break;
                }
                pillarIndex--;
            }
            if (founSolution)
            {
                Console.WriteLine(pillarIndex);
                Console.WriteLine(countBitsLeft);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
