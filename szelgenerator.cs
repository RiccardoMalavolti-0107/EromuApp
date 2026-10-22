using System;
using System.Collections.Generic;
using System.Text;

namespace EromuApp
{
    public class Szelgenerator : Eromu
    {
        int Toronymagassag { get; set; }

        public Szelgenerator(int toronymagassag,string azonosito,int kapacitas) :base(azonosito, kapacitas)
        {
            Toronymagassag = toronymagassag;
            
        }
        public override int NapiTermeles(int orakSzama)
        {
            return base.NapiTermeles(orakSzama) + Toronymagassag * 10 * orakSzama;
        }
        public override string ToString()
        {
            return base.ToString() + $" | Toronymagasság: {Toronymagassag} m";
        }

    }
}
