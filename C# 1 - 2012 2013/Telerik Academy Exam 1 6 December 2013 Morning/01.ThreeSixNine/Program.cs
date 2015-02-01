


namespace _01.ThreeSixNine
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            long a = long.Parse(Console.ReadLine());
            long b = long.Parse(Console.ReadLine());
            long c = long.Parse(Console.ReadLine());
            long r;
            if (b == 3)
            {
                r = a + c;
                if (r % 3 == 0)
                {
                    r = r / 3;
                    Console.WriteLine(r);
                }
                else
                {
                    r = r % 3;
                    Console.WriteLine(r);
                }
                r = a + c;
                Console.WriteLine(r);

            }
            if (b == 6)
            {
                r = a * c;
                if (r % 3 == 0)
                {
                    r = r / 3;
                    Console.WriteLine(r);
                }
                else
                {
                    r = r % 3;
                    Console.WriteLine(r);
                }
                r = a * c;
                Console.WriteLine(r);
            }
            if (b == 9)
            {
                r = a % c;
                if (r % 3 == 0)
                {
                    r = r / 3;
                    Console.WriteLine(r);
                }
                else
                {
                    r = r % 3;
                    Console.WriteLine(r);
                }
                r = a % c;
                Console.WriteLine(r);
            }
        }
    }
}
