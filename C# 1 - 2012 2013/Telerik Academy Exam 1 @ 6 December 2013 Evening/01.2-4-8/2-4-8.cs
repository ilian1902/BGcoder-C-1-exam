using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01._2_4_8
{
    class twoFourEight
    {
        static void Main()
        {
            BigInteger a = BigInteger.Parse(Console.ReadLine());
            BigInteger b = BigInteger.Parse(Console.ReadLine());
            BigInteger c = BigInteger.Parse(Console.ReadLine());
            BigInteger r;
            BigInteger result = 0;
            if (b == 2)
            {
                r = a % c;

                if (r % 4 == 0)
                {
                    result = r / 4;
                    Console.WriteLine(result);
                    Console.WriteLine(r);
                }
                else
                {
                    result = r % 4;
                    Console.WriteLine(result);
                    Console.WriteLine(r);
                }
            }
            if (b == 4)
            {
                r = a + c;

                if (r % 4 == 0)
                {
                    result = r / 4;
                    Console.WriteLine(result);
                    Console.WriteLine(r);
                }
                else
                {
                    result = r % 4;
                    Console.WriteLine(result);
                    Console.WriteLine(r);
                }
            }
            if (b == 8)
            {
                r = a * c;

                if (r % 4 == 0)
                {
                    result = r / 4;
                    Console.WriteLine(result);
                    Console.WriteLine(r);
                }
                else
                {
                    result = r % 4;
                    Console.WriteLine(result);
                    Console.WriteLine(r);
                }
            }
        }
    }
}
