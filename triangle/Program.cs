using System;

class Program
{
    static void Main()
    {
        int size = GetTriangleSize();
        DrawTriangle(size);
    }

    static int GetTriangleSize()
    {
        Console.Write("Üçgenin boyutunu girin: ");
        int size;
        while (!int.TryParse(Console.ReadLine(), out size) || size <= 0)
        {
            Console.Write("Geçerli bir sayı girin: ");
        }
        return size;
    }

    static void DrawTriangle(int size)
    {
        for (int i = 1; i <= size; i++)
        {
            Console.WriteLine(new string('*', i));
        }
    }
}