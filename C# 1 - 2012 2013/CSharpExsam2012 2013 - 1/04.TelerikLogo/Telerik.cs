using System;


namespace TelerikLogo
{
    class Telerik
    {
        static void Main()
        {
            int x = int.Parse(Console.ReadLine());
            int y = x;
            int z = x / 2 + 1;
            int width = (2 * z + 2 * x) - 3;
            int hight = width;
            int[,] matrix = new int[width, hight];

            int currentRow = x / 2;
            int currentCol = 0;

         




            for (int row = 0; row < hight; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    if (matrix[row, col] == 0)
                    {
                        Console.Write('.');
                    }
                    else if (matrix[row, col] == 1)
                    {
                        Console.Write('*');
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
