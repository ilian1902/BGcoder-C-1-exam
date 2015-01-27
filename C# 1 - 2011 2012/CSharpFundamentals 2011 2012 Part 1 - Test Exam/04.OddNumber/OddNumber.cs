namespace OddNumber
{
    using System;
    using System.Numerics;

    class OddNumber
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            long oddNum = 0;
            for (int i = 0; i < n; i++)
            {
                long number = long.Parse(Console.ReadLine());
                oddNum ^= number;// ksor na vsqko chislo dava unikalno chislo na necheten broi
            }
            Console.WriteLine(oddNum);
        }
    }
}
