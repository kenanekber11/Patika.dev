using System;

namespace Struct_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Dikdortgen dikdortgen = new Dikdortgen();
            dikdortgen.UzunKenar = 6;
            dikdortgen.Kisakenar = 3;
            Console.WriteLine(dikdortgen.Hesapla());

        // Struct Yapıların Classlardan en büyük farkı new-lenmeden çalışmalarıdır

        //  DikdörtgenStruct dikdörtgenStruct=new DikdörtgenStruct();
            DikdörtgenStruct dikdörtgenStruct;
            dikdörtgenStruct.Kisakenar = 4;
            dikdörtgenStruct.UzunKenar = 7;
            Console.WriteLine(dikdörtgenStruct.Hesapla());

        // Constructor oluştuktan sonra
            DikdörtgenStruct dikdörtgenStruct1 = new DikdörtgenStruct(6, 10);
            Console.WriteLine(dikdörtgenStruct1.Hesapla());

        // Başka bir fark ise Struct yapılara parametre vermediğimiz sürece initialize edemeyiz!!!
        // Aşağıda Class ve Structların bununla ilgili örnekleri yer almaktadır..
            Dikdortgen dikdortgen1 = new Dikdortgen();
            // dikdortgen.UzunKenar = 6;
            //dikdortgen.Kisakenar = 3;
            Console.WriteLine(dikdortgen1.Hesapla());

            DikdörtgenStruct dikdörtgenStruct2= new DikdörtgenStruct();
            // dikdörtgenStruct.Kisakenar = 4;
            // dikdörtgenStruct.UzunKenar = 7;
            Console.WriteLine(dikdörtgenStruct.Hesapla());

        }
    }
    class Dikdortgen
    {
        public int Kisakenar;
        public int UzunKenar;

        public Dikdortgen()
        {
            Kisakenar = 6;
            UzunKenar = 10;
        }

        public long Hesapla()
        {
            return this.Kisakenar * this.UzunKenar;
        }
    }

    struct DikdörtgenStruct
    {
        public int Kisakenar;
        public int UzunKenar;

        // Struct yapılarda parametresiz constructor tanımlayamazsınız
        /*
        public DikdortgenStruct(){
            Kisakenar=6;
            UzunKenar=10;
        }
        */

        public DikdörtgenStruct(int kisakenar, int uzunKenar)
        {
            Kisakenar = kisakenar;
            UzunKenar = uzunKenar;
        }

        public long Hesapla()
        {
            return this.Kisakenar * this.UzunKenar;
        }
    }

}
