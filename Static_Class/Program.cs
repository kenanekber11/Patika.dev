using System;

namespace Static_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Staff.StaffCount);

            Staff staff1=new Staff("Kenan","Akbarov","Software");
            Console.WriteLine(Staff.StaffCount);
            
            Console.WriteLine(Operations.Sum(50,60));
            Console.WriteLine(Operations.Substract(60,30));
        }
    }
    class Staff
    {
        private static int staffCount;

        public static int StaffCount { get => staffCount;}


        private string Name;
        private string Surname;
        private string Department;

        static Staff()
        {
            staffCount=0;
        }

        public Staff(string name, string surname, string department)
        {
            Name = name;
            Surname = surname;
            Department = department;
            staffCount++;
        }

    }
    static class Operations
    {
        public static int Sum(int number1,int number2)
        {   
            return number1+number2;
        }
        public static int Substract(int number1,int number2)
        {
            return number1-number2;
        }
    }
}
