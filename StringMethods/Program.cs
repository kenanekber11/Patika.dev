using System;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
        string degisken ="c# Kursuna Hoşgeldiniz";
        string degisken2 ="C Sharp Course";

        Console.WriteLine(degisken.Length);
        Console.WriteLine(degisken.ToLower());
        Console.WriteLine(degisken.ToUpper()); 

        //Concat
        Console.WriteLine(string.Concat(degisken," merhaba: "));

        // Compare, CompareTo
        Console.WriteLine(degisken.CompareTo(degisken2));
        Console.WriteLine(string.Compare(degisken,degisken2,true));
        Console.WriteLine(string.Compare(degisken,degisken2,false));

        // Contains
        Console.WriteLine(degisken.Contains(degisken2));

        //IndexOf
        Console.WriteLine(degisken.IndexOf("Kur"));

        // Insert
        Console.WriteLine(degisken2.Insert(0,"Merhaba: "));

        // LastIndexOf
        Console.WriteLine(degisken2.LastIndexOf("i"));

        // PadLeft, PadRight
        Console.WriteLine(degisken+ degisken2.PadLeft(50));
        Console.WriteLine(degisken+ degisken2.PadLeft(50,'*'));
        Console.WriteLine(degisken.PadRight(40)+ degisken2);
        Console.WriteLine(degisken.PadRight(40,'+'));

        // Remove
        Console.WriteLine(degisken.Remove(10));
        Console.WriteLine(degisken.Remove(10,3));
        Console.WriteLine(degisken.Remove(0,1));

        // Replace
        Console.WriteLine(degisken.Replace("c#","C#"));
        Console.WriteLine(degisken.Replace(" ","*"));

        //Split
        Console.WriteLine(degisken.Split(' ')[0]);

        //Substring 
        Console.WriteLine(degisken.Substring(8));
       Console.WriteLine(degisken.Substring(8,10));
       // Yukardaki örnekte '10' değişken sayısını ifade eder 

        }
    }   
}
