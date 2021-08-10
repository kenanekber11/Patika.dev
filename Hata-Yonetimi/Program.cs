using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
           /* 
            try
            {
            Console.WriteLine("Bir sayı giriniz");
            int sayi1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Girmiş olduğunuz sayı " +sayi1); 
            }
             catch(Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
             finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }


             try
            {
                int a= int.Parse(null);

            }
             catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex.Message.ToString());
            }
             finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }


             try
            {
                int a= int.Parse("test");

            }
             catch(ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                Console.WriteLine(ex.Message.ToString());
            }
                 catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil");
                Console.WriteLine(ex.Message.ToString());
            }
             finally
            {
                Console.WriteLine("İşlem tamamlandı");
            }
*/

            
             try
            {
                int a= int.Parse("-2000000000000");

            }
             catch(OverflowException ex)
            {
                Console.WriteLine("çok büyük ya da çok küçük değer girdiniz..");
                Console.WriteLine(ex);
            }
        }
    }
}
