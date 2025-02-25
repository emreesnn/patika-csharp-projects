using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Derinlik belirleyiniz: ");
        if (int.TryParse(Console.ReadLine(), out int derinlik) && derinlik > 0)
        {
            int[] fib = new int[derinlik];
            Fibonacci(derinlik, fib);

            Console.WriteLine("Fibonacci Serisi:");
            foreach (int num in fib)
            {
                Console.Write(num + " ");
            }

            double ortalama = OrtalamaHesapla(fib);
            Console.WriteLine($"\nOrtalama: {ortalama}");
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir pozitif tamsayı giriniz.");
        }

        Console.Read();
    }

    static void Fibonacci(int n, int[] fib)
    {
        if (n > 0) fib[0] = 0;
        if (n > 1) fib[1] = 1;

        for (int i = 2; i < n; i++)
        {
            fib[i] = fib[i - 1] + fib[i - 2];
        }
    }

    static double OrtalamaHesapla(int[] dizi)
    {
        double toplam = 0;
        foreach (int sayi in dizi)
        {
            toplam += sayi;
        }
        return dizi.Length > 0 ? toplam / dizi.Length : 0;
    }
}
