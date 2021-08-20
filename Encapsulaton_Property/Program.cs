using System;

namespace Encapsulaton_Property
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1=new Student("Kenan","Akbarov",12131,1);
            student1.GetStudentInformation();
            student1.ClassNameLow();
            student1.GetStudentInformation();


        }
        
    }
    class Student {
        private string name;
        private string surname;
        private int no;
        private int classname;
        
            public string Name
            { 
                get { return name; }
                set { name = value; }
            }
            public string Surname { get => surname; set => surname = value; }
            public int No { get => no; set => no = value; }
            public int Classname
            { 
            get => classname;
             set 
             {
                  if (value<1)
                  {
                    Console.WriteLine("Class must be high than 1");
                    classname=1;
                  }
                  else
                    classname=value;
             }
            }

            public Student(string name)
        {
            this.name = name;
        }

        public Student(string name, string surname, int no, int classname)
        {
            Name=name;
            Surname = surname;
            No = no;
            Classname = classname;
    
        }

        public Student()
        {
        }
        public void GetStudentInformation()
        {
            Console.WriteLine("Student Name :       {0}",this.Name);
            Console.WriteLine("Student Surname :    {0}",this.Surname);
            Console.WriteLine("Student No :         {0}",this.No);
            Console.WriteLine("Student Class :      {0}",this.Classname);
        }

        public void ClassNameLow()
        {
            this.Classname= this.Classname-1;
        }
        public void ClassNameUp()
        {
            this.Classname=this.Classname+1;
        }
    }
}
