using System;

namespace Array_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sort
            int[] sayilar = { 23, 82, 12, 5, 74, 115, 42 };

            Console.WriteLine("****Sırasız Dizi*****");
            foreach (var item in sayilar)
                Console.WriteLine(item);

            Console.WriteLine("*****Sıralı Dizi*****");
            Array.Sort(sayilar);
            foreach (var item1 in sayilar)
                Console.WriteLine(item1);

            //Clear
            Console.WriteLine("******Array Clear *****");
            Array.Clear(sayilar, 3, 2);
            foreach (var sayi in sayilar)
                Console.WriteLine(sayi);

            Console.WriteLine("******Array Reverse*****");
            //Reverse 
            Array.Reverse(sayilar);
            foreach (var sayi1 in sayilar)
                Console.WriteLine(sayi1);

            Console.WriteLine("******Array IndexOf*****");
            Console.WriteLine(Array.IndexOf(sayilar,0));

            Console.WriteLine("******Array Resize*****");
            Array.Resize<int>(ref sayilar,8);
            sayilar[7]=99;
            foreach(var sayi in sayilar)
                Console.WriteLine(sayi);

        }
    }
}
