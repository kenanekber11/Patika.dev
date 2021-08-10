using System;

namespace values
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            byte b1 = 2;          // 1 byte
            sbyte b2 = -16;       // 1 byte   
            short s1 = 5;         // 2 byte
            ushort u1 = 1;        // 2 byte  
            Int16 i16=125;        // 2 byte   
            int i = 2;            // 4 byte
            Int32 i32 = 1055;     // 4 byte
            Int64 i64 = 151006;   // 8 byte
            uint ui = 2;          // 4 byte
            long l1 = 4;          // 8 byte
            ulong ul1 = 4;        // 8 byte  
            float f1 = 4.2f;       // 4 byte  
            double d1= 4.3;       // 8 byte  
            decimal de = 3.5m;     // 16 byte

            char c = '2';         // 2 byte
            string str= "Kenan";  // sınırsız

            bool boolean1 = true; 
            bool boolean2 = false;    
            DateTime dt=DateTime.Now;

            Console.WriteLine(dt);

            string ad="Kenan";
            string soyad="Akbarov";
            string tamad= ad+soyad;

            string str20 = "28";
            int int20 = 28;
            string yenideger1= str20 + int20.ToString();
            Console.WriteLine(yenideger1);

            int yenideger2=int20+int.Parse(str20);
            Console.WriteLine(yenideger2);

            int yenideger3= int20+ Convert.ToInt32(str20);
            Console.WriteLine(yenideger3);

            string datetime1=DateTime.Now.ToString("dd.MM.yyyy");
            Console.WriteLine(datetime1);

            // datetime

            string datetime2=DateTime.Now.ToString("dd/MM/yyyy");
            Console.WriteLine(datetime2);

            // hour

            string hour = DateTime.Now.ToString("HH:mm");
            Console.WriteLine(hour);
            
        }
    }
}
