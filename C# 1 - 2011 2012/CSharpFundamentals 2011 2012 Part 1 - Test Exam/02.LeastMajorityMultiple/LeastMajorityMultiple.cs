namespace LeastMajorityMultiple
{
    using System;

    class LeastMajorityMultiple
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int result = 0;
            int majuritNum = 1;
            


            while (result == 0)
            {
                int count = 0;
                if (majuritNum % a == 0)
                {
                    count++;
                }
                if (majuritNum % b == 0)
                {
                    count++;
                }
                if (majuritNum % c == 0)
                {
                    count++;
                }
                if (majuritNum % d == 0)
                {
                    count++;
                }
                if (majuritNum % e == 0)
                {
                    count++;
                }
                if (count >= 3)
                {
                    result = majuritNum;
                }
                majuritNum++;
            }
            Console.WriteLine(result);
        }
    }
}
