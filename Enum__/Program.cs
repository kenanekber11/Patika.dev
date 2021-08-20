using System;

namespace Enum__
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine(Gunler.Pazar);
          Console.WriteLine((int)Gunler.Pazar);  

        int sicaklik=int.Parse(Console.ReadLine());
          if (sicaklik <=(int)HavaDurumu.Soguk)
          {
             Console.WriteLine("Dışarı çıkmak için havanın biraz ısınmasını bekleyelim..");
          }  
          else if (sicaklik >=(int)HavaDurumu.Soguk && sicaklik<=(int)HavaDurumu.Sıcak)
          {
             Console.WriteLine("Hadi dışarı çıkalım");
          }  
          else if (sicaklik >=(int)HavaDurumu.Sıcak)
          {
             Console.WriteLine("Hava sıcak akşam dışarı çıkalım..");
          }  
          else if (sicaklik >=(int)HavaDurumu.Coksicak)
          {
             Console.WriteLine("Dışarı çıkmak için aşırı sıcak..");
          }  


        }
    }
    enum Gunler
    {
        Pazartesi=1,
        Salı,
        Carsamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu
    {
        Soguk=15,
        Normal=30,
        Sıcak=35,
        Coksicak=40
    }
}
