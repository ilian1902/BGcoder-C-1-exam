using System;
using System.Text;
namespace FallDownMatrix
{
    internal class FallDownMatrix
    {
        private static void Main()
        {
            int[,] matrix = new int[8, 8];
            // Input
            for (int row = 0; row < 8; row++)
            {
                int num = int.Parse(Console.ReadLine());// prochitam chisloto na vseki red
                string numToString = Convert.ToString(num, 2).PadLeft(8, '0');// obrashtam chisloto v dvoichna sistema i dobawqm noli ot lqvo.
                for (int col = 0; col < 8; col++)
                {
                    matrix[row, col] = int.Parse(numToString[col].ToString());// dobavq na vsqka kletka tova koeto e v stringa 0 ili 1
                }
            }
            // Solution
            for (int col = 0; col < 8; col++)
            {
                int count = 0;
                for (int row = 0; row < 8; row++)// zapisva edinicite v kolonata
                {
                    if (matrix[row, col] == 1)
                    {
                        count++;
                        matrix[row, col] = 0;// zapomnqme edinicite i gi iztrivame
                    }
                }
                for (int i = 0; i < count; i++)// podrejda zapisanite edinici ot dolu na gore
                {
                    matrix[7 - i, col] = 1;
                }
            }
            //for (int row = 0; row < 8; row++)
            //{
            // for (int col = 0; col < 8; col++)
            // {
            // Console.Write(matrix[row, col] + " ");
            // }
            // Console.WriteLine();
            //}
            // Output
            for (int row = 0; row < 8; row++)
            {
                StringBuilder sb = new StringBuilder();
                for (int col = 0; col < 8; col++)
                {
                    sb.Append(matrix[row, col]);
                }
                int num = Convert.ToInt32(sb.ToString(), 2);// vzemi stringa i mi go obarni ot dvoichna v int
                Console.WriteLine(num);
            }
        }
    }
}