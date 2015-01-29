using System;


namespace BinaryDigitsCount
{
    class BinaryDigits
    {
        static void Main()
        {
            int b = int.Parse(Console.ReadLine());
            long n = long.Parse(Console.ReadLine());
            string number = "";
            long numbers = 0;
           
            long current1 = 0;
            long current0 = 0;
            for (int i = 0; i < n; i++)
            {
                numbers = long.Parse(Console.ReadLine());
                number = Convert.ToString(numbers, 2);
                current0 = 0;
                current1 = 0;
                foreach (char symbol in number)
                {
                    if (b == 1)
                    {
                        if (symbol == '1')
                        {
                            current1++;

                        }
                    }
                    else
                    {
                        if (symbol == '0')
                        {
                            current0++;

                        }
                    }
                    
                }
                if (b == 1)
                {
                    Console.WriteLine(current1);
                }
                else
                {
                    Console.WriteLine(current0);
                }
                
            }
            
            
            
        }
    }
}
