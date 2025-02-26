using System;

class Program
{
    static void Main()
    {
        Console.Write("Bir cümle giriniz: ");
        string input = Console.ReadLine();
        string[] words = input.Split(' ');

        for (int i = 0; i < words.Length; i++)
        {
            words[i] = SwapFirstAndLastChar(words[i]);
        }

        Console.WriteLine(string.Join(" ", words));
    }

    static string SwapFirstAndLastChar(string word)
    {
        if (word.Length <= 1) return word; 

        char first = word[0];
        char last = word[word.Length - 1];

        return last + word.Substring(1, word.Length - 2) + first;
    }
}
