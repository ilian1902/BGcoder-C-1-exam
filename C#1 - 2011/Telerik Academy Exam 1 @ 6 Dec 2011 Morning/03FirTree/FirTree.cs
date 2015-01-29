

namespace FirTree
{
    using System;

    class FirTree
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int starCound = 1;
            int dotCount = n - 2;


            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', dotCount));
                Console.Write(new string('*', starCound));
                Console.Write(new string('.', dotCount));
                Console.WriteLine();
                dotCount--;
                starCound += 2;
            }
            Console.Write(new string('.', n-2));
            Console.Write('*');
            Console.WriteLine(new string('.', n-2));

        }
    }
}
