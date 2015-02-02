namespace ShipDamage
{
    using System;

    class ShipDamage
    {
        static void Main()
        {
            int sX1 = int.Parse(Console.ReadLine());
            int sY1 = int.Parse(Console.ReadLine());
            int sX2 = int.Parse(Console.ReadLine());
            int sY2 = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int cX1 = int.Parse(Console.ReadLine());
            int cY1 = int.Parse(Console.ReadLine());
            int cX2 = int.Parse(Console.ReadLine());
            int cY2 = int.Parse(Console.ReadLine());
            int cX3 = int.Parse(Console.ReadLine());
            int cY3 = int.Parse(Console.ReadLine());
            sY1 -= h;
            sY2 -= h;
            cY1 -= h;
            cY2 -= h;
            cY3 -= h;
            int reflektedCy1 = -cY1;
            int reflektedCy2 = -cY2;
            int reflektedCy3 = -cY3;
            int top = Math.Max(sY1, sY2);
            int left = Math.Min(sX1, sX2);
            int right = Math.Max(sX1, sX2);
            int bottom = Math.Min(sY1, sY2);
            int sum = 0;
            if (reflektedCy1 < top || reflektedCy1 > bottom)
            {
                if (cX1 < right && cX1 > left)
                {
                    sum += 100;
                }
                else if (cX1 == left || cX1 == right)
                {
                    sum += 50;
                }
            }
            if (reflektedCy1 == top || reflektedCy1 == bottom)
            {
                if (cX1 < right && cX1 > left)
                {
                    sum += 50;
                }
                else if (cX1 == left || cX1 == right)
                {
                    sum += 25;
                }
            }
            if (reflektedCy2 < top || reflektedCy2 > bottom)
            {
                if (cX2 < right && cX2 > left)
                {
                    sum += 100;
                }
                else if (cX2 == left || cX2 == right)
                {
                    sum += 50;
                }
            }
            if (reflektedCy2 == top || reflektedCy2 == bottom)
            {
                if (cX2 < right && cX2 > left)
                {
                    sum += 50;
                }
                else if (cX2 == left || cX2 == right)
                {
                    sum += 25;
                }
            }
            if (reflektedCy3 < top || reflektedCy3 > bottom)
            {
                if (cX3 < right && cX3 > left)
                {
                    sum += 100;
                }
                else if (cX3 == left || cX3 == right)
                {
                    sum += 50;
                }
            }
            if (reflektedCy3 == top || reflektedCy3 == bottom)
            {
                if (cX3 < right && cX3 > left)
                {
                    sum += 50;
                }
                else if (cX3 == left || cX3 == right)
                {
                    sum += 25;
                }
            }
            Console.WriteLine(sum + "%");
        }
    }
}
