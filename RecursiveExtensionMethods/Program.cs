using System;

namespace RecursiveExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
          // Rekürsif - Öz yinelemeli
          // 3^4=3*3*3*3
          int result=1;
          for (int i = 1; i < 5; i++)
          {
              result=result*3;
          } 
          Console.WriteLine(result);
            Islemler islemler=new Islemler();
            int cevap=islemler.Expo(3,4);
            Console.WriteLine(cevap);

            string ifade="Zikriye Ürkmez Cengiz";
            bool sonuc=ifade.CheckSpaces();
            Console.WriteLine(sonuc);

            if(sonuc)
                Console.WriteLine(ifade.RemoveWhiteSpaces());

            Console.WriteLine(ifade.MakeUpper());

            int[] sayilar={212,12,48,84,8,12,1,878};

          sayilar.ArraySort();  
          sayilar.EkranaYazdir();    

          string ifade2="Kodluyoruz";
          Console.WriteLine(ifade2.GetFirstCharacter());      
        }
    }

    class Islemler
    {
        public int Expo(int sayi,int us)
        {
            if (us<2)
            {
                return sayi;
            }
            return Expo(sayi,us-1)*sayi;

           
        }
    //  Expo(3,4)*3
    //  Expo(3,3)*3
    //  Expo(3,2)*3*3
    //  Expo(3,1)3*
    }

    public static class Extension
    {
        public static bool CheckSpaces(this string param)
        {
            return param.Contains(" ");
        }

        public static string RemoveWhiteSpaces(this string param)
        {
            string[] dizi=param.Split(" ");
            return string.Join("*",dizi);
        }

        public static string MakeUpper(this string param)
        {
            return param.ToUpper();
        }

        public static int[] ArraySort(this int[] param)
        {
            Array.Sort(param);
            return param;
        }

         public static void EkranaYazdir(this int[] param)
        {
            foreach(int item in param)
                Console.WriteLine(item);
        }

        public static string GetFirstCharacter(this string param)
        {
            return param.Substring(0,3);
        }
    }
}
