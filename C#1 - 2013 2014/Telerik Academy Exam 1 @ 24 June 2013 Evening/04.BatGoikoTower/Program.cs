using System;

class Program
{
    static void Main()
    {
        int height = int.Parse(Console.ReadLine());
        int rowUpdate = 2;
        
        int countRowFromTop = 2;
        for (int i = 1; i <= height; i++)
        {
            var middlepoint = '.';
            if (i == countRowFromTop)
            {
                middlepoint = '-';
                countRowFromTop += rowUpdate;
                ++rowUpdate;
            }
            Console.Write(new string('.', height-i));
            Console.Write("/");
            Console.Write(new string(middlepoint, 2*i-2));
            Console.Write("\\");
            //if
           
            Console.Write(new string('.', height-i));
            Console.WriteLine();
        }
    }
}

