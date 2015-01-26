namespace OddNumber
{
    using System;
    using System.Numerics;

    class OddNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                BigInteger number = BigInteger.Parse(Console.ReadLine());
                if (i % 2 != 0)
                {
                    counter++;
                }
                Console.WriteLine(counter);


            }
        }
    }
}
