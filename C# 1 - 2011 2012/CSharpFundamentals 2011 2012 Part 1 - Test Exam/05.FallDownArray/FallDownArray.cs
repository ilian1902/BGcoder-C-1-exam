namespace FallDown
{
    using System;

    class FallDown
    {
        static void Main()
        {
            //input
            int[] nums = new int[8];
            for (int i = 0; i < 8; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }
            //solutin
            for (int i = 0; i < 7; i++)
            {
                for (int line = 7; line > 0; line--)
                {
                    for (int bitPosition = 0; bitPosition < 8; bitPosition++)
                    {
                        if ((nums[line] >> bitPosition & 1) == 0 && (nums[line - 1] >> bitPosition & 1) == 1)
                        {
                            nums[line] |= (1 << bitPosition);
                            nums[line - 1] ^= (1 << bitPosition);
                        }
                    }
                }
            }
            //outputa
            for (int line = 0; line < 8; line++)
            {
                Console.WriteLine(nums[line]);
            }
        }
    }
}
