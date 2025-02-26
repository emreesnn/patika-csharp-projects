using System;
using System.Collections.Generic;
using System.IO;

class ATM
{
    static Dictionary<string, string> users = new Dictionary<string, string>()
    {
        {"ahmet", "1234"},
        {"ayse", "5678"}
    };

    static Dictionary<string, double> balances = new Dictionary<string, double>()
    {
        {"ahmet", 1000},
        {"ayse", 2000}
    };

    static List<string> transactionLogs = new List<string>();
    static string currentUser = "";

    static void Main()
    {
        Console.WriteLine("=== ATM Uygulamasına Hoş Geldiniz ===");

        if (!Login())
        {
            Console.WriteLine("Giriş başarısız! Program sonlandırılıyor.");
            return;
        }

        while (true)
        {
            Console.WriteLine("\nYapmak istediğiniz işlemi seçiniz:");
            Console.WriteLine("1. Bakiye Görüntüleme");
            Console.WriteLine("2. Para Çekme");
            Console.WriteLine("3. Para Yatırma");
            Console.WriteLine("4. Gün Sonu Raporu");
            Console.WriteLine("5. Çıkış");
            Console.Write("Seçiminiz: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    CheckBalance();
                    break;
                case "2":
                    Withdraw();
                    break;
                case "3":
                    Deposit();
                    break;
                case "4":
                    EndOfDayReport();
                    break;
                case "5":
                    Console.WriteLine("Çıkış yapıldı. İyi günler!");
                    return;
                default:
                    Console.WriteLine("Geçersiz seçim! Tekrar deneyin.");
                    break;
            }
        }
    }

    static bool Login()
    {
        Console.Write("Kullanıcı adınızı giriniz: ");
        string username = Console.ReadLine();

        Console.Write("Şifrenizi giriniz: ");
        string password = Console.ReadLine();

        if (users.ContainsKey(username) && users[username] == password)
        {
            currentUser = username;
            Console.WriteLine($"Giriş başarılı! Hoş geldiniz, {username}");
            transactionLogs.Add($"{DateTime.Now}: {username} giriş yaptı.");
            return true;
        }
        else
        {
            Console.WriteLine("Hatalı kullanıcı adı veya şifre!");
            transactionLogs.Add($"{DateTime.Now}: Hatalı giriş denemesi yapıldı.");
            return false;
        }
    }

    static void CheckBalance()
    {
        Console.WriteLine($"Bakiyeniz: {balances[currentUser]} TL");
        transactionLogs.Add($"{DateTime.Now}: {currentUser} bakiyesini görüntüledi.");
    }

    static void Withdraw()
    {
        Console.Write("Çekmek istediğiniz tutarı giriniz: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount > 0 && amount <= balances[currentUser])
        {
            balances[currentUser] -= amount;
            Console.WriteLine($"{amount} TL çekildi. Yeni bakiyeniz: {balances[currentUser]} TL");
            transactionLogs.Add($"{DateTime.Now}: {currentUser} {amount} TL çekti.");
        }
        else
        {
            Console.WriteLine("Geçersiz tutar veya yetersiz bakiye!");
            transactionLogs.Add($"{DateTime.Now}: {currentUser} başarısız para çekme girişiminde bulundu.");
        }
    }

    static void Deposit()
    {
        Console.Write("Yatırmak istediğiniz tutarı giriniz: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        if (amount > 0)
        {
            balances[currentUser] += amount;
            Console.WriteLine($"{amount} TL yatırıldı. Yeni bakiyeniz: {balances[currentUser]} TL");
            transactionLogs.Add($"{DateTime.Now}: {currentUser} {amount} TL yatırdı.");
        }
        else
        {
            Console.WriteLine("Geçersiz tutar!");
            transactionLogs.Add($"{DateTime.Now}: {currentUser} başarısız para yatırma girişiminde bulundu.");
        }
    }

    static void EndOfDayReport()
    {
        string fileName = $"EOD_{DateTime.Now:ddMMyyyy}.txt";
        File.WriteAllLines(fileName, transactionLogs);
        Console.WriteLine($"Gün sonu raporu oluşturuldu: {fileName}");
    }
}
