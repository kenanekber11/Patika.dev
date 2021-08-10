using System;

namespace Tip_Donusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
           // Implicit Conversion (Bilinçsiz Dönüşüm)
          Console.WriteLine("***Implicit Conversion***");
            Console.WriteLine("");
            byte a=5;
            sbyte b=30;
            short c=10;
            int d=a+b+c;
            Console.WriteLine("d " +d);

            long h=d;
            System.Console.WriteLine("h " + h);

            float i=h;
            System.Console.WriteLine("i " + i);

            string e="zikriye";
            char f= 'k';
            object g=e+f+d;
            System.Console.WriteLine(g);

           // Explicit Conversion (Bilinçli Dönüşüm)
           Console.WriteLine("***Explicit Conversion***");
            Console.WriteLine(" ");
           int x=4;
           byte b1=(byte)x;
           System.Console.WriteLine(b1);

           int z=100;
           byte t=(byte)z; 
           System.Console.WriteLine(t);

           float flo1=10.8f;
           byte f1=(byte)flo1;
           System.Console.WriteLine(f1);

            System.Console.WriteLine("String Methodu");
           int xx=6;
           string zz=xx.ToString();
            Console.WriteLine("zz "+ zz);

            string ff=12.5f.ToString();
            Console.WriteLine(ff);

            // System Convert
            Console.WriteLine("System Convert");
            string s1="10",s2="20";
            int say1=Convert.ToInt32(s1);
            int say2=Convert.ToInt32(s2);
            int toplam= say1+say2;
            Console.WriteLine("Toplam = " + toplam);
        
            // Parse
           Console.WriteLine("****Parse eMethod***");
           ParseMethod();


           string exp="11";
           byte ss=byte.Parse(exp);
           Console.WriteLine(byte.Parse(exp));
        }
public static void ParseMethod()
{
    string metin1="10";
    string metin2 = "20";
    int rakam1;
    double double1;

    rakam1=int.Parse(metin1);
    double1=double.Parse(metin2);

    Console.WriteLine(rakam1);
    Console.WriteLine(double1);

}

    }
}
