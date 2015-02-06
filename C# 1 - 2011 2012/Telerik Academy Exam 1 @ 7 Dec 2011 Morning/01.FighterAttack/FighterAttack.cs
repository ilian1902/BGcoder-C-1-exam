namespace FighterAttack
{
    using System;
    using System.Drawing;

    class FighterAttack
    {
        static void Main()
        {
            int plantX1 = int.Parse(Console.ReadLine());
            int plantY1 = int.Parse(Console.ReadLine());
            int plantX2 = int.Parse(Console.ReadLine());
            int plantY2 = int.Parse(Console.ReadLine());

            int flayX = int.Parse(Console.ReadLine());
            int flayY = int.Parse(Console.ReadLine());

            int dictance = int.Parse(Console.ReadLine());
            int sum = 0;
            flayX = flayX + dictance;


            int topPlants = Math.Max(plantY1, plantY2);
            int bottomPlants = Math.Min(plantY1, plantY2);
            int leftPlants = Math.Min(plantX1, plantX2);
            int rightPlants = Math.Max(plantX1, plantX2);

            if ((flayX >= leftPlants) && (flayX <= rightPlants) && (flayY >= bottomPlants) && (flayY <= topPlants))
            {
                sum += 100;
            }
            if ((flayX + 1 >= leftPlants) && (flayX + 1 <= rightPlants) && (flayY >= bottomPlants) && (flayY <= topPlants))
            {
                sum += 75;
            }
            if ((flayX >= leftPlants) && (flayX <= rightPlants) && (flayY + 1 >= bottomPlants) && (flayY + 1 <= topPlants))
            {
                sum += 50;
            }
            if ((flayX >= leftPlants) && (flayX <= rightPlants) && (flayY - 1 >= bottomPlants) && (flayY - 1 <= topPlants))
            {
                sum += 50;
            }
            Console.WriteLine(sum + "%");
        }
    }
}
