﻿using System;


class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Console.Write(new string('.', n/2+1));
        Console.Write(new string('*', n));
        Console.WriteLine(new string('.', n/2+1));
        for (int i =0 ; i < (n / 2); i++)
        {
            Console.Write(new string('.', n/2-i));
            Console.Write('*');
            Console.Write(new string('.', n/2+i));
            Console.Write('*');
            Console.Write(new string('.', n / 2 + i));
            Console.Write('*');
            Console.Write(new string('.', n / 2 - i));
            Console.WriteLine();
        }
        Console.WriteLine(new string('*', n*2+1));
        for (int i = 0; i < n-1; i++)
        {
            Console.Write(new string('.' , i+1));
            Console.Write('*');
            Console.Write(new string('.', n-2-i));
            Console.Write('*');
            Console.Write(new string('.', n - 2 - i));
            Console.Write('*');
            Console.Write(new string('.', i + 1));
            Console.WriteLine();
        }
        Console.Write(new string('.', n));
        Console.Write('*');
        Console.WriteLine(new string('.', n));
    }
}

