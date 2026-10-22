using System;
using System.Collections.Generic;
using System.Text;

namespace EromuApp
{
    public class Eromu
    {
        public string Azonosito { get; set; }
        
        protected int kapacitasKW;
        //public static OsszesEromuSzama{ get; }
        //private static osszesEromuSzama; mind a ketto hisztizik
        public int szamlalo;
        public int KapacitasKW { get; set
            {
                if (value <= 0)
                {
                    value = 100;
                }
            }
        }
        public Eromu( string azonosito,int kapacitas)
        {
            azonosito = Azonosito;
            kapacitas = KapacitasKW;
            szamlalo++;
        }
        public virtual int NapiTermeles(int orakSzama)
        {
            return KapacitasKW * orakSzama;
        }
        public override string ToString()
        {
            return $"Erőmű {Azonosito} | Kapacitás: {KapacitasKW} kW";
        }



    }
}
