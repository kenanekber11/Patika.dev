using System;

namespace Class_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Staff staff1 = new Staff();
            staff1.Name = "Ayla";
            staff1.Surname = "Korkmaz";
            staff1.No = 52;
            staff1.Depatment = "Satınalma";
            staff1.StaffInfo();

            Console.WriteLine("\n");

            Staff staff2 = new Staff();
            staff2.Name = "Okan";
            staff2.Surname = "Korkmaz";
            staff2.No = 12;
            staff2.Depatment = "Muhasebe";
            staff2.StaffInfo();
        }
        class Staff
        {
            public string Name;
            public string Surname;
            public int No;
            public string Depatment;

            public void StaffInfo()
            {
                Console.WriteLine("Çalışanın Adı : {0}", Name);
                Console.WriteLine("Çalışanın Adı : {0}", Surname);
                Console.WriteLine("Çalışanın Adı : {0}", No);
                Console.WriteLine("Çalışanın Adı : {0}", Depatment);

            }

        }
    }
}
