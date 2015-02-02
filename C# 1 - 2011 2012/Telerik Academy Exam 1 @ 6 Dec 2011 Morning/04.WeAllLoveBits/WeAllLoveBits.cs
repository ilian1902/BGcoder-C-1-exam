namespace WeAllLoveBits
{
    using System;

    class WeAllLoveBits
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int linesN = int.Parse(Console.ReadLine());
                string realNumber = Convert.ToString(linesN, 2);
                string revarstNumber = "";
                for (int j = realNumber.Length - 1; j >= 0; j--)
                {
                    revarstNumber += realNumber[j];
                }
                int endResult = Convert.ToInt32(revarstNumber, 2);
                Console.WriteLine(endResult);
            }
            //output

        }
    }
}
