namespace Pillars
{
    using System;

    class Pillars
    {
        static void Main()
        {

            int[,] matrix = new int[8, 8];
            for (int row = 0; row < 8; row++)
            {
                int n = int.Parse(Console.ReadLine());
                string realNum = Convert.ToString(n, 2).PadLeft(8, '0');
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = int.Parse(realNum[col].ToString());
                }

            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            int countleft = 0;
            int countRight = 0;
            int numberCol = 7;
            bool foundSolution = false;
            while (numberCol >= 0)
            {
                countleft = 0;
                countRight = 0;
                for (int col = 0; col < numberCol; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {

                        if (matrix[row, col] == '1')
                        {
                            countleft++;
                        }
                    }
                }
                for (int col = numberCol + 1; col < 8; col++)
                {
                    for (int row = 0; row < 8; row++)
                    {

                        if (matrix[row, col] == '1')
                        {
                            countRight++;
                        }
                    }
                }
                if (countRight == countleft)
                {
                    foundSolution = true;
                    break;
                }
                else
                {
                    numberCol++;
                }

            }
            if (foundSolution)
            {
                Console.WriteLine(numberCol);
                Console.WriteLine(countleft);
            }
            else
            {
                Console.WriteLine("No");
            }

        }
    }
}
