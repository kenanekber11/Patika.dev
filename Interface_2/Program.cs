using System;

namespace Interface_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Focus focus=new Focus();
            Console.WriteLine(focus.HangiMarkanınAraci());
            Console.WriteLine(focus.KacTekerlektenOlusur());
            Console.WriteLine(focus.StandartRengiNe());

            Civic civic=new Civic();
            Console.WriteLine(civic.HangiMarkanınAraci());
            Console.WriteLine(civic.KacTekerlektenOlusur());
            Console.WriteLine(civic.StandartRengiNe());
        }
    }
}
