﻿using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        // Referanslar kopyalar üzerinde değil onların adresteki değeri üzerinde oynama yapar
        {
            int a=2;
            int b=3;
            Console.WriteLine(a+b);

            int sonuc=Topla(a,b);
            Console.WriteLine(sonuc);


            Metotlar ornek=new Metotlar();
            ornek.EkranaYazdir(sonuc.ToString());

            int sonuc2= ornek.ArttirTopla(ref a,ref b);
            ornek.EkranaYazdir(sonuc2.ToString());
            ornek.EkranaYazdir(sonuc2.ToString());

        }
        static int Topla(int deger1,int deger2)
        {
             return (deger1+deger2);   
        }
        
    }
    class Metotlar
    {
        public void EkranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }
        public int ArttirTopla(ref int deger1,ref int deger2)
        {
             deger1+=1;
             deger2+=1;  
             return deger1+deger2; 
        }
    }

}
