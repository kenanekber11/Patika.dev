using System;

namespace Interface_2
{
    class Civic : IOtomobil
    {
        public Marka HangiMarkan─▒nAraci()
        {
            return Marka.Honda;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Beyaz;
        }
    }



}