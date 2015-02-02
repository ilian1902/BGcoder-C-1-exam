using System;

class Garden
{
    static void Main()
    {
        decimal tomatoSeeds = int.Parse(Console.ReadLine());
        int tomatoArea = int.Parse(Console.ReadLine());
        decimal cucumberSeeds = int.Parse(Console.ReadLine());
        int cucumberArea = int.Parse(Console.ReadLine());
        decimal potatoSeeds = int.Parse(Console.ReadLine());
        int potatoArea = int.Parse(Console.ReadLine());
        decimal carrotSeeds = int.Parse(Console.ReadLine());
        int carrotArea = int.Parse(Console.ReadLine());
        decimal cabaggeSeeds = int.Parse(Console.ReadLine());
        int cabaggeArea = int.Parse(Console.ReadLine());
        decimal beansSeeds = int.Parse(Console.ReadLine());
        int beansArea = 0;
        int totalArea = 250;
        decimal totalCost = 0;
        if (tomatoSeeds >= 0)
        {
            if (totalArea >= 0)
            {
                totalArea -= tomatoArea;
            }
            totalCost += tomatoSeeds * 0.5m;
            
        }
        if (cucumberSeeds >= 0)
        {
            if (totalArea >= 0)
            {
                totalArea -= cucumberArea;
            }
            totalCost += cucumberSeeds * 0.4m;
            
        }
        if (potatoSeeds >= 0)
        {
            if (totalArea >= 0)
            {
                totalArea -= potatoArea;
            }
            totalCost += potatoSeeds * 0.25m;
            
        }
        if (carrotSeeds >= 0)
        {
            if (totalArea >= 0)
            {
                totalArea -= carrotArea;
            }
            totalCost += carrotSeeds * 0.6m;
            
        }
        if (cabaggeSeeds >= 0)
        {
            if (totalArea >= 0)
            {
                totalArea -= cabaggeArea;
            }
            totalCost += cabaggeSeeds * 0.3m;
            
        }
        if (beansSeeds >= 0)
        {
            totalCost += beansSeeds * 0.4m;
            if (totalArea>0)
            {
                beansArea = totalArea;
                
            }
        }
        Console.WriteLine("Total costs: {0}", totalCost);
        if (beansArea>0)
        {
            Console.WriteLine("Beans area: {0}", beansArea);
        }
        else if (totalArea == 0)
        {
            Console.WriteLine("No area for beans");
        }
        if (totalArea<0)
        {
            Console.WriteLine("Insufficient area");
        }
        

    }
}

