using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Sayıları giriniz:");
        string input = Console.ReadLine();
        string[] parts = input.Split(' ');

        if (parts.Length % 2 != 0)
        {
            Console.WriteLine("Çift sayıda giriş yapınız!");
            return;
        }

        for (int i = 0; i < parts.Length; i += 2)
        {
            int num1 = Convert.ToInt32(parts[i]);
            int num2 = Convert.ToInt32(parts[i + 1]);
            int sum = num1 + num2;

            if (num1 == num2)
                Console.Write(sum * sum + " "); 
            else
                Console.Write(sum + " ");
        }

        Console.WriteLine();
    }
}
