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

            Console.WriteLine("\n");

            Staff staff3=new Staff("Kenan","Akbarov",1231646,"Yazılım");
            staff3.StaffInfo();

            Console.WriteLine("\n");

            Staff staff4=new Staff("İhsan","Yılmaz");
            staff4.StaffInfo2();
        }
        class Staff
        {
            public string Name;
            public string Surname;
            public int No;
            public string Depatment;

            public Staff(){}

           public Staff(string name,string surname,int no, string department)
           {
                this.Name=name;
                this.Surname=surname;
                this.No=no;
                this.Depatment=department;
           } 
            public Staff(string name,string surname)
           {
                this.Name=name;
                this.Surname=surname;   
           } 

            public void StaffInfo()
            {
                Console.WriteLine("Çalışanın Adı : {0}", Name);
                Console.WriteLine("Çalışanın Adı : {0}", Surname);
                Console.WriteLine("Çalışanın Adı : {0}", No);
                Console.WriteLine("Çalışanın Adı : {0}", Depatment);
            }
               public void StaffInfo2()
            {
                Console.WriteLine("Çalışanın Adı : {0}", Name);
                Console.WriteLine("Çalışanın Adı : {0}", Surname);
            }


        }
    }
}
