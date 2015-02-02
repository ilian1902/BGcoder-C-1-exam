using System;
class PeaceOfCake
{
    static void Main()
    {
        long a = int.Parse(Console.ReadLine());
        long b = int.Parse(Console.ReadLine());
        long c = int.Parse(Console.ReadLine());
        long d = int.Parse(Console.ReadLine());
        decimal cakeResult = (decimal)a / b + (decimal)c / d;
        if (cakeResult >=1)
        {
            Console.WriteLine((int)cakeResult);
        }
        else
        {
            Console.WriteLine("{0:F22}", cakeResult);
        }
        Console.WriteLine("{0}/{1}",a*d+c*b, b*d);
    }
}
