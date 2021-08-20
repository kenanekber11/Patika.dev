using System;

namespace Inheritance_
{
    class Program
    {
        static void Main(string[] args)
        {
           //                       Canlılar
           //                           |
           //           Bitkiler                   Hayvanlar
           //         |           |              |           |
           //      Tohumlu     Tohumsuz       Sürüngenler  Kuşlar


         /*
            TohumluBitkiler tohumlu=new TohumluBitkiler();
            tohumlu.Beslenme();         // ==> Canlılar
            tohumlu.Fotosentez();       // ==> Bitkiler
            tohumlu.Solunum();          // ==> Canlılar
            tohumlu.TohumlaCogalma();   // ==> TohumluBitkiler
            
             Bu şekilde kontrolü dışarıya açarak yazmak aslında doğru değildir..
             Bu yüzden yukardaki kodları yorum satırı yapıyorum
         */

         /*
            Surungenler solucan=new Surungenler();
             solucan.Adaptasyon();
             solucan.Beslenme();
             solucan.Solunum();
             solucan.SurunerekHareketEtme();
         */
            // Bu şekilde kontrolü dışarıya açarak yazmak aslında doğru değildir..
            // Bu yüzden yukardaki kodları yorum satırı yapıyorum
        //------------------------------------------------------------------ 

        // Doğru kullanım aşağıdakı gibidir..
        // protected yaparak hemde Main içerisinde kod kalabalığından kurtulmuş olduk
        Surungenler surungenler=new Surungenler();
        surungenler.SurunerekHareketEtme();

        Console.WriteLine("----------------------------------");

        TohumluBitkiler tohumlu=new TohumluBitkiler();
        tohumlu.TohumlaCogalma();

        
        }
    }
}
