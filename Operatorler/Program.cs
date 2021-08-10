using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atama ve işlemli atama
            int x=3;
            int y=2;
            x=x+3;
            y+=2;
            Console.WriteLine(x);
            Console.WriteLine(y);

            // Mantıksal Operatörler
            bool isSuccess=true;
            bool isCompleted=false;
            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }  

            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }  

            // İlişkisel Operatörler
            // < , > , <= , >= , == , !=  
            int a=3;
            int b=4;
            bool sonuc= a<=b;
            Console.WriteLine(sonuc);
            sonuc= a<b;
            Console.WriteLine(sonuc);
            sonuc= a>=b;
            Console.WriteLine(sonuc);
            sonuc= a==b;
            Console.WriteLine(sonuc);
            sonuc= a!=b;
            Console.WriteLine(sonuc);

            // +,-,*,/
            int sayi1=10;
            int sayi2=5;
            int sonuc1=sayi1+sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1-sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1*sayi2;
            Console.WriteLine(sonuc1);
            sonuc1=sayi1/sayi2;
            Console.WriteLine(sonuc1);
            sonuc1 =sayi1++;
            Console.WriteLine(sayi1);
            System.Console.WriteLine(sonuc1);
            // Mod alma
            int sayi3=20%3;
            System.Console.WriteLine(sayi3);
        }
    }
}
