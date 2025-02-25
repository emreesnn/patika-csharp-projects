using System;

class Program
{
    static void Main()
    {
        string input = GetInputFromUser();
        RemoveIndexFromInput(input);
        
        Console.Read();
    }

    static string GetInputFromUser()
    {
        Console.Write("Bir string ifade giriniz: ");
        string input = Console.ReadLine();
        Console.Write("Bir pozitif tamsayı giriniz: ");
        input += "," + Console.ReadLine();
        Console.WriteLine("Girilen input değeri : " + input);
        return input;
    }

    static void RemoveIndexFromInput(string input)
    {
        int indexOfComma = input.IndexOf(",");

        string numberStr = input.Substring(indexOfComma + 1);
        int removeIndexNum = int.Parse(numberStr); 

        Console.WriteLine("Silinecek indeks: " + removeIndexNum);

        string text = input.Substring(0, indexOfComma);
        if (removeIndexNum >= 0 && removeIndexNum < text.Length)
        {
            text = text.Remove(removeIndexNum, 1);
        }

        Console.WriteLine("Sonuç: " + text);
    }
}