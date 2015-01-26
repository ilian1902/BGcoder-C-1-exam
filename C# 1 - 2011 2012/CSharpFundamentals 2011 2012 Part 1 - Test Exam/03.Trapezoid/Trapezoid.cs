namespace Trapezoid
{
    using System;

    class Trapezoid
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int hight = n + 1;
            int topTrapec = n;
            int bottonTrapec = n * 2;
            int firstLine = n - 1;



            Console.Write(new string('.', n));
            Console.WriteLine(new string('*', n));
            for (int i = 1; i < hight - 1; i++)
            {
                Console.Write(new string('.', n - i));
                Console.Write('*');
                Console.Write(new string('.', n - 2 + i));
                Console.Write('*');
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', bottonTrapec));
        }
    }
}
