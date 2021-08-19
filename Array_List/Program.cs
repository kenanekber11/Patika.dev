using System;
using System.Collections;
using System.Collections.Generic;

namespace Array_List
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list =new ArrayList();
            list.Add(21);
            list.Add(10);

            // Add Range
            Console.WriteLine("*******Add Range*******");
            List<int> sayilar=new List<int>(){45,62,31,32,18};
            list.AddRange(sayilar);

            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine("*******Sort*******");
            list.Sort();

            foreach(var item in list)
                Console.WriteLine(item);

            Console.WriteLine("********Reverse*********");

            list.Reverse();
            foreach(var item in list)
                Console.WriteLine(item);
            
            //Clear
            Console.WriteLine("*********Clear*********");
            list.Clear();
            foreach(var item in list)
                Console.WriteLine(item);

        }
    }
}
