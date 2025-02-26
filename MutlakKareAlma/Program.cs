using System;

class Program
{
    static void Main()
    {
        string[] splittedInput = GetUserInput();
        Calculate(splittedInput);
    }

    static string[] GetUserInput()
    {
        Console.WriteLine("Boşluk bırakarak istediğiniz kadar sayı girin: ");
        string input = Console.ReadLine();
        string[] splittedInput = input.Split(' ');

        return splittedInput;
    }

    static void Calculate(string[] input)
    {
        int resultMin = 0;
        int resultMax = 0;
        foreach(string str in input)
        {
            int num = Convert.ToInt32(str);

            if (num <= 67)
            {
                resultMin += 67 - num;
            }
            else
            {
                resultMax += (num - 67) * (num - 67);
            }
        }
        Console.WriteLine(resultMin + " " + resultMax);
    }
}

