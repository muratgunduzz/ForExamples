using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("For Örnekleri");

        // İlk örnek: 10 kere aynı mesajı yazdırma
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
        }

        // İkinci örnek: 1'den 20'ye kadar sayıları yazdırma
        int sayac = 1;
        for (int i = 0; i < 20; i++)
        {
            Console.WriteLine(sayac);
            sayac++;
        }

        // Üçüncü örnek: 1 ile 20 arasında çift sayıları yazdırma
        int sayac2 = 2;
        for (int i = 0; i < 20; i++)
        {
            if (sayac2 % 2 == 0)
            {
                Console.WriteLine(sayac2);
            }
            sayac2++;
        }

        // 50 ile 150 arasındaki sayıların toplamını hesaplama
        int toplam = 0;
        for (int i = 50; i <= 150; i++)
        {
            toplam += i;
        }
        Console.WriteLine("50 ile 150 arasındaki sayıların toplamı: " + toplam);

        // 0 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı hesaplama
        int ttoplam = 0;
        int ctoplam = 0;
        for (int i = 0; i < 120; i++)
        {
            if (i % 2 != 0) 
            {
                ttoplam += i;
            }
            else
            {
                ctoplam += i;
            }
        }
        Console.WriteLine("Tek sayıların toplamı: " + ttoplam);
        Console.WriteLine("Çift sayıların toplamı: " + ctoplam);
    }
}
