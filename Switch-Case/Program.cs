using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month=DateTime.Now.Month;
            // Expression
            switch (month)
            {
                case 1: Console.WriteLine("Ocak");
                break;
                case 2: Console.WriteLine("Şubat");
                break;
                case 3: Console.WriteLine("Mart");
                break;
                case 4: Console.WriteLine("Nisan");
                break;
                case 5: Console.WriteLine("Mayıs");
                break;
                case 6: Console.WriteLine("Haziran");
                break;
                case 7: Console.WriteLine("Temmuz");
                break;
                case 8: Console.WriteLine("Ağustos");
                break;
                case 9: Console.WriteLine("Eylül");
                break;
                case 10: Console.WriteLine("Ekim");
                break;
                case 11: Console.WriteLine("Kasım");
                break;
                case 12: Console.WriteLine("Aralık");
                break;
                default: Console.WriteLine("Yanlış veri girdiniz");
                break;
            }

            switch (month)
            {
                case 12: 
                case 1:
                case 2:
                Console.WriteLine("Kış Ayındasınız");
                break;
                case 3: 
                case 4:
                case 5:
                Console.WriteLine("İlkbahar Ayındasınız");
                break;
                case 6: 
                case 7:
                case 8:
                Console.WriteLine("Yaz Ayındasınız");
                break;
                case 9: 
                case 10:
                case 11:
                Console.WriteLine("Sonbahar Ayındasınız");
                break; 
                default:
                break;
            }
        }
    }
}
