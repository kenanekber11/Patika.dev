using System;

namespace While_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            // Girilen sayıların toplamını ekrana yazdırma..
            // Sıfıra basınca sayılar toplamı verir
            int toplam = 0;
            for (int i = 0;; i++)
            {
                int sayi=int.Parse(Console.ReadLine());
                toplam+=sayi;
                if (sayi==0)
                {
                    break;
                }
            }
            Console.WriteLine(toplam);
            Console.WriteLine("****************************");
            
            // Önceden belirlenmiş sayıda Girilen sayıların ortalamasını alan program
           double girilecekSayi=double.Parse(Console.ReadLine());
           double sayiToplami =0;
           int j=0;
           while (j<girilecekSayi)
           {
               double sayi=double.Parse(Console.ReadLine());
               sayiToplami+=sayi;
               j++;
           }
           double ortalama=sayiToplami/girilecekSayi;
           Console.WriteLine("Girilen sayılar toplamı "+sayiToplami);
           Console.WriteLine("Girilen sayılar ortalaması "+ ortalama);
           Console.WriteLine("****************************");

       // 'a' dan 'z' e kadar tüm harfleri ekrana yazdırma
        char character='a';
        while (character<='z')
        {
            Console.WriteLine(character);
            character++;
        }
            Console.WriteLine("****************************");

        // ForEach Kullanımı
        string[] arabalar={"BMW","Ford","Toyota","Nissan"};
        foreach (var araba in arabalar)
        {
            Console.WriteLine(araba);
        }
    }
  }
}
