namespace Tribonacci
{
    using System;
    using System.Numerics;

    class Tribonacci
    {
        static void Main()
        {
            BigInteger x = BigInteger.Parse(Console.ReadLine());
            BigInteger y = BigInteger.Parse(Console.ReadLine());
            BigInteger z = BigInteger.Parse(Console.ReadLine());
            BigInteger n = BigInteger.Parse(Console.ReadLine());
            BigInteger result = 0;
            if (n == 1)
            {
                Console.WriteLine(x);
            }
            else if (n ==2)
            {
                Console.WriteLine(y);
            }
            else if (n == 3)
            {
                Console.WriteLine(z);
            }
            else
            {
                for (int i = 3; i < n; i++)
                {

                    result = x + y + z;
                    x = y;
                    y = z;
                    z = result;

                }
                Console.WriteLine(result);
            }
        }
    }
}
