using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.AngryFemaleGPS
{
    class Program
    {
        static void Main(string[] args)
        {
            string numbs = Console.ReadLine();
            int sumEven = 0;
            int sumOdd = 0;
            foreach (char symbol in numbs)
            {
                if (char.IsDigit(symbol))
                {
                    if (symbol % 2 == 0)
                    {
                        sumEven += symbol - '0';
                    }
                    else 
                    {
                        sumOdd += symbol - '0';
                    }
                }
            }
            if (sumEven>sumOdd)
            {
                Console.WriteLine("right {0}", sumEven);
            }
            else if (sumEven<sumOdd)
            {
                Console.WriteLine("left {0}", sumOdd);
            }
            else
            {
                Console.WriteLine("straight {0}", sumOdd);
            }
        }
    }
}
