using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.TheHorror
{
    class TheHorror
    {
        static void Main()
        {
            string num = Console.ReadLine();
            BigInteger sum = 0;
            BigInteger isNum = 0;
            BigInteger count = 0;
            BigInteger countLoops = 0;
            if (num != "0")
            {


                foreach (char symbol in num)
                {
                    if (countLoops % 2 == 0)
                    {
                        if (symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9')
                        {
                            sum += symbol - '0';
                            count++;
                        }
                    }
                    countLoops++;

                }
                Console.WriteLine("{0} {1}", count, sum);
            }
        }
    }
}
