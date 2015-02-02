using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightmareOnCodeStreet
{
    class NightmareOnCodeStreet
    {
        static void Main()
        {
            string text = Console.ReadLine();
            int count = 0;
            int countOdd = 0;
            int sum = 0;
            foreach (char symbol in text)
            {
                if (count % 2 != 0)
                {
                    if (symbol == '0' || symbol == '1' || symbol == '2' || symbol == '3' || symbol == '4' || symbol == '5' || symbol == '6' || symbol == '7' || symbol == '8' || symbol == '9')
                    {
                        countOdd++;
                        sum += symbol - '0';
                    }
                }
                count++;
            }
            Console.WriteLine("{0} {1}", countOdd, sum);

        }
    }
}
