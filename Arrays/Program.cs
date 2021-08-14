using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] renkler = new string[3];
            string[] hayvanlar = { "Ayı", "Keçi", "Maymun", "Köpek", "Kedi" };

            int[] dizi;
            dizi = new int[6];

            renkler[0] = "Mavi";
            renkler[1] = "Turuncu";
            renkler[2] = "Kırmızı";

            dizi[0] = 11;
            dizi[1] = 4;
            dizi[2] = 20;

            Console.WriteLine(dizi[2]);
            Console.WriteLine(renkler[1]);
            Console.WriteLine(hayvanlar[4]);

            // Döngülerle dizi kullanımı
            // Klavyeden girilen n tane sayının ortalamasnı hesaplayan program
            int diziUzunlugu = int.Parse(Console.ReadLine());
            int[] sayıDizisi = new int[diziUzunlugu];

            for (int i = 0; i < diziUzunlugu; i++)
            {
                Console.WriteLine("Lütfen {0}. sayıyı giriniz ", i + 1);
                sayıDizisi[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (var sayilar in sayıDizisi)
                toplam += sayilar;

            Console.WriteLine("Ortalama " + toplam / diziUzunlugu);
        }
    }
}
