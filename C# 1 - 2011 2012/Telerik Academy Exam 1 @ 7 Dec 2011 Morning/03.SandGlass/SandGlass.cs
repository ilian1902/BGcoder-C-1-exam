namespace SandGlass
{
    using System;

    class SandGlass
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int asterisk = n;

            for (int i = 0; i < n / 2; i++)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', asterisk));
                Console.Write(new string('.', i));
                Console.WriteLine();
                asterisk -= 2;
            }
            asterisk = n % 2;
            for (int i = (n / 2); i >= 0; i--)
            {
                Console.Write(new string('.', i));
                Console.Write(new string('*', asterisk));
                Console.Write(new string('.', i));
                Console.WriteLine();
                asterisk += 2;
            }

        }
    }
}
