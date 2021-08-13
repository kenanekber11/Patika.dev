using System;

namespace Loop_Break_Continue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            // Ekrandan girilen sayı aralığında tek olanları yazdırma
            Console.WriteLine("Lütfen bir sayı giriniz..");
            int sayac=int.Parse(Console.ReadLine());
            for (int i = 1; i <= sayac; i++)
            {
                if (i%2==1)
                {
                    Console.WriteLine(i);
                }
            }
            // 1 ile 1000 arasındaki sayıların kendi içlerinde tek ve çift toplamlarını alma
            int tekToplam=0;
            int ciftToplam=0;
            for (int i = 0; i < 1000; i++)
            {
                if (i%2==0)
                {
                    ciftToplam+=i;
                }
                else
                    tekToplam+=i;
            }
            Console.WriteLine("Tek sayıların toplamı " + tekToplam);
            Console.WriteLine("Çift sayıların toplamı " + ciftToplam);
*/
            // Break, Continue 
            for (int i = 0; i < 10; i++)
            {
                if (i==4)   
                    break;
                    Console.WriteLine(i);
                
            }

           for (int i = 0; i <10; i++)
           {
               if (i==4)
                 continue;
                   Console.WriteLine(i);

           }
        }
    }
}
