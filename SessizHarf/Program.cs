using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle giriniz:");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        foreach (string word in words)
        {
            Console.Write(SessizHarfKontrol(word) + " ");
        }

        Console.WriteLine();
    }

    static bool SessizHarfKontrol(string word)
    {
        string sesli = "aeıioöuüAEIİOÖUÜ";

        for (int i = 0; i < word.Length - 1; i++)
        {
            if (!sesli.Contains(word[i]) && !sesli.Contains(word[i + 1]))
            {
                return true;
            }
        }

        return false;
    }
}
