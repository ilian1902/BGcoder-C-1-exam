namespace KaspichaniaBoats
{
    using System;

    class KaspichaniaBoats
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int shirina = n * 2 + 1;
            int visochina = 6 + ((n - 3) / 2) * 3;
            int counter = 0;

            Console.Write(new string('.', n));
            Console.Write("*");
            Console.WriteLine(new string('.', n));
            for (int i = 0; i < n - 1; i++)
            {
                Console.Write(new string('.', (n - i) - 1));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', i));
                Console.Write("*");
                Console.Write(new string('.', (n - i) - 1));
                Console.WriteLine();
            }
            Console.WriteLine(new string('*', shirina));
            for (int j = 0; j < ((n / 2) + 1) - 1; j++)
            {
                Console.Write(new string('.', j + 1));
                Console.Write("*");
                Console.Write(new string('.', ((n - j) - 1) - 1));
                Console.Write("*");
                Console.Write(new string('.', ((n - j) - 1) - 1));
                Console.Write("*");
                Console.Write(new string('.', j + 1));
                Console.WriteLine();
            }
            Console.Write(new string('.', (n / 2) + 1));
            Console.Write(new string('*', n ));
            Console.WriteLine(new string('.', (n / 2) + 1));
        }
    }
}
