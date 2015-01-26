using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MathExpression
{
    class MathExpression
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            double n = double.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double p = double.Parse(Console.ReadLine());
            double upLine = n * n + 1 / (m * p) + 1337;
            double downLine = n - 128.523123123 * p;
            double finish = Math.Sin((int)m % 180);
            double sum = (upLine / downLine) + finish;
            Console.WriteLine("{0:F6}",sum);
        }
    }
}
