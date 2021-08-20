using System;
namespace Inheritance_
{
    public class Hayvanlar : Canlilar
    {
        protected void Adaptasyon()
        {
            Console.WriteLine("Hayvanlar adaptasyon kurabilir..");
        }
        public override void UyaranlaraTepki()
        {
            base.UyaranlaraTepki();
            Console.WriteLine("Hayvanlar temasa tepki verir");
        }
    }
    public class Surungenler : Hayvanlar
    {
        public Surungenler(){
            base.Adaptasyon();
            base.Solunum();
            base.Beslenme();
            base.UyaranlaraTepki();
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
            base.UyaranlaraTepki();

        }
        public void Ucmak()
        {
            Console.WriteLine("Kuşlar uçar");
        }
    }
}