using System;

class AlanHesaplama
{
    static void Main()
    {
        Console.WriteLine("Hangi şeklin alanını ve çevresini hesaplamak istiyorsunuz?");
        Console.WriteLine("Seçenekler: Daire, Üçgen, Kare, Dikdörtgen");
        string sekil = Console.ReadLine().Trim().ToLower();

        Hesapla(sekil);
    }

    static void Hesapla(string sekil)
    {
        switch (sekil)
        {
            case "daire":
                Daire daire = new Daire();
                daire.KenarBilgileriAl();
                daire.Hesapla();
                break;
            case "üçgen":
                Ucgen ucgen = new Ucgen();
                ucgen.KenarBilgileriAl();
                ucgen.Hesapla();
                break;
            case "kare":
                Kare kare = new Kare();
                kare.KenarBilgileriAl();
                kare.Hesapla();
                break;
            case "dikdörtgen":
                Dikdortgen dikdortgen = new Dikdortgen();
                dikdortgen.KenarBilgileriAl();
                dikdortgen.Hesapla();
                break;
            default:
                Console.WriteLine("Geçersiz şekil girdiniz!");
                break;
        }
    }
}

class Daire
{
    private double yaricap;

    public void KenarBilgileriAl()
    {
        Console.Write("Dairenin yarıçapını giriniz: ");
        yaricap = Convert.ToDouble(Console.ReadLine());
    }

    public void Hesapla()
    {
        double alan = Math.PI * yaricap * yaricap;
        double cevre = 2 * Math.PI * yaricap;
        Console.WriteLine($"Dairenin Alanı: {alan:F2}, Çevresi: {cevre:F2}");
    }
}

class Ucgen
{
    private double kenar1, kenar2, kenar3, taban, yukseklik;

    public void KenarBilgileriAl()
    {
        Console.Write("1. Kenarı giriniz: ");
        kenar1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("2. Kenarı giriniz: ");
        kenar2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("3. Kenarı giriniz: ");
        kenar3 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Tabanı giriniz: ");
        taban = Convert.ToDouble(Console.ReadLine());

        Console.Write("Yüksekliği giriniz: ");
        yukseklik = Convert.ToDouble(Console.ReadLine());
    }

    public void Hesapla()
    {
        double cevre = kenar1 + kenar2 + kenar3;
        double alan = (taban * yukseklik) / 2;
        Console.WriteLine($"Üçgenin Alanı: {alan:F2}, Çevresi: {cevre:F2}");
    }
}

class Kare
{
    private double kenar;

    public void KenarBilgileriAl()
    {
        Console.Write("Karenin bir kenar uzunluğunu giriniz: ");
        kenar = Convert.ToDouble(Console.ReadLine());
    }

    public void Hesapla()
    {
        double alan = kenar * kenar;
        double cevre = 4 * kenar;
        Console.WriteLine($"Karenin Alanı: {alan:F2}, Çevresi: {cevre:F2}");
    }
}

class Dikdortgen
{
    private double uzunKenar, kisaKenar;

    public void KenarBilgileriAl()
    {
        Console.Write("Uzun kenarı giriniz: ");
        uzunKenar = Convert.ToDouble(Console.ReadLine());

        Console.Write("Kısa kenarı giriniz: ");
        kisaKenar = Convert.ToDouble(Console.ReadLine());
    }

    public void Hesapla()
    {
        double alan = uzunKenar * kisaKenar;
        double cevre = 2 * (uzunKenar + kisaKenar);
        Console.WriteLine($"Dikdörtgenin Alanı: {alan:F2}, Çevresi: {cevre:F2}");
    }
}
