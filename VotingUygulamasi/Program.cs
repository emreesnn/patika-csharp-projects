using System;
using System.Collections.Generic;

class VotingApp
{
    static Dictionary<string, int> votes = new Dictionary<string, int>()
    {
        {"Film", 0},
        {"Tech Stack", 0},
        {"Spor", 0}
    };

    static HashSet<string> registeredUsers = new HashSet<string>();

    static void Main()
    {

        while (true)
        {
            Console.Write("Kullanıcı adınızı giriniz (yeni kayıt için bir kullanıcı adı yazın): ");
            string username = Console.ReadLine().Trim();

            if (!registeredUsers.Contains(username))
            {
                Console.Write("Bu kullanıcı kayıtlı değil. Yeni kullanıcı olarak kaydedilsin mi? (E/H): ");
                string response = Console.ReadLine().Trim().ToLower();

                if (response == "e")
                {
                    registeredUsers.Add(username);
                    Console.WriteLine("Kayıt işlemi başarılı! Şimdi oy kullanabilirsiniz.");
                }
                else
                {
                    Console.WriteLine("Oylama için kayıtlı olmalısınız!");
                    continue;
                }
            }

            Console.WriteLine("\nOylama kategorileri:");
            foreach (var category in votes.Keys)
            {
                Console.WriteLine($"- {category}");
            }

            Console.Write("Hangi kategoriye oy vermek istiyorsunuz? ");
            string voteCategory = Console.ReadLine().Trim();

            if (votes.ContainsKey(voteCategory))
            {
                votes[voteCategory]++;
                Console.WriteLine($"{voteCategory} kategorisine oyunuz kaydedildi!\n");
            }
            else
            {
                Console.WriteLine("Geçersiz kategori seçimi, tekrar deneyin.\n");
            }

            Console.Write("Başka bir oy kullanmak ister misiniz? (E/H): ");
            if (Console.ReadLine().Trim().ToLower() != "e")
                break;
        }

        ShowResults();
    }

    static void ShowResults()
    {
        Console.WriteLine("\n=== Oylama Sonuçları ===");

        int totalVotes = 0;
        foreach (var vote in votes.Values)
        {
            totalVotes += vote;
        }

        foreach (var category in votes)
        {
            double percentage = totalVotes > 0 ? (category.Value * 100.0 / totalVotes) : 0;
            Console.WriteLine($"{category.Key}: {category.Value} oy (%{percentage:F2})");
        }

        Console.WriteLine("\nOylama tamamlandı.");
    }
}
