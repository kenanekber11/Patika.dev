using System;

namespace Interface_2
{
    class Focus : IOtomobil
    {
        public Marka HangiMarkan─▒nAraci()
        {
            return Marka.Ford;
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