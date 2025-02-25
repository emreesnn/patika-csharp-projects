using System;

class Program
{
    static void Main()
    {
        int radius = GetRadius();
        DrawCircle(radius);
    }

    static public void DrawCircle(int radius)
    {
        for (int y = -radius; y <= radius; y++)
        {
            for (int x = -radius; x <= radius; x++)
            {
                double distance = Math.Sqrt(x * x + y * y);
                if (Math.Round(distance) == radius) 
                {
                    Console.Write("*");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }

    static public int GetRadius()
    {
        Console.Write("Dairenin yarıçapını girin: ");
        int radius;
        while (!int.TryParse(Console.ReadLine(), out radius) || radius <= 0)
        {
            Console.Write("Geçerli bir sayı girin: ");
        }
        return radius;
    }
}
