using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Lines
{
    class Lines
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[8, 8];
            for (int row = 0; row < 8; row++)
            {
                int number = int.Parse(Console.ReadLine());
                for (int col = 0; col < 8; col++)
                {
                    if ((number & (1 << col)) != 0)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }
            int maxLine = 0;
            int counter = 0;
            for (int row = 0; row < 8; row++)
            {
                for (int col = 0; col < 8; col++)
                {
                    int line = 0;
                    while (col < 8 && matrix[row, col] == 1)
                    {
                        col++;
                        line++;
                    }
                    if (line == maxLine)
                    {
                        counter++;
                    }
                    if (line > maxLine)
                    {
                        maxLine = line;
                        counter = 1;
                    }

                }
            }

            for (int col = 0; col < 8; col++)
            {
                for (int row = 0; row < 8; row++)
                {
                    int line = 0;
                    while (row < 8 && matrix[row, col] == 1)
                    {
                        row++;
                        line++;
                    }
                    if (line == maxLine)
                    {
                        counter++;
                    }
                    if (line > maxLine)
                    {
                        maxLine = line;
                        counter = 1;
                    }
                }
            }
            if (maxLine == 1)
            {
                counter = counter / 2;
            }
            Console.WriteLine(maxLine);
            Console.WriteLine(counter);
        }
    }
}
