using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.OnesAndZeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string nBin = Convert.ToString(n, 2).PadLeft(32, '0');

            //printing

            string oneRow0 = ".#.";
            string oneRow1 = "##.";
            string oneRow2 = ".#.";
            string oneRow3 = ".#.";
            string oneRow4 = "###";

            string zeroRow0 = "###";
            string zeroRow1 = "#.#";
            string zeroRow2 = "#.#";
            string zeroRow3 = "#.#";
            string zeroRow4 = "###";
            //row0
            for (int row = 16; row < nBin.Length; row++)
            {
                if (nBin[row] == '1')
                {
                    Console.Write(oneRow0);
                }
                if (nBin[row] == '0')
                {
                    Console.Write(zeroRow0);
                }
                if (row != nBin.Length - 1)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            //row1
            for (int row = 16; row < nBin.Length; row++)
            {
                if (nBin[row] == '1')
                {
                    Console.Write(oneRow1);
                }
                if (nBin[row] == '0')
                {
                    Console.Write(zeroRow1);
                }
                if (row != nBin.Length - 1)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            //row2
            for (int row = 16; row < nBin.Length; row++)
            {
                if (nBin[row] == '1')
                {
                    Console.Write(oneRow2);
                }
                if (nBin[row] == '0')
                {
                    Console.Write(zeroRow2);
                }
                if (row != nBin.Length - 1)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            //row3
            for (int row = 16; row < nBin.Length; row++)
            {
                if (nBin[row] == '1')
                {
                    Console.Write(oneRow3);
                }
                if (nBin[row] == '0')
                {
                    Console.Write(zeroRow3);
                }
                if (row != nBin.Length - 1)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
            //row4
            for (int row = 16; row < nBin.Length; row++)
            {
                if (nBin[row] == '1')
                {
                    Console.Write(oneRow4);
                }
                if (nBin[row] == '0')
                {
                    Console.Write(zeroRow4);
                }
                if (row != nBin.Length - 1)
                {
                    Console.Write('.');
                }
            }
            Console.WriteLine();
        }
    }
}
