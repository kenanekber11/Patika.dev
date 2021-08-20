using System;
namespace Inheritance_
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir..");
        }
    }
    public class Surungenler : Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon();
            base.Solunum();
            base.Beslenme();
        }
        public void SurunerekHareketEtme()
        {
            Console.WriteLine("Sürüngenler sürünerek hareket eder");
        }
    }

    public class Kuslar : Hayvanlar
    {
        public Kuslar(){
            base.Adaptasyon();
            base.Solunum();
            base.Beslenme();
        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}