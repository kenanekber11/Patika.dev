using System;
namespace Inheritance_
{
    public class Canlilar
    {
        protected void Beslenme()
        {
            Console.WriteLine("Tüm canlılar beslenir");
        }

        protected void Solunum(){
            Console.WriteLine("Tüm canlılar solunum yapar.");
        }
        public virtual void UyaranlaraTepki(){
            Console.WriteLine("Canlılar Uyaranlara tepki verir.");
        }
        
    }
}
