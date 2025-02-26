namespace KarakterTerstenYazdirma;

class Program
{
    static void Main(string[] args)
    {
        string text = GetUserInput();
        Console.WriteLine(ReverseString(text)); 
    }

    static string GetUserInput()
    {
        Console.WriteLine("String bir ifade giriniz: ");
        string input = Console.ReadLine();
        return input;
    }

    static string ReverseString(string input)
    {
        string[] splittedText = input.Split(' ');
        string reversedText = "";

        foreach(string str in splittedText)
        {
            string reversedStr = "";
            for (int i = str.Length-1; i>=0; i--)
            {
                reversedStr += str[i];
            }
            reversedText += reversedStr + " ";
        }
        return reversedText;
    }
}