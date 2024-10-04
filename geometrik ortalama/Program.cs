using System;

class Program
{
    static void Main()
    {
        double sayi1, sayi2;

        // Kullanıcıdan birinci sayıyı al
        while (true)
        {
            Console.Write("Birinci sayıyı girin (pozitif bir sayı): ");
            if (double.TryParse(Console.ReadLine(), out sayi1) && sayi1 > 0)
                break; // Geçerli bir sayı girildi
            Console.WriteLine("Lütfen geçerli bir pozitif sayı girin.");
        }

        // Kullanıcıdan ikinci sayıyı al
        while (true)
        {
            Console.Write("İkinci sayıyı girin (pozitif bir sayı): ");
            if (double.TryParse(Console.ReadLine(), out sayi2) && sayi2 > 0)
                break; // Geçerli bir sayı girildi
            Console.WriteLine("Lütfen geçerli bir pozitif sayı girin.");
        }

        // Geometrik ortalamayı hesapla
        double geometrikOrtalama = Math.Sqrt(sayi1 * sayi2);

        // Sonucu yazdır
        Console.WriteLine($"Girilen sayıların geometrik ortalaması: {geometrikOrtalama}");
    }
} 