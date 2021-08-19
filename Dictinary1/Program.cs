using System;
using System.Collections.Generic;

namespace Dictinary1
{
    class Program
    {
        static void Main(string[] args)
        {
           Dictionary<int,string> users=new Dictionary<int, string>();
            users.Add(12,"Ayşe Yılmaz");
            users.Add(15,"Ahmet Yılmaz");
            users.Add(18,"Deniz Arda");
            users.Add(20,"Özcan Coşar");

            Console.WriteLine(users[12]);

            foreach (var user in users)
            {
                Console.WriteLine(user);
            }

            // Count
            Console.WriteLine(users.Count);

            Console.WriteLine(users.ContainsKey(12));
            Console.WriteLine(users.ContainsValue("Arda"));

            // Remove 
            Console.WriteLine("*****Remove*****");
            users.Remove(12);
            
            foreach (var user in users)
                Console.WriteLine(user.Key);        

            // Keys 
            foreach (var user in users.Keys)
                Console.WriteLine(user);
    

            // Values
            foreach (var user in users.Values)
                Console.WriteLine(user);
        
        }
    }
}
