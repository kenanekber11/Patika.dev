using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> values=new List<int>();
            values.Add(10);
            values.Add(23);
            values.Add(42);
            values.Add(32);
            values.Add(12);
            values.Add(21);

            List<string> colors=new List<string>();
            colors.Add("Yellow");
            colors.Add("Red");
            colors.Add("Blue");
            colors.Add("Green");
            colors.Add("Black");

            Console.WriteLine(values.Count);
            Console.WriteLine(colors.Count);

            foreach(var val in values)
                Console.WriteLine(val);

            foreach(var color in colors)
                Console.WriteLine(color);


            //List.ForEach
            values.ForEach(listitem=> Console.WriteLine(listitem));
            colors.ForEach(color=>Console.WriteLine(color));

            // Data Remove From List 1
            values.Remove(42);
            colors.Remove("Green");
            // After Removing
            values.ForEach(listitem=> Console.WriteLine(listitem));
            colors.ForEach(color=>Console.WriteLine(color));

            // Data Remove From List 2
            values.RemoveAt(0);
            colors.RemoveAt(1);
            // After Removing 2
            values.ForEach(listitem=> Console.WriteLine(listitem));
            colors.ForEach(color=>Console.WriteLine(color));

            // Find value into the List
            if (values.Contains(21))
                Console.WriteLine("Found into the List");
            
            Console.WriteLine(values.BinarySearch(21));

            // Array Convert to List
            string[] hayvanlar={"Köpek","Kedi","Kuş"};
            List<string> hayvan=new List<string>(hayvanlar);

            // Remove All List
            hayvan.Clear();


            // Add property into the list
            List<Person> person=new List<Person>();

            Person user1=new Person();
            user1.Name="Kenan";
            user1.Surname="Akbarov";
            user1.Age=25;

            Person user2=new Person();
            user2.Name="Ahmet";
            user2.Surname="Doğan";
            user2.Age=18;

            person.Add(user1);
            person.Add(user2);

            List<Person> person2=new List<Person>();
            person2.Add(new Person(){
                   Name="Deniz",
                   Surname="Arda",
                   Age=12    
            });

            foreach (Person users in person)
            {
                Console.WriteLine(users.Name);
                Console.WriteLine(users.Surname);
                Console.WriteLine(users.Age);

            }
            foreach (Person users2 in person2)
            {
                Console.WriteLine(users2.Name);
                Console.WriteLine(users2.Surname);
                Console.WriteLine(users2.Age);
            }
            person2.Clear();
    } 
}
        class Person{
            private string name;
            private string surname;
            private int age;

            public string Name{get=>name; set=>name=value;}
            public string Surname{ get=> surname; set=>surname=value;}
            public int Age { get=>age; set=> age=value;}


    }
}
